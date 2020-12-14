namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "N".
	/// </summary>
	public class ValueOfFieldN : ValueOfFieldBase
	{
		#region Properties
		/// <summary>
		/// Represents the sequence value for the field of type "N".
		/// </summary>
		public SequenceStatsEntity Value { get; set; }


		#endregion

		public ValueOfFieldN()
		{
			FieldType = FieldTypeEnum.N;
		}
	}
}