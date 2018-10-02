using ParksService.Data.Abstract.Repositories;
using ParksService.Models;
using Microsoft.AspNetCore.Hosting;

namespace ParksService.Data.Concrete.Repositories
{
    public class WeeklyHoursRepository : Repository<WeeklyHours>, IWeeklyHoursRepository
    {
        public WeeklyHoursRepository(IHostingEnvironment env) : base(env, "/weeklyHours.json")
        {
        }
    }
}
