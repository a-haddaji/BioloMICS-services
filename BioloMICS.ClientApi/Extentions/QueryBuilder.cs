using BioloMICS.ClientApi.Model;
using System;
using System.Linq.Expressions;
using System.Linq;
using BioloMICS.ClientApi.Attributes;

namespace BioloMICS.ClientApi.Extentions
{
	public class Queryable<ModelType> where ModelType : class
	{
		private SearchQuery _searchModel;
		public static Queryable<ModelType> Not<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			var search = new SearchQuery() { Expression = "Not Q0" };
			AppendCondition(search, GetFieldKey(selector), operation, value);
			return new Queryable<ModelType>(search);
		}

		public static Queryable<ModelType> For<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			var search = new SearchQuery() { Expression = "Q0" };
			AppendCondition(search, GetFieldKey(selector), operation, value.ToString());
			return new Queryable<ModelType>(search);
		}


		public Queryable<ModelType> And<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			AppendCondition(GetFieldKey(selector), operation, value.ToString());
			AppendLogicOperation("And");
			return this;
		}

		public Queryable<ModelType> Or<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			AppendCondition(GetFieldKey(selector), operation, value);
			AppendLogicOperation("Or");
			return this;
		}

		public Queryable<ModelType> AndNot<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			AppendCondition(GetFieldKey(selector), operation, value);
			AppendLogicOperation("AndNot");
			return this;
		}

		public Queryable<ModelType> OrNot<PropertyType>(Expression<Func<ModelType, PropertyType>> selector, QueryOperationEnum operation, PropertyType value)
		{
			AppendCondition(GetFieldKey(selector), operation, value);
			AppendLogicOperation("OrNot");
			return this;
		}

		private void AppendCondition<PropertyType>(long fieldKey, QueryOperationEnum operation, PropertyType value)
		{
			_searchModel.Query.Add(new ConditionEntity { Index = _searchModel.Query.Count, FieldKey = fieldKey, Operation = operation, Value = value.ToString() });
		}

		private static void AppendCondition<PropertyType>(SearchQuery searchModel , long fieldKey, QueryOperationEnum operation, PropertyType value)
		{
			searchModel.Query.Add(new ConditionEntity { Index = searchModel.Query.Count, FieldKey = fieldKey, Operation = operation, Value = value.ToString() });
		}

		private void AppendLogicOperation(string operation)
		{
			_searchModel.Expression = $"{_searchModel.Expression} {operation} Q{_searchModel.Query.Last().Index}";
		}

		public SearchQuery Compile()
		{
			return _searchModel;
		}

		private static long GetFieldKey<PropertyType>(Expression<Func<ModelType, PropertyType>> selector)
		{
			var expression = (MemberExpression)selector.Body;
			var keyAttribute = Attribute.GetCustomAttribute(expression.Member, typeof(FieldKeyAttribute)) as FieldKeyAttribute;
			if (keyAttribute == null)
			{
				throw new ArgumentException($"FieldKey annotation is missing on property {expression.Member.Name}.");
			}

			return keyAttribute.Key;
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
