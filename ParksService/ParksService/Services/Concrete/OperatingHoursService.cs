using System.Collections.Generic;
using ParksService.Data.Abstract;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
    public class OperatingHoursService : ServiceBase, IOperatingHoursService
    {
		public OperatingHoursService(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

	    public IEnumerable<OperatingHours> GetAll()
	    {
		    return _unitOfWork.OperatingHoursRepository.GetAll();
	    }

	    public void WriteData(IEnumerable<OperatingHours> data)
	    {
		    _unitOfWork.OperatingHoursRepository.WriteData(data);
	    }
    }
}
