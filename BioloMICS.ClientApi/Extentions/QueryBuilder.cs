using BioloMICS.ClientApi.Model;
using System;
using System.Linq.Expressions;
using System.Linq;
using Newtonsoft.Json;

namespace BioloMICS.ClientApi.Extentions
{
	public class Queryable<ModelType> where ModelType : class
	{
		private SearchQuery _searchModel;
		public static Queryable<ModelType> Not<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			var search = new SearchQuery() { Expression = "Not Q0" };
			AppendCondition(search, GetFieldName(selector), operation, value);
			return new Queryable<ModelType>(search);
		}

		public static Queryable<ModelType> For<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			var search = new SearchQuery() { Expression = "Q0" };
			AppendCondition(search, GetFieldName(selector), operation, value.ToString());
			return new Queryable<ModelType>(search);
		}


		public Queryable<ModelType> And<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			AppendCondition(GetFieldName(selector), operation, value.ToString());
			AppendLogicOperation("And");
			return this;
		}

		public Queryable<ModelType> Or<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			AppendCondition(GetFieldName(selector), operation, value);
			AppendLogicOperation("Or");
			return this;
		}

		public Queryable<ModelType> AndNot<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			AppendCondition(GetFieldName(selector), operation, value);
			AppendLogicOperation("AndNot");
			return this;
		}

		public Queryable<ModelType> OrNot<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			AppendCondition(GetFieldName(selector), operation, value);
			AppendLogicOperation("OrNot");
			return this;
		}

		private void AppendCondition<PropertyType>(string fieldName, QueryOperationEnum operation, PropertyType value)
		{
			_searchModel.Query.Add(new ConditionEntity { Index = _searchModel.Query.Count, FieldName = fieldName, Operation = operation, Value = value.ToString() });
		}

		private static void AppendCondition<PropertyType>(SearchQuery searchModel , string fieldName, QueryOperationEnum operation, PropertyType value)
		{
			searchModel.Query.Add(new ConditionEntity { Index = searchModel.Query.Count, FieldName = fieldName, Operation = operation, Value = value.ToString() });
		}

		private void AppendLogicOperation(string operation)
		{
			_searchModel.Expression = $"{_searchModel.Expression} {operation} Q{_searchModel.Query.Last().Index}";
		}

		public SearchQuery Compile()
		{
			return _searchModel;
		}

		private static string GetFieldName<PropertyType>(Expression<Func<ModelType, PropertyType>> selector)
		{
			var expression = (MemberExpression)selector.Body;
			var jAttribute = Attribute.GetCustomAttribute(expression.Member, typeof(JsonPropertyAttribute)) as JsonPropertyAttribute;
			if (jAttribute == null)
			{
				return expression.Member.Name;
			}

			return jAttribute.PropertyName;
		}

		private Queryable()
		{
			_searchModel = new SearchQuery();
		}

		private Queryable(SearchQuery searchModel)
		{
			_searchModel = searchModel;
		}
	}
}
