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

		private BiolomicsClient _client;

		[OneTimeSetUp]
		public void SetupClient()
		{
			_client = new BiolomicsClient(baseUri: _baseUri, new ClientCredentials { ClientId = _clientId, ClientSecret = _secret });
		}

		[Test]
		public void SchemasTest() 
		{
			var schemas = _client.GetSchemas();

			Assert.IsTrue(schemas.Any(x=> x.WebsiteId == _websiteId) && schemas.First(x=>x.WebsiteId == _websiteId).TableViews.Any(x=> x.TableViewName == _tableView));
		}

		[Test]
		public void GetRecordByIdTest()
		{
			var repository = _client.GetRepository(websiteId: _websiteId);
			
			var result = repository.GetRecordById<StrainsModel>(id: 50000);

			var result2 = repository.GetRecordById(tableView: _tableView, id: 50000);

			Assert.IsTrue(result.Id == 50000);
		}

		[Test]
		public void SearchTest()
		{
			//Example.
			//Queryable<TestModel>.Not(x => x.TestProperty, QueryOperationEnum.NbrIsEqualTo, 0)
			//			.And(x => x.TestProperty, QueryOperationEnum.NbrIsSmallerThan, 0)
			//			.Or(x => x.TestProperty, QueryOperationEnum.NbrIsDifferentFrom, 0);

			var repository = _client.GetRepository(websiteId: _websiteId);	

			var result3 = repository.Search(Queryable<StrainsModel>.Not(x => x.Id, QueryOperationEnum.NbrIsEqualTo, 3));

			Assert.IsTrue(result3.Records.All(x => x.Id != 3));
		}

	}
}
