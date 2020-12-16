using Newtonsoft.Json;

namespace BioloMICS.ClientApi.Client.Authentication
{
	public class OAuthReponse
	{
		[JsonProperty("access_token")]
		public string BearerToken { get; set; }
		[JsonProperty("refresh_token")]
		public string RefreshToken { get; set; }
		[JsonProperty("expires_in")]
		public int ExpiresIn { get; set; }
		[JsonProperty("token_type")]
		public string TokenType { get; set; }
		[JsonProperty("scope")]
		public string Scope { get; set; }
	}
}
