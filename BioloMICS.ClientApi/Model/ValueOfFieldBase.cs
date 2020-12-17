using BioloMICS.ClientApi.Converters;
using Newtonsoft.Json;

namespace BioloMICS.ClientApi.Model
{
	[JsonConverter(typeof(ValueOfFieldConverter))]
	public abstract class ValueOfFieldBase
	{
		/// <summary>
		/// Represents the type of the value being used for a given field.
		/// </summary>
		public FieldTypeEnum FieldType { get; set; }
	}
}