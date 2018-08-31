using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
	{
		public AddressRepository() : base("addresses.json")
		{
		}
	}
}
