using System.ComponentModel.DataAnnotations;


namespace BioloMICS.ClientApi.Model
{
	public class ConditionEntity
	{
		#region Properties
		/// <summary>
		/// The unique key of the field being used as a criteria in a condition.
		/// </summary>
		[Required]
		public long FieldKey { get; set; }
		
		/// <summary>
		/// The index of the critera, this is mandatory to be able to refer to conditions in the expression part.
		/// </summary>
		[Required]
		public int Index { get; set; }

		/// <summary>
		/// The operation being used for the condition, available operations for a given search criteria can be discovered through &lt;a href="#operations-Schemas-GetAvailableSchemas"&gt;schemas&lt;a&gt; endpoint.
		/// </summary>
		[Required]
		public QueryOperationEnum Operation { get; set; }
		/// <summary>
		/// Represente the value of the search condition.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Represents the second valuf of a search criteria, the second value is required when the operation being used is a binary operation Like &lt;a href="#model-OperatorElement"&gt;"DateIsInTheRange"&lt;a&gt;.
		/// </summary>
		public string SecondValue { get; set; }

		/// <summary>
		/// Represents the sub field name being used when the criteria is a field of Type "A", "C" or "M", the list of sub fields can be discovered through &lt;a href="#operations-Schemas-GetAvailableSchemas"&gt;schemas&lt;a&gt; endpoint.
		/// </summary>
		public string SubField { get; set; }
		#endregion
	}
}
