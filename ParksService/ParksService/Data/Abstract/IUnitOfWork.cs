using ParksService.Data.Abstract.Repositories;

namespace ParksService.Data.Abstract
{
    public interface IUnitOfWork
    {
		IAddressRepository AddressRepository { get; }
		IParkRepository ParkRepository { get; }
    }
}
