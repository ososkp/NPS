using ParksService.Data.Abstract.Repositories;

namespace ParksService.Data.Abstract
{
    public interface IUnitOfWork
    {
		IAddressRepository AddressRepository { get; }
		IParkRepository ParkRepository { get; }
		IImageDataRepository ImageDataRepository { get; }
		IEntranceFeeRepository EntranceFeeRepository { get; }
		IOperatingHoursRepository OperatingHoursRepository { get; }
		IHoursExceptionsRepository HoursExceptionsRepository { get; }
		IWeeklyHoursRepository WeeklyHoursRepository { get; }
    }
}
