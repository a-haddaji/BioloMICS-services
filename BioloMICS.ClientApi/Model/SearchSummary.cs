using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
   public class SearchSummary
   {
      public int TotalCount { get; set; }
      public IEnumerable<Dictionary<string, object>> Records { get; set; }
   }
}
