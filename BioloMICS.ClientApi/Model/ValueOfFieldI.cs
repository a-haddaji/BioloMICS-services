namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "I".
	/// </summary>
	public class ValueOfFieldI : ValueOfFieldBase
	{
		#region Properties

		public long Value { get; set; }


		#endregion

		public ValueOfFieldI()
		{
			FieldType = FieldTypeEnum.I;
		}
	}
}