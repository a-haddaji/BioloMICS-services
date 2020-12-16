﻿using BioloMICS.ClientApi.Client;
using BioloMICS.ClientApi.Client.Authentication;
using NUnit.Framework;

namespace BioloMICS.ClientApi.Tests
{
	abstract class ClientTests
	{
		protected int WebsiteId = 1;
		protected string TableView = "WS Mirri";

		protected BiolomicsClient Client;

		[OneTimeSetUp]
		public virtual void SetupClient()
		{
			Client = new BiolomicsClient(baseUri: "https://localhost:8080", new ClientCredentials { ClientId = "xx", ClientSecret = "xx" });
		}
	}
}