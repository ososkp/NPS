namespace ParksService.Models
{
	 public interface IParkData
	{
		 string States { get; set; }
		 string LatLong { get; set; }
		 string Description { get; set; }
		 string Designation { get; set; }
		 string ParkCode { get; set; }
		 string Id { get; set; }
		 string DirectionsInfo { get; set; }
		 string DirectionsUrl { get; set; }
		 string FullName { get; set; }
		 string Url { get; set; }
		 string WeatherInfo { get; set; }
		 string Name { get; set; }
	}
}