using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
		/// <summary>
		/// Represents a value of type "A".
		/// </summary>
		public class ValueOfFieldA : ValueOfFieldBase
		{

			#region Properties
			/// <summary>
			/// Represents a key value pair list for sub fields. available sub fields can be discovered through &lt;a href="#operations-Schemas-GetAvailableSchemas"&gt;schemas&lt;a&gt; endpoint.
			/// </summary>
			public List<NameValueEntity> Value { get; set; }

			#endregion

			public ValueOfFieldA()
			{
				FieldType = FieldTypeEnum.A;
			}
		}

}