using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BioloMICS.ClientApi.Model
{
   /// <summary>
	/// Represents a record in a table view, the record structure will depend on the schema of a table view, all table views can be discovered through schema endpoint.
	/// </summary>
	public class Record : RecordData
   {
      /// <summary>
      /// The record identity number.
      /// </summary>
      [Required]
      public int RecordId { get; set; }
   }
}
