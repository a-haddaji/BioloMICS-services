namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "S".
	/// </summary>
	public class ValueOfFieldS : ValueOfFieldBase
	{
		public ValueOfFieldS()
		{
			FieldType = FieldTypeEnum.S;
		}


		#region Properties
		public double MaxValue { get; set; }

		public double MinValue { get; set; }

		#endregion

	}
}