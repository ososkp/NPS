using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ParksService.Data.Abstract;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
    public class ParkService : ServiceBase, IParkService
    {
		public ParkService(IDataHandler dataHandler) : base(dataHandler)
		{
		}

	    public string ParseLatitude(string coordinates)
	    {
		    var index = coordinates.IndexOf(",", StringComparison.Ordinal);

		    var latitude = coordinates.Substring(4, index-4);

		    return latitude;
	    }

	    public string ParseLongitude(string coordinates)
	    {
		    var index = coordinates.IndexOf("g", StringComparison.Ordinal) + 1;
		    var longitude = coordinates.Substring(index + 1, coordinates.Length - index - 1);

		    return longitude;
	    }

	    

    }
}
