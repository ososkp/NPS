using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
    public interface IWeeklyHoursService
    {
	    IEnumerable<WeeklyHours> GetAll();
	    void WriteData(IEnumerable<WeeklyHours> data);
	}
}
