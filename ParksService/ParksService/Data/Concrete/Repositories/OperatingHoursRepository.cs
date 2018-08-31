using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
    public class OperatingHoursRepository : Repository<OperatingHours>, IOperatingHoursRepository
    {
	    public OperatingHoursRepository() : base("operatingHours.json")
	    {
	    }
    }
}
