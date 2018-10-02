using ParksService.Data.Abstract.Repositories;
using ParksService.Models;
using Microsoft.AspNetCore.Hosting;

namespace ParksService.Data.Concrete.Repositories
{
    public class OperatingHoursRepository : Repository<OperatingHours>, IOperatingHoursRepository
    {
        public OperatingHoursRepository(IHostingEnvironment env) : base(env, "/operatingHours.json")
        {
        }
    }
}
