// https://developer.nps.gov/api/v1/parks?api_key=5hCAzcru81QKEg1bDSyJz6KlMaFYTa3HTWmACBBs

using ParksService.Models;

namespace ParksService.ViewModels
{
	public class Park : IPark
	{
        public string Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Coordinates { get; set; }
        public string Designation { get; set; }

        // Back-end
        public string ParkCode { get; set; }
        public string Url { get; set; }
        public string DirectionsUrl { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }

		// Front-end
		public string Description { get; set; }
        public string Directions { get; set; }
        public string WeatherInfo { get; set; }
        public string FullName { get; set; }
    }
}