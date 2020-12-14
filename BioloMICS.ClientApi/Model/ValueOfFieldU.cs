using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "U".
	/// </summary>
	public class ValueOfFieldU : ValueOfFieldBase
	{
		#region Properties
		public List<NameValueEntity> Value { get; set; }
		#endregion

		public ValueOfFieldU()
		{
			FieldType = FieldTypeEnum.U;
		}
	}

}