using BioloMICS.ClientApi.Attributes;
using Newtonsoft.Json;
using System;

namespace BioloMICS.ClientApi.Model
{
	public abstract class EntityBase
	{
		[JsonProperty("Record Id")]
		public int Id { get; set; }
		[JsonProperty("Accession number")]
		public string Name { get; set; }
		[JsonProperty("Creator user name")]
		public string OwnerEmail { get; set; }
		[JsonProperty("Creation date")]
		public DateTime CreationDate { get; set; }
		[JsonProperty("Last change date")]
		public DateTime LastChangeDate { get; set; }
		[JsonProperty("Last change user name")]
		public string LastChangeUserEmail { get; set; }
	}
}
