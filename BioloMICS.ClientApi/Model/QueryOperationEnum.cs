using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BioloMICS.ClientApi.Model
{
    /// <summary>
    /// Defines QueryOperationEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum QueryOperationEnum
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,
        /// <summary>
        /// Enum ValueIs for value: ValueIs
        /// </summary>
        [EnumMember(Value = "ValueIs")]
        ValueIs = 2,
        /// <summary>
        /// Enum ValueIsNot for value: ValueIsNot
        /// </summary>
        [EnumMember(Value = "ValueIsNot")]
        ValueIsNot = 3,
        /// <summary>
        /// Enum ValueIsUndefined for value: ValueIsUndefined
        /// </summary>
        [EnumMember(Value = "ValueIsUndefined")]
        ValueIsUndefined = 4,
        /// <summary>
        /// Enum ValueIsDuplicated for value: ValueIsDuplicated
        /// </summary>
        [EnumMember(Value = "ValueIsDuplicated")]
        ValueIsDuplicated = 5,
        /// <summary>
        /// Enum TextStartWith for value: TextStartWith
        /// </summary>
        [EnumMember(Value = "TextStartWith")]
        TextStartWith = 6,
        /// <summary>
        /// Enum TextContains for value: TextContains
        /// </summary>
        [EnumMember(Value = "TextContains")]
        TextContains = 7,
        /// <summary>
        /// Enum TextExactMatch for value: TextExactMatch
        /// </summary>
        [EnumMember(Value = "TextExactMatch")]
        TextExactMatch = 8,
        /// <summary>
        /// Enum DateIsBefore for value: DateIsBefore
        /// </summary>
        [EnumMember(Value = "DateIsBefore")]
        DateIsBefore = 9,
        /// <summary>
        /// Enum DateIsAfter for value: DateIsAfter
        /// </summary>
        [EnumMember(Value = "DateIsAfter")]
        DateIsAfter = 10,
        /// <summary>
        /// Enum DateIsInTheRange for value: DateIsInTheRange
        /// </summary>
        [EnumMember(Value = "DateIsInTheRange")]
        DateIsInTheRange = 11,
        /// <summary>
        /// Enum DateIsUndefined for value: DateIsUndefined
        /// </summary>
        [EnumMember(Value = "DateIsUndefined")]
        DateIsUndefined = 12,
        /// <summary>
        /// Enum DateIsEqualTo for value: DateIsEqualTo
        /// </summary>
        [EnumMember(Value = "DateIsEqualTo")]
        DateIsEqualTo = 13,
        /// <summary>
        /// Enum DateYearIs for value: DateYearIs
        /// </summary>
        [EnumMember(Value = "DateYearIs")]
        DateYearIs = 14,
        /// <summary>
        /// Enum DateMonthIs for value: DateMonthIs
        /// </summary>
        [EnumMember(Value = "DateMonthIs")]
        DateMonthIs = 15,
        /// <summary>
        /// Enum DateDayOfMonthIs for value: DateDayOfMonthIs
        /// </summary>
        [EnumMember(Value = "DateDayOfMonthIs")]
        DateDayOfMonthIs = 16,
        /// <summary>
        /// Enum NbrIsGreaterThan for value: NbrIsGreaterThan
        /// </summary>
        [EnumMember(Value = "NbrIsGreaterThan")]
        NbrIsGreaterThan = 17,
        /// <summary>
        /// Enum NbrIsGreatThanOrEqualTo for value: NbrIsGreatThanOrEqualTo
        /// </summary>
        [EnumMember(Value = "NbrIsGreatThanOrEqualTo")]
        NbrIsGreatThanOrEqualTo = 18,
        /// <summary>
        /// Enum NbrIsEqualTo for value: NbrIsEqualTo
        /// </summary>
        [EnumMember(Value = "NbrIsEqualTo")]
        NbrIsEqualTo = 19,
        /// <summary>
        /// Enum NbrIsSmallerThan for value: NbrIsSmallerThan
        /// </summary>
        [EnumMember(Value = "NbrIsSmallerThan")]
        NbrIsSmallerThan = 20,
        /// <summary>
        /// Enum NbrIsSmallerThanOrEqualTo for value: NbrIsSmallerThanOrEqualTo
        /// </summary>
        [EnumMember(Value = "NbrIsSmallerThanOrEqualTo")]
        NbrIsSmallerThanOrEqualTo = 21,
        /// <summary>
        /// Enum NbrIsDifferentFrom for value: NbrIsDifferentFrom
        /// </summary>
        [EnumMember(Value = "NbrIsDifferentFrom")]
        NbrIsDifferentFrom = 22,
        /// <summary>
        /// Enum NbrIsInList for value: NbrIsInList
        /// </summary>
        [EnumMember(Value = "NbrIsInList")]
        NbrIsInList = 23,
        /// <summary>
        /// Enum ValueIsRoot for value: ValueIsRoot
        /// </summary>
        [EnumMember(Value = "ValueIsRoot")]
        ValueIsRoot = 24,
        /// <summary>
        /// Enum NameStartWithAndChild for value: NameStartWithAndChild
        /// </summary>
        [EnumMember(Value = "NameStartWithAndChild")]
        NameStartWithAndChild = 25,
        /// <summary>
        /// Enum NameContainsAndChild for value: NameContainsAndChild
        /// </summary>
        [EnumMember(Value = "NameContainsAndChild")]
        NameContainsAndChild = 26,
        /// <summary>
        /// Enum NameExactMatchAndChild for value: NameExactMatchAndChild
        /// </summary>
        [EnumMember(Value = "NameExactMatchAndChild")]
        NameExactMatchAndChild = 27,
        /// <summary>
        /// Enum ValueIsNearlyIdentical for value: ValueIsNearlyIdentical
        /// </summary>
        [EnumMember(Value = "ValueIsNearlyIdentical")]
        ValueIsNearlyIdentical = 28,
        /// <summary>
        /// Enum ValueIsVerySimilar for value: ValueIsVerySimilar
        /// </summary>
        [EnumMember(Value = "ValueIsVerySimilar")]
        ValueIsVerySimilar = 29,
        /// <summary>
        /// Enum ValueIsSimilar for value: ValueIsSimilar
        /// </summary>
        [EnumMember(Value = "ValueIsSimilar")]
        ValueIsSimilar = 30,
        /// <summary>
        /// Enum SFieldSmallerThanMin for value: SFieldSmallerThanMin
        /// </summary>
        [EnumMember(Value = "SFieldSmallerThanMin")]
        SFieldSmallerThanMin = 31,
        /// <summary>
        /// Enum SFieldSmallerThanLP for value: SFieldSmallerThanLP
        /// </summary>
        [EnumMember(Value = "SFieldSmallerThanLP")]
        SFieldSmallerThanLP = 32,
        /// <summary>
        /// Enum SFieldSmallerThanHP for value: SFieldSmallerThanHP
        /// </summary>
        [EnumMember(Value = "SFieldSmallerThanHP")]
        SFieldSmallerThanHP = 33,
        /// <summary>
        /// Enum SFieldSmallerThanMax for value: SFieldSmallerThanMax
        /// </summary>
        [EnumMember(Value = "SFieldSmallerThanMax")]
        SFieldSmallerThanMax = 34,
        /// <summary>
        /// Enum SFieldGreaterThanMin for value: SFieldGreaterThanMin
        /// </summary>
        [EnumMember(Value = "SFieldGreaterThanMin")]
        SFieldGreaterThanMin = 35,
        /// <summary>
        /// Enum SFieldGreaterThanLP for value: SFieldGreaterThanLP
        /// </summary>
        [EnumMember(Value = "SFieldGreaterThanLP")]
        SFieldGreaterThanLP = 36,
        /// <summary>
        /// Enum SFieldGreaterThanHP for value: SFieldGreaterThanHP
        /// </summary>
        [EnumMember(Value = "SFieldGreaterThanHP")]
        SFieldGreaterThanHP = 37,
        /// <summary>
        /// Enum SFieldGreaterThanMax for value: SFieldGreaterThanMax
        /// </summary>
        [EnumMember(Value = "SFieldGreaterThanMax")]
        SFieldGreaterThanMax = 38,
        /// <summary>
        /// Enum SFieldBetweenLPAndHP for value: SFieldBetweenLPAndHP
        /// </summary>
        [EnumMember(Value = "SFieldBetweenLPAndHP")]
        SFieldBetweenLPAndHP = 39,
        /// <summary>
        /// Enum SFieldBetweenMinAndMax for value: SFieldBetweenMinAndMax
        /// </summary>
        [EnumMember(Value = "SFieldBetweenMinAndMax")]
        SFieldBetweenMinAndMax = 40,
        /// <summary>
        /// Enum NameStartWith for value: NameStartWith
        /// </summary>
        [EnumMember(Value = "NameStartWith")]
        NameStartWith = 41,
        /// <summary>
        /// Enum NameContains for value: NameContains
        /// </summary>
        [EnumMember(Value = "NameContains")]
        NameContains = 42,
        /// <summary>
        /// Enum NameExactMatch for value: NameExactMatch
        /// </summary>
        [EnumMember(Value = "NameExactMatch")]
        NameExactMatch = 43,
        /// <summary>
        /// Enum NameIsUndefined for value: NameIsUndefined
        /// </summary>
        [EnumMember(Value = "NameIsUndefined")]
        NameIsUndefined = 44,
        /// <summary>
        /// Enum NameIsDuplicated for value: NameIsDuplicated
        /// </summary>
        [EnumMember(Value = "NameIsDuplicated")]
        NameIsDuplicated = 45,
        /// <summary>
        /// Enum TargetRecordNameStartWith for value: TargetRecordNameStartWith
        /// </summary>
        [EnumMember(Value = "TargetRecordNameStartWith")]
        TargetRecordNameStartWith = 46,
        /// <summary>
        /// Enum TargetRecordNameContains for value: TargetRecordNameContains
        /// </summary>
        [EnumMember(Value = "TargetRecordNameContains")]
        TargetRecordNameContains = 47,
        /// <summary>
        /// Enum TargetRecordNameExactMatch for value: TargetRecordNameExactMatch
        /// </summary>
        [EnumMember(Value = "TargetRecordNameExactMatch")]
        TargetRecordNameExactMatch = 48,
        /// <summary>
        /// Enum TargetRecordNameIsUndefined for value: TargetRecordNameIsUndefined
        /// </summary>
        [EnumMember(Value = "TargetRecordNameIsUndefined")]
        TargetRecordNameIsUndefined = 49,
        /// <summary>
        /// Enum TargetRecordAnyTextStartWith for value: TargetRecordAnyTextStartWith
        /// </summary>
        [EnumMember(Value = "TargetRecordAnyTextStartWith")]
        TargetRecordAnyTextStartWith = 50,
        /// <summary>
        /// Enum TargetRecordAnyTextContains for value: TargetRecordAnyTextContains
        /// </summary>
        [EnumMember(Value = "TargetRecordAnyTextContains")]
        TargetRecordAnyTextContains = 51,
        /// <summary>
        /// Enum TargetRecordAnyTextExactMatch for value: TargetRecordAnyTextExactMatch
        /// </summary>
        [EnumMember(Value = "TargetRecordAnyTextExactMatch")]
        TargetRecordAnyTextExactMatch = 52,
        /// <summary>
        /// Enum TargetRecordAnyTextIsUndefined for value: TargetRecordAnyTextIsUndefined
        /// </summary>
        [EnumMember(Value = "TargetRecordAnyTextIsUndefined")]
        TargetRecordAnyTextIsUndefined = 53,
        /// <summary>
        /// Enum LinkContains for value: LinkContains
        /// </summary>
        [EnumMember(Value = "LinkContains")]
        LinkContains = 54,
        /// <summary>
        /// Enum LinkIsEmpty for value: LinkIsEmpty
        /// </summary>
        [EnumMember(Value = "LinkIsEmpty")]
        LinkIsEmpty = 55,
        /// <summary>
        /// Enum LinkIsDuplicated for value: LinkIsDuplicated
        /// </summary>
        [EnumMember(Value = "LinkIsDuplicated")]
        LinkIsDuplicated = 56,
        /// <summary>
        /// Enum GroupCan for value: GroupCan
        /// </summary>
        [EnumMember(Value = "GroupCan")]
        GroupCan = 57,
        /// <summary>
        /// Enum GroupCannot for value: GroupCannot
        /// </summary>
        [EnumMember(Value = "GroupCannot")]
        GroupCannot = 58,
        /// <summary>
        /// Enum Locked for value: Locked
        /// </summary>
        [EnumMember(Value = "Locked")]
        Locked = 59,
        /// <summary>
        /// Enum Unlocked for value: Unlocked
        /// </summary>
        [EnumMember(Value = "Unlocked")]
        Unlocked = 60,
        /// <summary>
        /// Enum Used for value: Used
        /// </summary>
        [EnumMember(Value = "Used")]
        Used = 61,
        /// <summary>
        /// Enum Unused for value: Unused
        /// </summary>
        [EnumMember(Value = "Unused")]
        Unused = 62,
        /// <summary>
        /// Enum Exist for value: Exist
        /// </summary>
        [EnumMember(Value = "Exist")]
        Exist = 63,
        /// <summary>
        /// Enum DoesNotExist for value: DoesNotExist
        /// </summary>
        [EnumMember(Value = "DoesNotExist")]
        DoesNotExist = 64,
        /// <summary>
        /// Enum NameStartWithAndSynonyms for value: NameStartWithAndSynonyms
        /// </summary>
        [EnumMember(Value = "NameStartWithAndSynonyms")]
        NameStartWithAndSynonyms = 65,
        /// <summary>
        /// Enum NameContainsAndSynonyms for value: NameContainsAndSynonyms
        /// </summary>
        [EnumMember(Value = "NameContainsAndSynonyms")]
        NameContainsAndSynonyms = 66,
        /// <summary>
        /// Enum NameExactMatchAndSynonyms for value: NameExactMatchAndSynonyms
        /// </summary>
        [EnumMember(Value = "NameExactMatchAndSynonyms")]
        NameExactMatchAndSynonyms = 67,
        /// <summary>
        /// Enum UserNameStartWith for value: UserNameStartWith
        /// </summary>
        [EnumMember(Value = "UserNameStartWith")]
        UserNameStartWith = 68,
        /// <summary>
        /// Enum UserNameContains for value: UserNameContains
        /// </summary>
        [EnumMember(Value = "UserNameContains")]
        UserNameContains = 69,
        /// <summary>
        /// Enum UserNameExactMatch for value: UserNameExactMatch
        /// </summary>
        [EnumMember(Value = "UserNameExactMatch")]
        UserNameExactMatch = 70,
        /// <summary>
        /// Enum UserPropertyStartWith for value: UserPropertyStartWith
        /// </summary>
        [EnumMember(Value = "UserPropertyStartWith")]
        UserPropertyStartWith = 71,
        /// <summary>
        /// Enum UserPropertyContains for value: UserPropertyContains
        /// </summary>
        [EnumMember(Value = "UserPropertyContains")]
        UserPropertyContains = 72,
        /// <summary>
        /// Enum UserPropertyExactMatch for value: UserPropertyExactMatch
        /// </summary>
        [EnumMember(Value = "UserPropertyExactMatch")]
        UserPropertyExactMatch = 73,
        /// <summary>
        /// Enum UserContains for value: UserContains
        /// </summary>
        [EnumMember(Value = "UserContains")]
        UserContains = 74,
        /// <summary>
        /// Enum CurrentUser for value: CurrentUser
        /// </summary>
        [EnumMember(Value = "CurrentUser")]
        CurrentUser = 75,
        /// <summary>
        /// Enum UserNameOrEmailStartWith for value: UserNameOrEmailStartWith
        /// </summary>
        [EnumMember(Value = "UserNameOrEmailStartWith")]
        UserNameOrEmailStartWith = 76,
        /// <summary>
        /// Enum UserNameOrEmailContains for value: UserNameOrEmailContains
        /// </summary>
        [EnumMember(Value = "UserNameOrEmailContains")]
        UserNameOrEmailContains = 77,
        /// <summary>
        /// Enum UserNameOrEmailExactMatch for value: UserNameOrEmailExactMatch
        /// </summary>
        [EnumMember(Value = "UserNameOrEmailExactMatch")]
        UserNameOrEmailExactMatch = 78    }
}
