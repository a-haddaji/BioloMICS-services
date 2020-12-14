using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BioloMICS.ClientApi.Model
{
    /// <summary>
    /// Defines QuerySubFieldCategoryEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum QuerySubFieldCategoryEnum
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,
        /// <summary>
        /// Enum ASubfield for value: ASubfield
        /// </summary>
        [EnumMember(Value = "ASubfield")]
        ASubfield = 2,
        /// <summary>
        /// Enum CSubfield for value: CSubfield
        /// </summary>
        [EnumMember(Value = "CSubfield")]
        CSubfield = 3,
        /// <summary>
        /// Enum MSubfield for value: MSubfield
        /// </summary>
        [EnumMember(Value = "MSubfield")]
        MSubfield = 4,
        /// <summary>
        /// Enum WFieldName for value: WFieldName
        /// </summary>
        [EnumMember(Value = "WFieldName")]
        WFieldName = 5,
        /// <summary>
        /// Enum WFieldValue for value: WFieldValue
        /// </summary>
        [EnumMember(Value = "WFieldValue")]
        WFieldValue = 6,
        /// <summary>
        /// Enum WFieldPeaks for value: WFieldPeaks
        /// </summary>
        [EnumMember(Value = "WFieldPeaks")]
        WFieldPeaks = 7,
        /// <summary>
        /// Enum Groups for value: Groups
        /// </summary>
        [EnumMember(Value = "Groups")]
        Groups = 8,
        /// <summary>
        /// Enum SynRecord for value: SynRecord
        /// </summary>
        [EnumMember(Value = "SynRecord")]
        SynRecord = 9,
        /// <summary>
        /// Enum SynNameField for value: SynNameField
        /// </summary>
        [EnumMember(Value = "SynNameField")]
        SynNameField = 10,
        /// <summary>
        /// Enum SynAssociatedMorph for value: SynAssociatedMorph
        /// </summary>
        [EnumMember(Value = "SynAssociatedMorph")]
        SynAssociatedMorph = 11,
        /// <summary>
        /// Enum SynFacultativeSynonym for value: SynFacultativeSynonym
        /// </summary>
        [EnumMember(Value = "SynFacultativeSynonym")]
        SynFacultativeSynonym = 12,
        /// <summary>
        /// Enum SynLocationField for value: SynLocationField
        /// </summary>
        [EnumMember(Value = "SynLocationField")]
        SynLocationField = 13,
        /// <summary>
        /// Enum SynObligateSynonym for value: SynObligateSynonym
        /// </summary>
        [EnumMember(Value = "SynObligateSynonym")]
        SynObligateSynonym = 14,
        /// <summary>
        /// Enum SynClassification for value: SynClassification
        /// </summary>
        [EnumMember(Value = "SynClassification")]
        SynClassification = 15,
        /// <summary>
        /// Enum SynAllSynonyms for value: SynAllSynonyms
        /// </summary>
        [EnumMember(Value = "SynAllSynonyms")]
        SynAllSynonyms = 16,
        /// <summary>
        /// Enum SynDescription for value: SynDescription
        /// </summary>
        [EnumMember(Value = "SynDescription")]
        SynDescription = 17,
        /// <summary>
        /// Enum SynStatus for value: SynStatus
        /// </summary>
        [EnumMember(Value = "SynStatus")]
        SynStatus = 18,
        /// <summary>
        /// Enum SynFile for value: SynFile
        /// </summary>
        [EnumMember(Value = "SynFile")]
        SynFile = 19    }
}
