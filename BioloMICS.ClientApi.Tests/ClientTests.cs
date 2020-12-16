using BioloMICS.ClientApi.Client;
using BioloMICS.ClientApi.Client.Authentication;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BioloMICS.ClientApi.Tests
{
	class ClientTests
	{
		protected int WebsiteId = 1;
		protected string TableView = "WS Mirri";

		protected BiolomicsClient Client;

		[OneTimeSetUp]
		public void SetupClient()
		{
			Client = new BiolomicsClient(baseUri: "http://localhost:8080", new ClientCredentials { ClientId = "xx", ClientSecret = "xx" });
		}
	}
}
