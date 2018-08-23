using System;
using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
	public interface IParkService
	{
		Park GetParkById(Guid id);
		IEnumerable<Park> GetParksByFullState(string state);
		IEnumerable<Park> GetParksByState(string state);
	}
}