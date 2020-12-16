using BioloMICS.ClientApi.Model;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace BioloMICS.ClientApi.Client.Authentication
{
	public class BiolomicsAuthenticator : IAuthenticator
	{
		const string TokenEndPoint = "connect/token";
		const string ClientCredentialsGrantType = "client_credentials";
		const string PasswordCredentialsGrantType = "password";
		const string RefreshGrantType = "refresh_token";

		private ClientCredentials _credentials;
		private DateTime _lastAuthenticateDateTime;
		private bool _isAuthenticated;
		private bool _isUserAuthenticated;
		private int _expiresIn;
		private string _accessToken;
		private string _refreshToken;
		private IRestClient tokenClient;
		private string tokenUri;
		private UserModel _currentUser;

		public int ExpiresIn 
		{
			get { return _expiresIn; }
		}

		public bool IsUserAuthenticated
		{
			get { return _isUserAuthenticated; }
		}

		public UserModel CurrentUser
		{
			get { return _currentUser; }
		}

		public BiolomicsAuthenticator(ClientCredentials credentials)
		{
			_credentials = credentials;
			tokenClient = new RestClient();
			tokenClient.UseSerializer(() => new JsonNetSerializer());
		}

		public void Authenticate(IRestClient client, IRestRequest request)
		{
			var expired = _expiresIn != 0 ? DateTime.Now >= _lastAuthenticateDateTime.AddSeconds(_expiresIn) : false;

			if (!_isAuthenticated || expired)
			{
				var tokenRequest = new RestRequest(tokenUri = (new Uri(client.BaseUrl, TokenEndPoint)).ToString(), Method.POST);
				tokenRequest.AddHeader("content-type", "application/x-www-form-urlencoded");
				if (_credentials is PasswordCredentials && !expired)
				{
					var passwordCredentials = (PasswordCredentials)_credentials;
					tokenRequest.AddObject(new { 
						client_id = passwordCredentials.ClientId,
						client_secret = passwordCredentials.ClientSecret,
						passwordCredentials.UserName,
						passwordCredentials.Password,
						grant_type = PasswordCredentialsGrantType });
				}
				else
				{
					tokenRequest.AddObject(new { 
						client_id = _credentials.ClientId,
						client_secret = _credentials.ClientSecret,
						grant_type = ClientCredentialsGrantType });
					_isUserAuthenticated = false;
					_currentUser = null;
				}

				var response = tokenClient.Execute<OAuthReponse>(tokenRequest);

				if (response.IsSuccessful)
				{
					_lastAuthenticateDateTime = DateTime.Now;
					_isAuthenticated = true;	
					_accessToken = response.Data.BearerToken;
					_refreshToken = response.Data.RefreshToken;
					_expiresIn = response.Data.ExpiresIn;		

					if (_credentials is PasswordCredentials) 
					{
						_isUserAuthenticated = true;
						var token = new JwtSecurityToken(response.Data.BearerToken);
						_currentUser = new UserModel
						{
							Id = int.Parse(token.Claims.First(x => x.Type == "Id").Value),
							Name = token.Claims.First(x => x.Type == "Name").Value
						};
					}
				}
			}

			request.AddHeader("Authorization", string.Format("Bearer {0}", _accessToken));
		}

		public bool Refresh() 
		{
			var tokenRequest = new RestRequest(tokenUri, Method.POST);
			tokenRequest.AddHeader("content-type", "application/x-www-form-urlencoded");

			if (_credentials is PasswordCredentials)
			{
				var passwordCredentials = (PasswordCredentials)_credentials;
				tokenRequest.AddObject(new
				{
					client_id = passwordCredentials.ClientId,
					refresh_token = _refreshToken,
					grant_type = RefreshGrantType
				});
			}

			var response = tokenClient.Execute<OAuthReponse>(tokenRequest);

			bool success;
			if (success = response.IsSuccessful)
			{
				_lastAuthenticateDateTime = DateTime.Now;
				_accessToken = response.Data.BearerToken;
				_refreshToken = response.Data.RefreshToken;
				_expiresIn = response.Data.ExpiresIn;
			}

			return success;
		}
	}
}
