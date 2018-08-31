using System.Collections.Generic;
using ParksService.Data.Abstract;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
    public class HoursExceptionsService : ServiceBase, IHoursExceptionsService
    {
		public HoursExceptionsService(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

	    public IEnumerable<HoursExceptions> GetAll()
	    {
		    return _unitOfWork.HoursExceptionsRepository.GetAll();
	    }

	    public void WriteData(IEnumerable<HoursExceptions> data)
	    {
		    _unitOfWork.HoursExceptionsRepository.WriteData(data);
	    }
    }
}
