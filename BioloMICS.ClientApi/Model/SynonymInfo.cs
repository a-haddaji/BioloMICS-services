using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
	public class SynonymInfo
	{
		public SynonymyRecord SelectedRecord { get; set; }
		public SynonymyRecord CurrentNameRecord { get; set; }
		public List<SynonymyRecord> TaxonSynonymsRecords { get; set; } = new List<SynonymyRecord>();
		public SynonymyRecord BasionymRecord { get; set; }
		public List<SynonymyRecord> ObligateSynonymRecords { get; set; } = new List<SynonymyRecord>();
	}

}