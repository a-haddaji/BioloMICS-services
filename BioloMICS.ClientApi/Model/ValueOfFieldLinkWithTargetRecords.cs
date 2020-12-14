using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
   public class ValueOfFieldLinkWithTargetRecords : ValueOfFieldBase
   {
      public List<RecordValueEntity> Value { get; set; } = new List<RecordValueEntity>();

      public ValueOfFieldLinkWithTargetRecords(FieldTypeEnum p_FieldType)
      {
         FieldType = p_FieldType;
      }
   }
}
