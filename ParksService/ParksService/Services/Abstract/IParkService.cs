using System;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
	public interface IParkService
	{
		Park GetParkById(Guid id);
	}
}