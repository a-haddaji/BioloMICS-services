using BioloMICS.ClientApi.Extentions;
using BioloMICS.ClientApi.Model;
using BioloMICS.ClientApi.Tests.Model;
using NUnit.Framework;
using System.Linq;

namespace BioloMICS.ClientApi.Tests
{
	[TestFixture]
	class SearchTests : ClientTests
	{
		[Test]
		public void SchemasTest() 
		{
			var schemas = Client.GetSchemas();

			Assert.IsTrue(schemas.Any(x=> x.WebsiteId == WebsiteId) && schemas.First(x=>x.WebsiteId == WebsiteId).TableViews.Any(x=> x.TableViewName == TableView));
		}

		[Test]
		public void GetRecordByIdTest()
		{
			var repository = Client.GetRepository(websiteId: WebsiteId);
			
			var result = repository.GetRecordById<StrainsModel>(id: 50000);

			var result2 = repository.GetRecordById(tableView: TableView, id: 50000);

			Assert.IsTrue(result.Id == 50000);
		}

		[Test]
		public void GetRecordByNameTest()
		{
			var repository = Client.GetRepository(websiteId: WebsiteId);

			var result = repository.FindByName<StrainsModel>(name: "MIRRI 107451");

			Assert.IsTrue(result.Name == "MIRRI 107451");
		}

		[Test]
		public void SearchTest()
		{
			//Example.
			//Queryable<TestModel>.Not(x => x.TestProperty, QueryOperationEnum.NbrIsEqualTo, 0)
			//			.And(x => x.TestProperty, QueryOperationEnum.NbrIsSmallerThan, 0)
			//			.Or(x => x.TestProperty, QueryOperationEnum.NbrIsDifferentFrom, 0);

			var repository = Client.GetRepository(websiteId: WebsiteId);	

			var result3 = repository.Search(Queryable<StrainsModel>.Not(x => x.Id, QueryOperationEnum.NbrIsEqualTo, 3));

			Assert.IsTrue(result3.Records.All(x => x.Id != 3));
		}
	}
}
