using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ParksService.Models;
using ParksService.Services.Abstract;
using ParksService.ViewModels;

namespace ParksService.Services
{
	public static class JsonHandler
    {
	    private static readonly string Path = AppDomain.CurrentDomain.BaseDirectory;
	    private static readonly string FilePath = Path + "parks.json";

	    public static string GetFilePath()
	    {
		    return FilePath;
	    }

		public static IEnumerable<ParkData> GetParks()
	    {
		    var result = new List<ParkData>();
		    using (var reader = new StreamReader(FilePath))
		    {
			    var json = reader.ReadToEnd();
			    result = JsonConvert.DeserializeObject<IEnumerable<ParkData>>(json).ToList();
		    }

		    return result;
		}

	    public static void WriteParksData(IEnumerable<ParkData> data)
	    {
			using (var file = File.CreateText(FilePath))
		    {
//			    string Json = JsonConvert.SerializeObject(data);
//			    Console.WriteLine(Json);
			    var serializer = new JsonSerializer();
			    serializer.Serialize(file, data);
		    }
	    }
	}
}
