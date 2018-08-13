using Newtonsoft.Json;
using ParksService.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParksService.Services
{
	public class JsonReader
	{
		//private string filePath => @"c:\users\kikmunterm\source\repos\Parks\Parks\Service\parks.json";
		private HttpClient _httpClient => new HttpClient();

		public async Task<IEnumerable<Park>> GetParks()
		{
			var json =
				await _httpClient.GetAsync(
					"https://developer.nps.gov/api/v1/parks?api_key=5hCAzcru81QKEg1bDSyJz6KlMaFYTa3HTWmACBBs").Result.Content.ReadAsAsync<Park>();
			//using (var reader = new StreamReader(filePath))
			//{
			//	var json = reader.ReadToEnd();
			//	result = JsonConvert.DeserializeObject<IEnumerable<Park>>(json).ToList();
			//}

			return JsonConvert.DeserializeObject<IEnumerable<Park>>(json.ToString()).ToList();
		}
	}
}
