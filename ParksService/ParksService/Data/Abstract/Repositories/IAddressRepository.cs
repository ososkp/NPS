using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Data.Abstract.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
	    void WriteAddresses(IEnumerable<Address> data);
    }
}
