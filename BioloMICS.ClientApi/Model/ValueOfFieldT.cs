namespace BioloMICS.ClientApi.Model
{
   /// <summary>
   /// Represents a value of type "T".
   /// </summary>
   public class ValueOfFieldT : ValueOfFieldBase
   {
      #region Properties

      public string Value { get; set; }

      #endregion

      public ValueOfFieldT()
      {
         FieldType = FieldTypeEnum.T;
      }
   }
}
