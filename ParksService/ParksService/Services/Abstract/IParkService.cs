using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
	public interface IParkService
	{
		Park GetParkById(string id);
	}
}