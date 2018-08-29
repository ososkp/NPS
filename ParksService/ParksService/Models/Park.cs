using System;
using System.Collections.Generic;

namespace ParksService.Models
{
	public class Park
	{
		public string States { get; set; }
		public string LatLong { get; set; }
		public string Description { get; set; }
		public string Designation { get; set; }
		public string ParkCode { get; set; }
		public Guid Id { get; set; }
		public string DirectionsInfo { get; set; }
		public string DirectionsUrl { get; set; }
		public string FullName { get; set; }
		public string Url { get; set; }
		public string WeatherInfo { get; set; }
		public string Name { get; set; }

		public List<Address> Addresses { get; set; }
	}
}