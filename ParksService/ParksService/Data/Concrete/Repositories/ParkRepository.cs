using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
	public class ParkRepository : IParkRepository
	{
		private static readonly string Path = AppDomain.CurrentDomain.BaseDirectory;
		private static readonly string FilePath = Path + "parks.json";

		public IEnumerable<Park> Find(Func<Park, bool> predicate)
		{
			// This is used by the ParkService class, which feeds in the predicate
			return GetAll().Where(predicate);
		}

		public IEnumerable<Park> GetAll()
		{
			var result = new List<Park>();
			using (var reader = new StreamReader(FilePath))
			{
				var json = reader.ReadToEnd();
				result = JsonConvert.DeserializeObject<IEnumerable<Park>>(json).ToList();
			}

			return result;
		}

		public IEnumerable<Park> RepopulateParksList(IEnumerable<Park> data)
		{
			WriteParks(data);
			return GetAll();
		}

		public void WriteParks(IEnumerable<Park> data)
		{
			using (var file = File.CreateText(FilePath))
			{
				var serializer = new JsonSerializer();
				serializer.Serialize(file, data);
			}
		}
	}
}