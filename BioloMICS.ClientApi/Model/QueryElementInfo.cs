using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BioloMICS.ClientApi.Model
{
   public class QueryElementInfo
   {
      [JsonConverter(typeof(StringEnumConverter))]
      public FieldTypeEnum FieldType { get; set; }
      [JsonProperty("title")]
      public string Title { get; set; }
      [JsonProperty("fieldKey")]
      public string FieldKey { get; set; }

      public List<OperatorInfo> AvailableOperations { get; set; }

      public IEnumerable<OperatorElement> Operations { get; set; }
      public IEnumerable<StateElement> States { get; set; }
   }
}
