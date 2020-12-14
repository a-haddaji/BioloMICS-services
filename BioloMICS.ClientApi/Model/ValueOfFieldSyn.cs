namespace BioloMICS.ClientApi.Model
{
   /// <summary>
   /// Represents a value of type "Syn".
   /// </summary>
   public class ValueOfFieldSyn : ValueOfFieldBase
   {
      public int SynonymId { get; set; }

      public int ObligateSynonymId { get; set; }

      public string DesktopInfo { get; set; }

      public string DesktopInfoHtml { get; set; }

      public string OriginalSynFieldInfo { get; set; }

      public string NewSynFieldInfo { get; set; }

      public SynonymInfo SynInfo { get; set; }

      public ValueOfFieldSyn()
      {
         FieldType = FieldTypeEnum.Syn;
      }
   }
}
