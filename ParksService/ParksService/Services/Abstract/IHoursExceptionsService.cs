using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
    public interface IHoursExceptionsService
    {
	    IEnumerable<HoursExceptions> GetAll();
	    void WriteData(IEnumerable<HoursExceptions> data);
	}
}
