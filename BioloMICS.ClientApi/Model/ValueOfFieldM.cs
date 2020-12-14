using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "M".
	/// </summary>
	public class ValueOfFieldM : ValueOfFieldBase
	{

		#region Properties
		/// <summary>
		/// Represents a list of key valye pair for the sub fields of the field type "M", available sub fields can be discovered through &lt;a href="#operations-Schemas-GetAvailableSchemas"&gt;schemas&lt;a&gt; endpoint.
		/// </summary>
		public List<MFieldEntity> Value { get; set; }


		#endregion

		public ValueOfFieldM()
		{
			FieldType = FieldTypeEnum.M;
		}
	}
}