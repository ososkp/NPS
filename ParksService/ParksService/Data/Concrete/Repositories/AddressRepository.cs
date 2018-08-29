using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
    public class AddressRepository : IAddressRepository
	{
	    private static readonly string Path = AppDomain.CurrentDomain.BaseDirectory;
	    private static readonly string FilePath = Path + "addresses.json";

		public IEnumerable<Address> Find(Func<Address, bool> predicate)
	    {
		    // This is used by the AddressService class, which feeds in the predicate
		    return GetAll().Where(predicate);
	    }

	    public IEnumerable<Address> GetAll()
	    {
		    var result = new List<Address>();
		    using (var reader = new StreamReader(FilePath))
		    {
			    var json = reader.ReadToEnd();
			    result = JsonConvert.DeserializeObject<IEnumerable<Address>>(json).ToList();
		    }

		    return result;
	    }

		public void WriteAddresses(IEnumerable<Address> data)
		{
			using (var file = File.CreateText(FilePath))
			{
				var serializer = new JsonSerializer();
				serializer.Serialize(file, data);
			}
		}
	}
}
