using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BioloMICS.ClientApi.Model
{
	public class SearchInputModel
	{
		/// <summary>
		/// Represents a complex query containing a list of conditions.
		/// </summary>
		public List<ConditionEntity> Query { get; set; }
		/// <summary>
		/// Expression is the logic combination of query conditions included in the Query property, each condition is referenced with Q{Index}.
		/// Available logic operations are And, Or, AndNot, OrNot. (Parentheses are optional)
		/// Example: Not (Q0 And Q1) OrNot (Q2 And Q3).
		/// </summary>
		[RegularExpression(@"^(\s*\(\s*)*\s*(Not(\s+|(\s*\(\s*)+))*Q\d+(\s*\)\s*)*((\s+|(\s*\(\s*)+)(And|Or|AndNot|OrNot)\s+(\s*\(\s*)*Q\d+(\s*\)\s*)*)*\s*$")]
		public string Expression { get; set; }
		/// <summary>
		/// The index of the first record in the search result.
		/// </summary>
		[Required]
		[Range(0, int.MaxValue, ErrorMessage = "Display start must be greater than 0.")]
		public int DisplayStart { get; set; }
		/// <summary>
		/// The index of the last record in the search result. 
		/// </summary>
		[Required]
		[Range(1, 100, ErrorMessage = "Display lenght must be in range [1..100].")]
		public int DisplayLength { get; set; }
	}
}