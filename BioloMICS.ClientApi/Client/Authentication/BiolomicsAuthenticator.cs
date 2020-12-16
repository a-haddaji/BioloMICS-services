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
		private string _accessToken;
		private string _refreshToken;
		private IRestClient tokenClient;
		private string tokenUri;

		public int ExpiresIn { get; private set; }

		public bool IsUserAuthenticated { get; private set; }

		public UserModel CurrentUser { get; private set; }

		public BiolomicsAuthenticator(ClientCredentials credentials)
		{
			_credentials = credentials;
			tokenClient = new RestClient();
			tokenClient.UseSerializer(() => new JsonNetSerializer());
		}

		public void Authenticate(IRestClient client, IRestRequest request)
		{
			var expired = ExpiresIn != 0 ? DateTime.Now >= _lastAuthenticateDateTime.AddSeconds(ExpiresIn) : false;

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
					IsUserAuthenticated = false;
					CurrentUser = null;
				}

				var response = tokenClient.Execute<OAuthReponse>(tokenRequest);

				if (response.IsSuccessful)
				{
					_lastAuthenticateDateTime = DateTime.Now;
					_isAuthenticated = true;	
					_accessToken = response.Data.BearerToken;
					_refreshToken = response.Data.RefreshToken;
					ExpiresIn = response.Data.ExpiresIn;		

					if (_credentials is PasswordCredentials) 
					{
						IsUserAuthenticated = true;
						var token = new JwtSecurityToken(response.Data.BearerToken);
						CurrentUser = new UserModel
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
				ExpiresIn = response.Data.ExpiresIn;
			}

			return success;
		}
	}
}
