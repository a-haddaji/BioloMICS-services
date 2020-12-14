namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "K".
	/// </summary>
	public class ValueOfFieldK : ValueOfFieldBase
	{
		#region Properties
		/// <summary>
		/// Represents the Rgb code for the a field of type "K".
		/// </summary>
		public string Rgb { get; set; }


		#endregion

		public ValueOfFieldK()
		{
			FieldType = FieldTypeEnum.K;
		}
	}

}