using BioloMICS.ClientApi.Client;
using BioloMICS.ClientApi.Client.Authentication;
using BioloMICS.ClientApi.Extentions;
using BioloMICS.ClientApi.Model;
using BioloMICS.ClientApi.Tests.Model;
using NUnit.Framework;
using System.Linq;

namespace BioloMICS.ClientApi.Tests
{
	[TestFixture]
	class ClientTests
	{
		private string _baseUri = "http://localhost:8080";
		private string _clientId = "xx";
		private string _secret = "xx";
		private int websiteId = 1;

		[Test]
		public void SchemasTest() 
		{
			var client = new BiolomicsClient(baseUri: _baseUri, new ClientCredentials { ClientId = _clientId, ClientSecret = _secret });
			
			var schemas = client.GetSchemas();

			Assert.IsTrue(schemas.Any(x=> x.WebsiteId == websiteId) && schemas.First(x=>x.WebsiteId == websiteId).TableViews.Any(x=> x.TableViewName == "Strains"));
		}

		[Test]
		public void GetRecordByIdTest()
		{
			var client = new BiolomicsClient(baseUri: _baseUri, new ClientCredentials { ClientId = _clientId, ClientSecret = _secret });

			var repository = client.GetRepository(websiteId: websiteId);
			
			var result = repository.GetRecordById<StrainsModel>(id: 3);

			var result2 = repository.GetRecordById(tableView: "Strains", id: 3);

			Assert.IsTrue(result.Id == 3);
		}

		[Test]
		public void SearchTest()
		{
			//Example.
			//Queryable<TestModel>.Not(x => x.TestProperty, QueryOperationEnum.NbrIsEqualTo, 0)
			//			.And(x => x.TestProperty, QueryOperationEnum.NbrIsSmallerThan, 0)
			//			.Or(x => x.TestProperty, QueryOperationEnum.NbrIsDifferentFrom, 0);

			var client = new BiolomicsClient(baseUri: _baseUri, new ClientCredentials { ClientId = _clientId, ClientSecret = _secret });

			var repository = client.GetRepository(websiteId: websiteId);	

			var result3 = repository.Search(Queryable<StrainsModel>.Not(x => x.Id, QueryOperationEnum.NbrIsEqualTo, 3));

			Assert.IsTrue(result3.Records.All(x => x.Id != 3));
		}
	}
}
