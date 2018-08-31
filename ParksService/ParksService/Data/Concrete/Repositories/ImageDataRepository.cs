using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
	public class ImageDataRepository : IImageDataRepository
	{
		private static readonly string Path = AppDomain.CurrentDomain.BaseDirectory;
		private static readonly string FilePath = Path + "ImageData.json";

		public IEnumerable<ImageData> Find(Func<ImageData, bool> predicate)
		{
			return GetAll().Where(predicate);
		}

		public IEnumerable<ImageData> GetAll()
		{
			var result = new List<ImageData>();
			using (var reader = new StreamReader(FilePath))
			{
				var json = reader.ReadToEnd();
				result = JsonConvert.DeserializeObject<IEnumerable<ImageData>>(json).ToList();
			}

			return result;
		}

		public void WriteData(IEnumerable<ImageData> data)
		{
			using (var file = File.CreateText(FilePath))
			{
				var serializer = new JsonSerializer();
				serializer.Serialize(file, data);
			}
		}
	}
}