namespace BioloMICS.ClientApi.Model
{
		/// <summary>
		/// Represents a value of type "D".
		/// </summary>
		public class ValueOfFieldD : ValueOfFieldBase
		{

			#region Properties

			public double Value { get; set; }

			#endregion

			public ValueOfFieldD()
			{
				FieldType = FieldTypeEnum.D;
			}
	}

}