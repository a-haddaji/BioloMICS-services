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
		[Test]
		public void CreateAndUpdateTest()
		{
			var repository = Client.GetRepository(websiteId: WebsiteId);

			var date = DateTime.Now;

			var recordName = $"New record - {date}";

			var fieldValue = $"Test - {date}";

			var success = repository.Create(tableView: TableView, new RecordData
			{
				RecordName = recordName,
				Data = new Dictionary<string, ValueOfFieldBase>()
				{
					{ "Other culture collection numbers", new ValueOfFieldE { Value = fieldValue} }
				}
			});

			Assert.IsTrue(success);

			var result = repository.FindByName<StrainsModel>(recordName);

			Assert.IsTrue(result.Name == recordName && result.OtherCollection == fieldValue);

			var success2 = repository.Update(tableView: TableView, new Record
			{
				RecordName = recordName,
				RecordId = result.Id,
				Data = new Dictionary<string, ValueOfFieldBase>()
				{
					{ "Other culture collection numbers", new ValueOfFieldE { Value = "Updated"} }
				}
			});

			Assert.IsTrue(success);

			var result3 = repository.FindByName<StrainsModel>(recordName);

			Assert.IsTrue(result3.Name == recordName && result3.OtherCollection == "Updated");
		}
	}
}
