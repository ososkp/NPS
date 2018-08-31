using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
	public class ParkRepository : Repository<Park>, IParkRepository
	{
		public ParkRepository() : base("parks.json")
		{
		}
	}
}