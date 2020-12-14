/* 
 * BioloMICS services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BioloMICS.ClientApi.Model
{
    /// <summary>
    /// Defines FieldTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldTypeEnum
    {
        /// <summary>
        /// Enum RecordName for value: RecordName
        /// </summary>
        [EnumMember(Value = "RecordName")]
        RecordName = 1,
        /// <summary>
        /// Enum RecordId for value: RecordId
        /// </summary>
        [EnumMember(Value = "RecordId")]
        RecordId = 2,
        /// <summary>
        /// Enum AnyTextField for value: AnyTextField
        /// </summary>
        [EnumMember(Value = "AnyTextField")]
        AnyTextField = 3,
        /// <summary>
        /// Enum CreationDate for value: CreationDate
        /// </summary>
        [EnumMember(Value = "CreationDate")]
        CreationDate = 4,
        /// <summary>
        /// Enum LastChangeDate for value: LastChangeDate
        /// </summary>
        [EnumMember(Value = "LastChangeDate")]
        LastChangeDate = 5,
        /// <summary>
        /// Enum Owner for value: Owner
        /// </summary>
        [EnumMember(Value = "Owner")]
        Owner = 6,
        /// <summary>
        /// Enum LastChangeUser for value: LastChangeUser
        /// </summary>
        [EnumMember(Value = "LastChangeUser")]
        LastChangeUser = 7,
        /// <summary>
        /// Enum Branch for value: Branch
        /// </summary>
        [EnumMember(Value = "Branch")]
        Branch = 8,
        /// <summary>
        /// Enum TabContainer for value: TabContainer
        /// </summary>
        [EnumMember(Value = "TabContainer")]
        TabContainer = 9,
        /// <summary>
        /// Enum TableContainer for value: TableContainer
        /// </summary>
        [EnumMember(Value = "TableContainer")]
        TableContainer = 10,
        /// <summary>
        /// Enum TileContainer for value: TileContainer
        /// </summary>
        [EnumMember(Value = "TileContainer")]
        TileContainer = 11,
        /// <summary>
        /// Enum LayoutContainer for value: LayoutContainer
        /// </summary>
        [EnumMember(Value = "LayoutContainer")]
        LayoutContainer = 12,
        /// <summary>
        /// Enum ColumnContainer for value: ColumnContainer
        /// </summary>
        [EnumMember(Value = "ColumnContainer")]
        ColumnContainer = 13,
        /// <summary>
        /// Enum StepperContainer for value: StepperContainer
        /// </summary>
        [EnumMember(Value = "StepperContainer")]
        StepperContainer = 14,
        /// <summary>
        /// Enum ExpansionPanelContainer for value: ExpansionPanelContainer
        /// </summary>
        [EnumMember(Value = "ExpansionPanelContainer")]
        ExpansionPanelContainer = 15,
        /// <summary>
        /// Enum CarouselContainer for value: CarouselContainer
        /// </summary>
        [EnumMember(Value = "CarouselContainer")]
        CarouselContainer = 16,
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 17,
        /// <summary>
        /// Enum A for value: A
        /// </summary>
        [EnumMember(Value = "A")]
        A = 18,
        /// <summary>
        /// Enum C for value: C
        /// </summary>
        [EnumMember(Value = "C")]
        C = 19,
        /// <summary>
        /// Enum D for value: D
        /// </summary>
        [EnumMember(Value = "D")]
        D = 20,
        /// <summary>
        /// Enum E for value: E
        /// </summary>
        [EnumMember(Value = "E")]
        E = 21,
        /// <summary>
        /// Enum F for value: F
        /// </summary>
        [EnumMember(Value = "F")]
        F = 22,
        /// <summary>
        /// Enum G for value: G
        /// </summary>
        [EnumMember(Value = "G")]
        G = 23,
        /// <summary>
        /// Enum H for value: H
        /// </summary>
        [EnumMember(Value = "H")]
        H = 24,
        /// <summary>
        /// Enum I for value: I
        /// </summary>
        [EnumMember(Value = "I")]
        I = 25,
        /// <summary>
        /// Enum K for value: K
        /// </summary>
        [EnumMember(Value = "K")]
        K = 26,
        /// <summary>
        /// Enum L for value: L
        /// </summary>
        [EnumMember(Value = "L")]
        L = 27,
        /// <summary>
        /// Enum M for value: M
        /// </summary>
        [EnumMember(Value = "M")]
        M = 28,
        /// <summary>
        /// Enum N for value: N
        /// </summary>
        [EnumMember(Value = "N")]
        N = 29,
        /// <summary>
        /// Enum O for value: O
        /// </summary>
        [EnumMember(Value = "O")]
        O = 30,
        /// <summary>
        /// Enum P for value: P
        /// </summary>
        [EnumMember(Value = "P")]
        P = 31,
        /// <summary>
        /// Enum S for value: S
        /// </summary>
        [EnumMember(Value = "S")]
        S = 32,
        /// <summary>
        /// Enum T for value: T
        /// </summary>
        [EnumMember(Value = "T")]
        T = 33,
        /// <summary>
        /// Enum U for value: U
        /// </summary>
        [EnumMember(Value = "U")]
        U = 34,
        /// <summary>
        /// Enum V for value: V
        /// </summary>
        [EnumMember(Value = "V")]
        V = 35,
        /// <summary>
        /// Enum W for value: W
        /// </summary>
        [EnumMember(Value = "W")]
        W = 36,
        /// <summary>
        /// Enum Y for value: Y
        /// </summary>
        [EnumMember(Value = "Y")]
        Y = 37,
        /// <summary>
        /// Enum Syn for value: Syn
        /// </summary>
        [EnumMember(Value = "Syn")]
        Syn = 38,
        /// <summary>
        /// Enum ALink for value: ALink
        /// </summary>
        [EnumMember(Value = "ALink")]
        ALink = 39,
        /// <summary>
        /// Enum CLink for value: CLink
        /// </summary>
        [EnumMember(Value = "CLink")]
        CLink = 40,
        /// <summary>
        /// Enum DLink for value: DLink
        /// </summary>
        [EnumMember(Value = "DLink")]
        DLink = 41,
        /// <summary>
        /// Enum ELink for value: ELink
        /// </summary>
        [EnumMember(Value = "ELink")]
        ELink = 42,
        /// <summary>
        /// Enum HLink for value: HLink
        /// </summary>
        [EnumMember(Value = "HLink")]
        HLink = 43,
        /// <summary>
        /// Enum ILink for value: ILink
        /// </summary>
        [EnumMember(Value = "ILink")]
        ILink = 44,
        /// <summary>
        /// Enum KLink for value: KLink
        /// </summary>
        [EnumMember(Value = "KLink")]
        KLink = 45,
        /// <summary>
        /// Enum MLink for value: MLink
        /// </summary>
        [EnumMember(Value = "MLink")]
        MLink = 46,
        /// <summary>
        /// Enum SLink for value: SLink
        /// </summary>
        [EnumMember(Value = "SLink")]
        SLink = 47,
        /// <summary>
        /// Enum TLink for value: TLink
        /// </summary>
        [EnumMember(Value = "TLink")]
        TLink = 48,
        /// <summary>
        /// Enum VLink for value: VLink
        /// </summary>
        [EnumMember(Value = "VLink")]
        VLink = 49,
        /// <summary>
        /// Enum FLink for value: FLink
        /// </summary>
        [EnumMember(Value = "FLink")]
        FLink = 50,
        /// <summary>
        /// Enum GLink for value: GLink
        /// </summary>
        [EnumMember(Value = "GLink")]
        GLink = 51,
        /// <summary>
        /// Enum OLink for value: OLink
        /// </summary>
        [EnumMember(Value = "OLink")]
        OLink = 52,
        /// <summary>
        /// Enum SynLink for value: SynLink
        /// </summary>
        [EnumMember(Value = "SynLink")]
        SynLink = 53,
        /// <summary>
        /// Enum LLink for value: LLink
        /// </summary>
        [EnumMember(Value = "LLink")]
        LLink = 54,
        /// <summary>
        /// Enum NLink for value: NLink
        /// </summary>
        [EnumMember(Value = "NLink")]
        NLink = 55,
        /// <summary>
        /// Enum WLink for value: WLink
        /// </summary>
        [EnumMember(Value = "WLink")]
        WLink = 56,
        /// <summary>
        /// Enum Dash for value: Dash
        /// </summary>
        [EnumMember(Value = "Dash")]
        Dash = 57,
        /// <summary>
        /// Enum RLink for value: RLink
        /// </summary>
        [EnumMember(Value = "RLink")]
        RLink = 58,
        /// <summary>
        /// Enum CaptchaField for value: CaptchaField
        /// </summary>
        [EnumMember(Value = "CaptchaField")]
        CaptchaField = 59    }
}
