// https://developer.nps.gov/api/v1/parks?api_key=5hCAzcru81QKEg1bDSyJz6KlMaFYTa3HTWmACBBs

using System;
using ParksService.ViewModels;

namespace ParksService.ViewModels
{
	public class ParkViewModel
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string States { get; set; }
        public string LatLong { get; set; }
        public string Designation { get; set; }

        // Back-end
        public string ParkCode { get; set; }
        public string Url { get; set; }
        public string DirectionsUrl { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }

		// Front-end
		public string Description { get; set; }
        public string DirectionsInfo { get; set; }
        public string WeatherInfo { get; set; }
        public string FullName { get; set; }
		public string FullState { get; set; }
    }
}