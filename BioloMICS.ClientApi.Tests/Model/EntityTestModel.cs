using BioloMICS.ClientApi.Attributes;
using BioloMICS.ClientApi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BioloMICS.ClientApi.Tests.Model
{
	[TableView("Strains")]
	class StrainsModel : EntityBase
	{
		[JsonProperty("Yeasts physiological data")]
		public YeastsPhysiologicalData YeastsPhysiologicalData { get; set; }
	}

	class YeastsPhysiologicalData
	{
		[JsonProperty("C1 D-Glucose")]
		public string C1 { get; set; }
		[JsonProperty("C2 D-Galactose")]
		public string C2 { get; set; }
		[JsonProperty("C3 L-Sorbose")]
		public string C3 { get; set; }
	}
}
