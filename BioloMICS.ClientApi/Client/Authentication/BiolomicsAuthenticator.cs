using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using System;

namespace BioloMICS.ClientApi.Client.Authentication
{
	public class BiolomicsAuthenticator : IAuthenticator
	{
		const string TokenEndPoint = "connect/token";
		const string ClientCredentialsGrantType = "client_credentials";
		const string PasswordCredentialsGrantType = "password";

		private ClientCredentials _credentials;
		private bool _isConnected;
		private int _expiresIn;
		private string _accessToken;
		private IRestClient tokenClient;
		public BiolomicsAuthenticator(ClientCredentials credentials)
		{
			_credentials = credentials;
			tokenClient = new RestClient();
			tokenClient.UseSerializer(() => new JsonNetSerializer());
		}

		public void Authenticate(IRestClient client, IRestRequest request)
		{
			if (!_isConnected)
			{
				var tokenRequest = new RestRequest((new Uri(client.BaseUrl, TokenEndPoint)).ToString(), Method.POST);
				tokenRequest.AddHeader("content-type", "application/x-www-form-urlencoded");
				if (_credentials is PasswordCredentials)
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
				}

				var response = tokenClient.Execute<OAuthReponse>(tokenRequest);

				if (response.IsSuccessful)
				{
					_isConnected = true;
					_accessToken = response.Data.BearerToken;
					_expiresIn = response.Data.ExpiresIn;
				}
			}

			request.AddHeader("Authorization", string.Format("Bearer {0}", _accessToken));
		}
	}
}
