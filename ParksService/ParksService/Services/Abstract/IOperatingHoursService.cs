using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
    public interface IOperatingHoursService
    {
	    IEnumerable<OperatingHours> GetAll();
	    void WriteData(IEnumerable<OperatingHours> data);
	}
}
