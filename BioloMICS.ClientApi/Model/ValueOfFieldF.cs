namespace BioloMICS.ClientApi.Model
{
	/// <summary>
	/// Represents a value of type "F".
	/// </summary>
	public class ValueOfFieldF : ValueOfFieldBase
	{

		#region Properties
		/// <summary>
		/// Represents a file metadata for the value of type "F".
		/// </summary>
		public FileInfoEntity Value { get; set; }


		#endregion

		public ValueOfFieldF()
		{
			FieldType = FieldTypeEnum.F;
		}
	}
}