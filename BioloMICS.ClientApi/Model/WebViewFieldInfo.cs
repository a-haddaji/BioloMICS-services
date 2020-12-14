using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BioloMICS.ClientApi.Model
{
   public class WebViewFieldInfo
   {
      [JsonConverter(typeof(StringEnumConverter))]
      public FieldTypeEnum FieldType { get; set; }
      [JsonProperty("title")]
      public string Title { get; set; }

      [JsonProperty("fieldKey")]
      public string FieldKey { get; set; }
   }
}
