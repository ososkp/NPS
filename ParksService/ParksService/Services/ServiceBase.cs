using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParksService.Data.Abstract;
using ParksService.Data.Abstract.Repositories;

namespace ParksService.Services
{
    public abstract class ServiceBase
    {
		//	    protected IParkRepository _parkRepository;
		//
		//		protected ServiceBase(IParkRepository parkRepository)
		//		{
		//			_parkRepository = parkRepository;
		//		}

		protected IUnitOfWork _unitOfWork;

		protected ServiceBase(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
    }
}
