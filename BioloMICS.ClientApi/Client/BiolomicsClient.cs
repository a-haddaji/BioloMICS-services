using BioloMICS.ClientApi.Client.Authentication;
using BioloMICS.ClientApi.Model;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;

namespace BioloMICS.ClientApi.Client
{
	public class BiolomicsClient
	{
		private RestClient _client;
		private BiolomicsAuthenticator _authenticator;

		public BiolomicsClient(string baseUri, ClientCredentials credentials)
		{
			_client = new RestClient(baseUri);
			_client.ThrowOnDeserializationError = true;
			_client.ThrowOnAnyError = true;
			_authenticator = new BiolomicsAuthenticator(credentials);
			_client.Authenticator = _authenticator;
			_client.UseSerializer(() => new JsonNetSerializer());
		}

		public BiolomicsClient(Uri baseUri, ClientCredentials credentials)
		{
			_client = new RestClient(baseUri);
			_client.ThrowOnDeserializationError = true;
			_client.ThrowOnAnyError = true;
			_authenticator = new BiolomicsAuthenticator(credentials);
			_client.Authenticator = _authenticator;
			_client.UseSerializer(() => new JsonNetSerializer());
		}

		public int ExpiresIn 
		{ 
			get { return _authenticator.ExpiresIn; }
		}

		public bool IsUserAuthenticated
		{
			get { return _authenticator.IsUserAuthenticated; }
		}

		public UserModel CurrentUser
		{
			get { return _authenticator.CurrentUser; }
		}

		public bool ExtendUserSession() 
		{
			return _authenticator.Refresh();
		}

		public IEnumerable<WebSchema> GetSchemas()
		{
			var request = new RestRequest("schemas", Method.GET);
			var response = _client.Execute<IEnumerable<WebSchema>>(request);
			return response.Data;
		}

		public BiolomicsWebsiteRepository GetRepository(int websiteId) 
		{
			return new BiolomicsWebsiteRepository(_client, websiteId);
		}

	}
}
