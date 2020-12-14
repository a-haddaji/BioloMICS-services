using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "W".
	/// </summary>
	public class ValueOfFieldW : ValueOfFieldBase
	{

		#region Properties

		public List<Points> Value { get; set; }


		#endregion

		public ValueOfFieldW()
		{
			FieldType = FieldTypeEnum.W;
		}
	}

}