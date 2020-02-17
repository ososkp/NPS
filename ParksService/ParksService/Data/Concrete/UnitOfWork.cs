using ParksService.Data.Abstract;
using ParksService.Data.Abstract.Repositories;
using ParksService.Data.Concrete.Repositories;
using Microsoft.AspNetCore.Hosting;

namespace ParksService.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IHostingEnvironment Environment { get; }
        public IAddressRepository AddressRepository { get; }
        public IParkRepository ParkRepository { get; }
        public IEntranceFeeRepository EntranceFeeRepository { get; }

        public UnitOfWork(IHostingEnvironment Environment)
        {
            this.Environment = Environment;
            AddressRepository = new AddressRepository(Environment);
            ParkRepository = new ParkRepository(Environment);
            EntranceFeeRepository = new EntranceFeeRepository(Environment);
        }

    }
}
