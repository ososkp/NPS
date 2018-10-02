using Microsoft.AspNetCore.Hosting;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
    public class EntranceFeeRepository : Repository<EntranceFee>, IEntranceFeeRepository
    {
        public EntranceFeeRepository(IHostingEnvironment env) : base(env, "/entranceFees.json")
        {
        }
    }
}
