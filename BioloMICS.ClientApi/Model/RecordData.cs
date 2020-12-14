using System.Collections.Generic;
using Newtonsoft.Json;

namespace BioloMICS.ClientApi.Model
{
   /// <summary>
	/// Represents a record in a table view, the record structure will depend on the schema of a table view, all table views can be discovered through schema endpoint.
	/// </summary>
	public class RecordData
   {
      //public int RecordId { get; set; }
      /// <summary>
      /// The record name.
      /// </summary>
      public string RecordName { get; set; }

      /// <summary>
      /// Represents a dictionnaty of key value pairs containing all the field values for a given record where the key identifies a field in the table view, all table views can be discovered through schema endpoint.
      /// </summary>
      [JsonProperty("RecordDetails")]
      public Dictionary<string, ValueOfFieldBase> Data;
   }
}
