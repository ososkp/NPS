using System;
using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
    public interface IAddressService
    {
//	    Address GetAddressById(Guid id);
	    IEnumerable<Address> GetAll();
	    IEnumerable<Address> GetAddressesByState(string state);
	    IEnumerable<Address> GetAddressesByPostalCode(string code);
    }
}
