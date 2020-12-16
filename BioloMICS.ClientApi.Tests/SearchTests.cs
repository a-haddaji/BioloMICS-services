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
		[Test]
		public void SchemasTest() 
		{
			var client = new BiolomicsClient(baseUri: "http://localhost:52145", new ClientCredentials { ClientId = "xx", ClientSecret = "xx" });
			
			var schemas = client.GetSchemas();

			Assert.IsTrue(schemas.Any(x=> x.WebsiteId == 87) && schemas.First(x=>x.WebsiteId == 87).TableViews.Any(x=> x.TableViewName == "Strains"));
		}

		[Test]
		public void GetRecordByIdTest()
		{
			var client = new BiolomicsClient(baseUri: "http://localhost:52145", new ClientCredentials { ClientId = "xx", ClientSecret = "xx" });

			var repository = client.GetRepository(websiteId: 87);

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

			var client = new BiolomicsClient(baseUri: "http://localhost:52145", new ClientCredentials { ClientId = "xx", ClientSecret = "xx" });

			var repository = client.GetRepository(websiteId: 87);
			

			var result3 = repository.Search(Queryable<StrainsModel>.Not(x => x.Id, QueryOperationEnum.NbrIsEqualTo, 3));

			Assert.IsTrue(result3.Records.All(x => x.Id != 3));
		}
	}
}
