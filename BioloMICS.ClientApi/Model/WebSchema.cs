using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
	public class WebSchema
	{
		public int WebsiteId { get; set; }
		public string WebsiteName { get; set; }
		public string WebsiteUrl { get; set; }

		public List<WebViewInfo> TableViews { get; set; }
	}
}
