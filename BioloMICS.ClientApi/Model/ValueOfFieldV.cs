namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "V".
	/// </summary>
	public class ValueOfFieldV : ValueOfFieldBase
	{

		#region Properties

		public string Value { get; set; }


		#endregion

		public ValueOfFieldV()
		{
			FieldType = FieldTypeEnum.V;
		}
	}
}
