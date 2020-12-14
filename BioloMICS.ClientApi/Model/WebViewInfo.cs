using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
	public class WebViewInfo
	{
		public string TableViewName { get; set; }
		public List<QueryElementInfo> QueryableFields { get; set; }
		public List<WebViewFieldInfo> ResultFields { get; set; }
	}
}
