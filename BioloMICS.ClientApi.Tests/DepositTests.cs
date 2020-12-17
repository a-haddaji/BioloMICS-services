﻿using BioloMICS.ClientApi.Client;
using BioloMICS.ClientApi.Client.Authentication;
using BioloMICS.ClientApi.Model;
using BioloMICS.ClientApi.Tests.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BioloMICS.ClientApi.Tests
{
	[TestFixture]
	class DepositTests : ClientTests
	{
		private int createdRecordId;
		public override void SetupClient()
		{
			Client = new BiolomicsClient(baseUri: "https://localhost:8080", new PasswordCredentials { ClientId = "xx", ClientSecret = "xx", UserName = "xx", Password = "xx" });
		}

		[Test]
		public void CreateTest()
		{
			var repository = Client.GetRepository(websiteId: WebsiteId);

			var date = DateTime.Now;

			var recordName = $"New record - {date}";

			var fieldValue = $"Test - {date}";

			var response = repository.Create(tableView: TableView, new RecordData
			{
				RecordName = recordName,
				Data = new Dictionary<string, ValueOfFieldBase>()
				{
					{ "Collection accession number", new ValueOfFieldE { Value = fieldValue} }
				}
			});

			createdRecordId = response.RecordId;

			Assert.IsTrue(response.RecordName == recordName);

			var result = repository.FindByName<StrainsModel>(recordName);

			Assert.IsTrue(result.Name == recordName && result.CollectionAccessionNumber == fieldValue);
		}

		[Test]
		public void UpdateTest()
		{
			var repository = Client.GetRepository(websiteId: WebsiteId);

			var date = DateTime.Now;

			var recordName = $"New record - {date}";

			var response = repository.Update(tableView: TableView, new Record
			{
				RecordName = recordName,
				RecordId = createdRecordId,
				Data = new Dictionary<string, ValueOfFieldBase>()
				{
					{ "Collection accession number", new ValueOfFieldE { Value = "Updated"} }
				}
			});

			Assert.IsTrue(((ValueOfFieldE)response.Data["Collection accession number"]).Value == "Updated");

			var result = repository.FindByName<StrainsModel>(recordName);

			Assert.IsTrue(result.Name == recordName && result.CollectionAccessionNumber == "Updated");
		}
	}
}
