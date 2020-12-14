using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
   public class OperatorElement
   {
      public QueryOperationEnum OperationCode { get; set; }
      public string OperationName { get; set; }
      public string OperationUserName { get; set; }
      public bool IsUsed { get; set; }
      public List<QuerySubFieldCategoryEnum> SubFieldCategories { get; set; }
   }
}
