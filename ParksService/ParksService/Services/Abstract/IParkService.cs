using System.Collections.Generic;

namespace ParksService.Services.Abstract
{
	public interface IParkService
	{
		string ParseLatitude(string coordinates);
		string ParseLongitude(string coordinates);
	}
}