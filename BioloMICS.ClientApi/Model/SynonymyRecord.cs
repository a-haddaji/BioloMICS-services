using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
	public class SynonymyRecord
	{
		public int RecordId { get; set; }
		public string RecordName { get; set; }
		public string NameInfo { get; set; }
		public List<SynonymyRecord> SecondLevelRecords { get; set; }
	}

}