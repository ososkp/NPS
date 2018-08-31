using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
    public class WeeklyHoursRepository : Repository<WeeklyHours>, IWeeklyHoursRepository
    {
	    public WeeklyHoursRepository() : base("weeklyHours.json")
	    {
	    }
    }
}
