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

		public BiolomicsClient(string baseUri, ClientCredentials credentials)
		{
			_client = new RestClient(baseUri);
			_client.ThrowOnDeserializationError = true;
			_client.ThrowOnAnyError = true;
			_client.Authenticator = new BiolomicsAuthenticator(credentials);
			_client.UseSerializer(() => new JsonNetSerializer());
		}

		public BiolomicsClient(Uri baseUri, ClientCredentials credentials)
		{
			_client = new RestClient(baseUri);
			_client.ThrowOnDeserializationError = true;
			_client.ThrowOnAnyError = true;
			_client.Authenticator = new BiolomicsAuthenticator(credentials);
			_client.UseSerializer(() => new JsonNetSerializer());
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
