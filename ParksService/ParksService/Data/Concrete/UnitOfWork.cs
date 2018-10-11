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
        public IImageDataRepository ImageDataRepository { get; }
        public IEntranceFeeRepository EntranceFeeRepository { get; }
        public IOperatingHoursRepository OperatingHoursRepository { get; }
        public IHoursExceptionsRepository HoursExceptionsRepository { get; }
        public IWeeklyHoursRepository WeeklyHoursRepository { get; }

        public UnitOfWork(IHostingEnvironment Environment)
        {
            this.Environment = Environment;
            AddressRepository = new AddressRepository(Environment);
            ParkRepository = new ParkRepository(Environment);
            ImageDataRepository = new ImageDataRepository(Environment);
            EntranceFeeRepository = new EntranceFeeRepository(Environment);
            OperatingHoursRepository = new OperatingHoursRepository(Environment);
            HoursExceptionsRepository = new HoursExceptionsRepository(Environment);
            WeeklyHoursRepository = new WeeklyHoursRepository(Environment);
        }

    }
}
