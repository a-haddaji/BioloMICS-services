using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BioloMICS.ClientApi.Model
{
    /// <summary>
    /// Defines NFieldSubtypeEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum NFieldSubtypeEnum
    {
        /// <summary>
        /// Enum Dna for value: Dna
        /// </summary>
        [EnumMember(Value = "Dna")]
        Dna = 1,
        /// <summary>
        /// Enum Protein for value: Protein
        /// </summary>
        [EnumMember(Value = "Protein")]
        Protein = 2,
        /// <summary>
        /// Enum Rna for value: Rna
        /// </summary>
        [EnumMember(Value = "Rna")]
        Rna = 3    
   }
}
