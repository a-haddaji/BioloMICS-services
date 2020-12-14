using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BioloMICS.ClientApi.Model
{
   public class OperatorInfo
   {
      [JsonConverter(typeof(StringEnumConverter))]
      public QueryOperationEnum OperationCode { get; set; }
      public string OperationName { get; set; }
      public List<QuerySubFieldCategoryEnum> SubFieldCategories { get; set; }
   }
}
