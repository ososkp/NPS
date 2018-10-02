using ParksService.Data.Abstract.Repositories;
using ParksService.Models;
using Microsoft.AspNetCore.Hosting;

namespace ParksService.Data.Concrete.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(IHostingEnvironment env) : base(env, "/addresses.json")
        {
        }
    }
}
