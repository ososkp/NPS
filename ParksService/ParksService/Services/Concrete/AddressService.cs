using System.Collections.Generic;
using ParksService.Data.Abstract;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
	public class AddressService : ServiceBase, IAddressService
	{
		public AddressService(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		public IEnumerable<Address> GetAll()
		{
			return _unitOfWork.AddressRepository.GetAll();
		}

	    public IEnumerable<Address> GetAddressesByState(string state)
	    {
			return _unitOfWork.AddressRepository.Find(a => a.StateCode == state);
		}

	    public IEnumerable<Address> GetAddressesByPostalCode(string code)
	    {
			return _unitOfWork.AddressRepository.Find(a => a.PostalCode == code);
		}

		public void WriteAddresses(IEnumerable<Address> data)
		{
			_unitOfWork.AddressRepository.WriteAddresses(data);
		}

	}
}
