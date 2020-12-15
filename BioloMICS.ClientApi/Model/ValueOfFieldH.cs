namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "H".
	/// </summary>
	public class ValueOfFieldH : ValueOfFieldBase
	{
		#region Properties

		public string Value { get; set; }


		#endregion

		public ValueOfFieldH()
		{
			FieldType = FieldTypeEnum.H;
		}
	}

}