using BioloMICS.ClientApi.Client;
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
		public override void SetupClient()
		{
			Client = new BiolomicsClient(baseUri: "http://localhost:52145/", new PasswordCredentials { ClientId = "xx", ClientSecret = "xx", UserName = "xx", Password = "xx" });
		}

		[Test]
		public void CreateAndUpdateTest()
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
					{ "Other culture collection numbers", new ValueOfFieldE { Value = fieldValue} }
				}
			});

			Assert.IsTrue(response.RecordName == recordName);

			var result = repository.FindByName<StrainsModel>(recordName);

			Assert.IsTrue(result.Name == recordName && result.OtherCollection == fieldValue);

			var response2 = repository.Update(tableView: TableView, new Record
			{
				RecordName = recordName,
				RecordId = result.Id,
				Data = new Dictionary<string, ValueOfFieldBase>()
				{
					{ "Other culture collection numbers", new ValueOfFieldE { Value = "Updated"} }
				}
			});

			Assert.IsTrue(((ValueOfFieldE)response2.Data["Other culture collection numbers"]).Value == "Updated");

			var result3 = repository.FindByName<StrainsModel>(recordName);

			Assert.IsTrue(result3.Name == recordName && result3.OtherCollection == "Updated");
		}
	}
}
