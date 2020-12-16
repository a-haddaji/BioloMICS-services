using BioloMICS.ClientApi.Client;
using BioloMICS.ClientApi.Client.Authentication;
using BioloMICS.ClientApi.Extentions;
using BioloMICS.ClientApi.Model;
using BioloMICS.ClientApi.Tests.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BioloMICS.ClientApi.Tests
{
	[TestFixture]
	class ClientTests
	{
		private string _baseUri = "https://localhost:8080";
		private string _clientId = "xx";
		private string _secret = "xx";
		private int _websiteId = 1;
		private string _tableView = "xx";

		//[Test]
		public void SchemasTest() 
		{
			var client = new BiolomicsClient(baseUri: _baseUri, new ClientCredentials { ClientId = _clientId, ClientSecret = _secret });
			
			var schemas = client.GetSchemas();

			Assert.IsTrue(schemas.Any(x=> x.WebsiteId == _websiteId) && schemas.First(x=>x.WebsiteId == _websiteId).TableViews.Any(x=> x.TableViewName == _tableView));
		}

		//[Test]
		public void GetRecordByIdTest()
		{
			var client = new BiolomicsClient(baseUri: _baseUri, new ClientCredentials { ClientId = _clientId, ClientSecret = _secret });

			var repository = client.GetRepository(websiteId: _websiteId);
			
			var result = repository.GetRecordById<StrainsModel>(id: 50000);

			var result2 = repository.GetRecordById(tableView: _tableView, id: 50000);

			Assert.IsTrue(result.Id == 50000);
		}

		//[Test]
		public void SearchTest()
		{
			//Example.
			//Queryable<TestModel>.Not(x => x.TestProperty, QueryOperationEnum.NbrIsEqualTo, 0)
			//			.And(x => x.TestProperty, QueryOperationEnum.NbrIsSmallerThan, 0)
			//			.Or(x => x.TestProperty, QueryOperationEnum.NbrIsDifferentFrom, 0);

			var client = new BiolomicsClient(baseUri: _baseUri, new ClientCredentials { ClientId = _clientId, ClientSecret = _secret });

			var repository = client.GetRepository(websiteId: _websiteId);	

			var result3 = repository.Search(Queryable<StrainsModel>.Not(x => x.Id, QueryOperationEnum.NbrIsEqualTo, 3));

			Assert.IsTrue(result3.Records.All(x => x.Id != 3));
		}

		[Test]
		public void CreateAndUpdateTest()
		{
			var client = new BiolomicsClient(baseUri: _baseUri, new ClientCredentials { ClientId = _clientId, ClientSecret = _secret });

			var repository = client.GetRepository(websiteId: _websiteId);

			var date = DateTime.Now;

			var recordName = $"New record - {date}";

			var fieldValue = $"Test - {date}";

			var success = repository.Create(tableView: _tableView, new RecordData
			{
				RecordName = recordName, Data = new Dictionary<string, ValueOfFieldBase>()
				{
					{ "Other culture collection numbers", new ValueOfFieldE { Value = fieldValue} }
				}
			});

			Assert.IsTrue(success);

			var result = repository.FindByName<StrainsModel>(recordName);

			Assert.IsTrue(result.Name == recordName && result.OtherCollection == fieldValue);

			var success2 = repository.Update(tableView: _tableView, new Record
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
