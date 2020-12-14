namespace BioloMICS.ClientApi.Model
{
   public class RecordValueEntity
   {
      public ValueOfFieldE Name { get; set; } = new ValueOfFieldE();
      public int RecordId { get; set; }
      public ValueOfFieldBase TargetFieldValue { get; set; }
   }
}
