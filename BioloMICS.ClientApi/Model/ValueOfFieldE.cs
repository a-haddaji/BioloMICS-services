namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "E".
	/// </summary>
	public class ValueOfFieldE : ValueOfFieldBase
	{
		#region Properties

		public string Value { get; set; }

		#endregion

		public ValueOfFieldE()
		{
			FieldType = FieldTypeEnum.E;
		}
	}
}