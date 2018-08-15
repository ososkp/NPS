namespace ParksService.Models
{
	public interface IPark
	{
		string Id { get; set; }
		string Name { get; set; }
		string State { get; set; }
		string Coordinates { get; set; }
		string Designation { get; set; }

		// Back-end
		string ParkCode { get; set; }
		string Url { get; set; }
		string DirectionsUrl { get; set; }
		string Latitude { get; set; }
		string Longitude { get; set; }

		// Front-end
		string Description { get; set; }
		string Directions { get; set; }
		string WeatherInfo { get; set; }
		string FullName { get; set; }
	}
}