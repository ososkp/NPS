using System.Collections.Generic;
using ParksService.Data.Abstract;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
    public class WeeklyHoursService : ServiceBase, IWeeklyHoursService
    {
	    public WeeklyHoursService(IUnitOfWork unitOfWork) : base(unitOfWork)
	    {
	    }

	    public IEnumerable<WeeklyHours> GetAll()
	    {
		    return _unitOfWork.WeeklyHoursRepository.GetAll();
	    }

	    public void WriteData(IEnumerable<WeeklyHours> data)
	    {
		    _unitOfWork.WeeklyHoursRepository.WriteData(data);
	    }
    }
}
