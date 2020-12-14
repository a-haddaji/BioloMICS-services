using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
   /// <summary>
   /// Represents a value of type "O".
   /// </summary>
   public class ValueOfFieldO : ValueOfFieldRLink
   {
      public List<RecordValueEntity> ChildValue { get; set; } = new List<RecordValueEntity>();

      public ValueOfFieldO()
      {
         FieldType = FieldTypeEnum.O;
      }
   }
}
