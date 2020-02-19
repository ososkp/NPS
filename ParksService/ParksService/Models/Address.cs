using System;

namespace ParksService.Models
{
    public class Address
    {
		public string Line1 { get; set; }
		public string Line2 { get; set; }
		public string Line3 { get; set; }
		public string City { get; set; }
		public string StateCode { get; set; }
		public string PostalCode { get; set; }
		public string Type { get; set; }
	}
}
