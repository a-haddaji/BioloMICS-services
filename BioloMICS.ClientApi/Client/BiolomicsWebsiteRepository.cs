using BioloMICS.ClientApi.Attributes;
using BioloMICS.ClientApi.Client.Authentication;
using BioloMICS.ClientApi.Extentions;
using BioloMICS.ClientApi.Model;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;

namespace BioloMICS.ClientApi.Client
{
	public class BiolomicsWebsiteRepository
	{
		private IRestClient _client;
		public BiolomicsWebsiteRepository(IRestClient client, int websiteId)
		{
			_client = client;
			_client.AddDefaultHeader("WebsiteId", websiteId.ToString());
		}

		public TEntity GetRecordById<TEntity>(int id) where TEntity : EntityBase
		{
			var request = new RestRequest($"data/{GetTableViewName<TEntity>()}/{id}", Method.GET);
			var response = _client.Execute<TEntity>(request);
			return response.Data;
		}

		public TEntity FindByName<TEntity>(string name) where TEntity : EntityBase
		{
			var request = new RestRequest($"search/{GetTableViewName<TEntity>()}/findByName?name={name}", Method.GET);
			var response = _client.Execute<TEntity>(request);
			return response.Data;
		}


		public Dictionary<string, object> GetRecordById(string tableView, int id)
		{
			var request = new RestRequest($"data/{tableView}/{id}", Method.GET);
			var response = _client.Execute<Dictionary<string, object>>(request);
			return response.Data;
		}

		public SearchSummary<TEntity> Search<TEntity>(Queryable<TEntity> queryable, byte displayStart = 0, byte displayLength = 50) where TEntity : EntityBase
		{
			var request = new RestRequest($"search/{GetTableViewName<TEntity>()}", Method.POST);
			request.AddHeader("content-type", "application/json");
			
			var search = queryable.Compile();	
			request.AddJsonBody(new SearchInputModel { 
				DisplayStart = displayStart, 
				DisplayLength = displayLength, 
				Expression = search.Expression, 
				Query = search.Query 
			});
			var response = _client.Execute<SearchSummary<TEntity>>(request);
			return response.Data;
		}

		private string GetTableViewName<TEntity>()
		{
			var entityType = typeof(TEntity);
			var tableViewAttribute = Attribute.GetCustomAttribute(entityType, typeof(TableViewAttribute)) as TableViewAttribute;
			if (tableViewAttribute == null)
			{
				throw new ArgumentException($"Tableview annotation is missing on the entity of type {entityType.Name}.");
			}

			return tableViewAttribute.TableViewName;
		}
	}
}
