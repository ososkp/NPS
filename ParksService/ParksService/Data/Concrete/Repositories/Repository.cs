using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ParksService.Helpers;

namespace ParksService.Data.Concrete.Repositories
{
    public abstract class Repository<T>
    {
	    private readonly string Path = AppDomain.CurrentDomain.BaseDirectory;
	    protected readonly string FilePath;

		protected Repository(string fileName)
		{
			FilePath = Path + fileName;
		}

		public IEnumerable<T> Find(Func<T, bool> predicate)
	    {
		    return GetAll().Where(predicate);
	    }

	    public IEnumerable<T> GetAll()
	    {
		    var result = new List<T>();
		    using (var reader = new StreamReader(FilePath))
		    {
			    var json = reader.ReadToEnd();

				result = json.IsNullOrEmpty() ?
					new List<T>()
					: JsonConvert.DeserializeObject<IEnumerable<T>>(json).ToList();

//				result = JsonConvert.DeserializeObject<IEnumerable<T>>(json).ToList();
		    }

		    return result;
	    }

	    public void WriteData(IEnumerable<T> data)
	    {
		    using (var file = File.CreateText(FilePath))
		    {
			    var serializer = new JsonSerializer();
			    serializer.Serialize(file, data);
		    }
	    }

	    public string GetFilePath()
	    {
		    return FilePath;
	    }
	}
}
