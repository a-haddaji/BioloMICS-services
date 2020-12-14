
namespace BioloMICS.ClientApi.Model
{
	public class MapInfoEntity
	{

		#region Properties

		public double Latitude { get; set; }

		public double Longitude { get; set; }

		public string CountryCode { get; set; }

		public string CountryName { get; set; }

		public string Name { get; set; }

		public string WebUrl { get; set; }

		public int CountryId { get; set; }

		public double Altitude { get; set; }

		public double Precision { get; set; }

		#endregion
	}
}