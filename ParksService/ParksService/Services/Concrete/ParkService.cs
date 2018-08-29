using System;
using System.Collections.Generic;
using System.Linq;
using ParksService.Data.Abstract;
using ParksService.Helpers;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
	public class ParkService : ServiceBase, IParkService
    {
		public ParkService(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		public IEnumerable<Park> GetAll()
	    {
		    return _unitOfWork.ParkRepository.GetAll();
	    }

	    public Park GetParkById(Guid id)
	    {
		    return _unitOfWork.ParkRepository.Find(p => p.Id == id).FirstOrDefault();
	    }

	    public IEnumerable<Park> GetParksByFullState(string state)
	    {
		    var fullStateDictionary = ParkServiceHelper
			    .GetStateDictionary()
			    .ToDictionary(kp => kp.Value, kp => kp.Key);

		    return _unitOfWork.ParkRepository.Find(p => p.States == fullStateDictionary[state]);
	     }

	    public IEnumerable<Park> GetParksByState(string state)
	    {
		    return _unitOfWork.ParkRepository.Find(p => p.States == state);
	    }

	    public IEnumerable<Park> GetParksByDesignation(string designation)
	    {
		    return _unitOfWork.ParkRepository.Find(p => p.Designation == designation);
	    }

	    public IEnumerable<Park> RepopulateParksList(IEnumerable<Park> data)
	    {
			WriteParks(data);
		    return GetAll();
		}

	    public void WriteParks(IEnumerable<Park> data)
	    {
		    _unitOfWork.ParkRepository.WriteParks(data);
	    }
    }
}
