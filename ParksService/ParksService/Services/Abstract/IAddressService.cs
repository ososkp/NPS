using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
    public interface IAddressService
    {
	    IEnumerable<Address> GetAll();
	    IEnumerable<Address> GetAddressesByState(string state);
	    IEnumerable<Address> GetAddressesByPostalCode(string code);
	    void WriteAddresses(IEnumerable<Address> data);
    }
}
