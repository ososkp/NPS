using ParksService.Data.Abstract;
using ParksService.Data.Abstract.Repositories;
using ParksService.Data.Concrete.Repositories;

namespace ParksService.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
	    public IAddressRepository AddressRepository { get; }
	    public IParkRepository ParkRepository { get; }
	    public IImageDataRepository ImageDataRepository { get; }
	    public IEntranceFeeRepository EntranceFeeRepository { get; }
	    public IOperatingHoursRepository OperatingHoursRepository { get; }
	    public IHoursExceptionsRepository HoursExceptionsRepository { get; }
	    public IWeeklyHoursRepository WeeklyHoursRepository { get; }

	    public UnitOfWork()
		{
			AddressRepository = new AddressRepository();
			ParkRepository = new ParkRepository();
			ImageDataRepository = new ImageDataRepository();
			EntranceFeeRepository = new EntranceFeeRepository();
			OperatingHoursRepository = new OperatingHoursRepository();
			HoursExceptionsRepository = new HoursExceptionsRepository();
			WeeklyHoursRepository = new WeeklyHoursRepository();
		}

	}
}
