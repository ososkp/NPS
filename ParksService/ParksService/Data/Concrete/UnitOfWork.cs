using ParksService.Data.Abstract;
using ParksService.Data.Abstract.Repositories;
using ParksService.Data.Concrete.Repositories;

namespace ParksService.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
	    public IAddressRepository AddressRepository { get; }
	    public IParkRepository ParkRepository { get; }

	    public UnitOfWork()
		{
			AddressRepository = new AddressRepository();
			ParkRepository = new ParkRepository();
		}

    }
}
