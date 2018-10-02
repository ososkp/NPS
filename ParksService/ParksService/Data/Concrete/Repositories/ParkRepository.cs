using ParksService.Data.Abstract.Repositories;
using ParksService.Models;
using Microsoft.AspNetCore.Hosting;

namespace ParksService.Data.Concrete.Repositories
{
    public class ParkRepository : Repository<Park>, IParkRepository
    {
        public ParkRepository(IHostingEnvironment env) : base(env, "/parks.json")
        {
        }
    }
}