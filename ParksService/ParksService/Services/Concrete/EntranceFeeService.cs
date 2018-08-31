using System.Collections.Generic;
using ParksService.Data.Abstract;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
    public class EntranceFeeService : ServiceBase, IEntranceFeeService
    {
		public EntranceFeeService(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

	    public IEnumerable<EntranceFee> GetAll()
	    {
		    return _unitOfWork.EntranceFeeRepository.GetAll();
	    }

	    public void WriteData(IEnumerable<EntranceFee> data)
	    {
		    _unitOfWork.EntranceFeeRepository.WriteData(data);
	    }
    }
}
