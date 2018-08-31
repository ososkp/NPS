using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
    public class HoursExceptionsRepository : Repository<HoursExceptions>, IHoursExceptionsRepository
    {
	    public HoursExceptionsRepository() : base("hoursExceptions.json")
	    {
	    }
    }
}
