using BioloMICS.ClientApi.Attributes;
using BioloMICS.ClientApi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BioloMICS.ClientApi.Tests.Model
{
	[TableView("WS Mirri")]
	class StrainsModel : EntityBase
	{
		[JsonProperty("Collection accession number")]
		public string CollectionAccessionNumber { get; set; }
		[JsonProperty("Other culture collection numbers")]
		public string OtherCultureCollectionNumbers { get; set; }

		[JsonProperty("Organism type")]
		public OrganismType OrganismType { get; set; }

		[JsonProperty("Taxon name")]
		public List<TaxonName> TaxonName { get; set; }
	}

	class OrganismType
	{
		[JsonProperty("Algae")]
		public string Algae { get; set; }

		[JsonProperty("Filamentous Fungi")]
		public string Fungi { get; set; }

		[JsonProperty("Bacteria")]
		public string Bacteria { get; set; }

		[JsonProperty("Yeast")]
		public string Yeast { get; set; }
	}


	class TaxonName
	{

		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("Name")]
		public string Name { get; set; }

		[JsonProperty("Synonymy")]
		public string Synonymy { get; set; }
	}
}