namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "L".
	/// </summary>
	public class ValueOfFieldL : ValueOfFieldBase
	{
		#region Properties
		/// <summary>
		/// Represents a geographic position for the field of type "L".
		/// </summary>
		public MapInfoEntity Value { get; set; }


		#endregion

		public ValueOfFieldL()
		{
			FieldType = FieldTypeEnum.L;
		}
	}
}