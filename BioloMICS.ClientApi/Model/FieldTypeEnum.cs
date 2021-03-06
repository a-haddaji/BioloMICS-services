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
		RecordName = -100,
		RecordId = -101,
		AnyTextField = -102,
		CreationDate = -103,
		LastChangeDate = -104,
		Owner = -105,
		LastChangeUser = -106,

		/// <summary>
		/// Unknown field Type if it is not from BioloMICS types.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Field A : vector of int values: +, -, d, w, ...
		/// </summary>
		A = 1, // vector of int values: +, -, d, w, ...

		//B = 2
		/// <summary>
		/// The C field: 1 int value: variable - yes - no
		/// </summary>
		C = 3, // 1 int value: variable - yes - no

		/// <summary>
		/// The D Field :1 double value
		/// </summary>
		D = 4, // 1 double value

		/// <summary>
		/// The E Field: string
		/// </summary>
		E = 5, // string

		/// <summary>
		/// The File Field : File. WARNING: in this case a single FieldDef generates TWO columns. See ColumnName() and ColumnNameForFileName()
		/// </summary>
		F = 6, // File. WARNING: in this case a single FieldDef generates TWO columns. See ColumnName() and ColumnNameForFileName()

		/// <summary>
		/// The GField :Gel, vector of double
		/// </summary>
		G = 7, // Gel, vector of double

		/// <summary>
		/// The H Field: H for history: a Date in format YYYYMMDDHHmmss saved in an int64
		/// </summary>
		H = 8, // H for history: a Date in format YYYYMMDDHHmmss saved in an int64

		/// <summary>
		/// The I Field: integer 64 bits
		/// </summary>
		I = 9, // integer 64 bits

		//J = 10
		/// <summary>
		/// The k Field : Color
		/// </summary>
		K = 11, // Color

		/// <summary>
		/// The L Field: Location: m_Latitude, m_Longitude, m_Precision
		/// </summary>
		L = 12, // Location: m_Latitude, m_Longitude, m_Precision

		/// <summary>
		/// The M Field: 	Vector of TSField
		/// </summary>
		M = 13, // Vector of TSField

		/// <summary>
		/// The N field : Sequence, DNA or Protein
		/// </summary>
		N = 14, // Sequence, DNA or Protein

		/// <summary>
		/// The O Field: Ontology, string like "2.5.3.24.36"
		/// </summary>
		O = 15, // Ontology, string like "2.5.3.24.36"

		/// <summary>
		/// The P Field : temporary object used during upgrade, URL, File, Picture or Gel
		/// </summary>
		P = 16, // temporary object used during upgrade, URL, File, Picture or Gel

		//Q = 17
		//R = 18
		/// <summary>
		/// The S Field : 4 double values: m_Min, m_LP, m_HP, m_Max
		/// </summary>
		S = 19, // 4 double values: m_Min, m_LP, m_HP, m_Max

		/// <summary>
		/// The T Field :1 int value: A, B, C, D and all possible combinations
		/// </summary>
		T = 20, // 1 int value: A, B, C, D and all possible combinations

		/// <summary>
		/// The U Field : vector of URL strings
		/// </summary>
		U = 21, // vector of URL strings

		/// <summary>
		/// The V Field: same as TField, but with unlimited number of states
		/// </summary>
		V = 22, // same as TField, but with unlimited number of states

		/// <summary>
		/// The W Field: Wave: Name + vector of points
		/// </summary>
		W = 23, // Wave: Name + vector of points

		//X = 24
		/// <summary>
		/// The Y Field: a "Yield" field = summary of other records in html
		/// </summary>
		Y = 25, // a "Yield" field = summary of other records in html

		//Z = 26
		/// <summary>
		/// The Syn Field: synonymy with two values: the current name ID and the obligate synonym ID
		/// </summary>
		Syn = 27, // Synonymy with two values: the current name ID and the obligate synonym ID

		//	Field links, keep them >= 70 and < 116. See TFieldDef.IsLinkField()

		//	I leave holes here in case we want to upgrade all scenarios and TFieldDef with new consecutive values in the future
		ALink = 70,
		CLink = 72,
		DLink = 73,
		ELink = 74,
		HLink = 77,
		ILink = 78,
		KLink = 80,
		MLink = 82,
		SLink = 88,
		TLink = 90,
		VLink = 92,

		/// <summary>
		/// The file link Field
		/// </summary>
		FLink = 106,

		/// <summary>
		/// The G link Field
		/// </summary>
		GLink = 107,

		/// <summary>
		/// The O link Field
		/// </summary>
		OLink = 108,

		/// <summary>
		/// The syn link : LinkField to a Synonymy field 
		/// </summary>
		SynLink = 109, // LinkField to a Syn field

		/// <summary>
		/// The L link Field
		/// </summary>
		LLink = 112,

		/// <summary>
		/// The N link Field
		/// </summary>
		NLink = 114,

		/// <summary>
		/// The W link Field
		/// </summary>
		WLink = 115,

		//	Record links, keep them >= 116. See TFieldDef.IsRecLink()
		/// <summary>
		/// The dash
		/// </summary>
		Dash = 116, // Dashboard field, added by OC:2-7-2015, to be set as RLink

		/// <summary>
		/// The R link field
		/// </summary>
		RLink = 118, // RecLinkField, keep them >= 118, or modify function IsRecLinkField()
		CaptchaField = 207,
	}
}
