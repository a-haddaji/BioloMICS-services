using System;

namespace BioloMICS.ClientApi.Model
{
	public class UserModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime CreationDate { get; set; }
		public string Email { get; set; }
		public string StreetAndNumber { get; set; }
		public string Zip { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string StateCode { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string Mobile { get; set; }
		public string Title { get; set; }
		public string Website { get; set; }
		public string VatNumber { get; set; }
		public string Remarks { get; set; }
		public string Institution { get; set; }
		public string Department { get; set; }
		public DateTime LastUseDate { get; set; }
		public string DeliveryName { get; set; }
		public string DeliveryInstitution { get; set; }
		public string DeliveryDepartment { get; set; }
		public string DeliveryStreetAndNumber { get; set; }
		public string DeliveryZip { get; set; }
		public string DeliveryCity { get; set; }
		public string DeliveryState { get; set; }
		public string DeliveryStateCode { get; set; }
		public string DeliveryCountry { get; set; }
		public string DeliveryPhone { get; set; }
		public string DeliveryFax { get; set; }
		public string DeliveryMobile { get; set; }
		public bool AcceptNewsLetters { get; set; }
	}
}
