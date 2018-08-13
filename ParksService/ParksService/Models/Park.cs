// https://developer.nps.gov/api/v1/parks?api_key=5hCAzcru81QKEg1bDSyJz6KlMaFYTa3HTWmACBBs

namespace ParksService.Models
{
	public class Park{
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public long[] Coordinates { get; set; }
        public string Designation { get; set; }

        // Back-end
        public string ParkId { get; set; }
        public string ParkCode { get; set; }
        public string Url { get; set; }
        public string DirectionsUrl { get; set; }

        // Front-end
        public string Description { get; set; }
        public string Directions { get; set; }
        public string WeatherInfo { get; set; }
        public string FullName { get; set; }
    }
}