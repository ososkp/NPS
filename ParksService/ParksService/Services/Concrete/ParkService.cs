using System;
using System.Collections.Generic;
using System.Linq;
using ParksService.Data.Abstract.Repositories;
using ParksService.Helpers;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
    public class ParkService : ServiceBase, IParkService
    {
		public ParkService(IParkRepository parkRepository) : base(parkRepository)
		{
		}

		public IEnumerable<Park> GetAll()
	    {
		    return _parkRepository.GetAll();
	    }

	    public Park GetParkById(Guid id)
	    {
		    return _parkRepository.Find(p => p.Id == id).FirstOrDefault();
	    }

	    public IEnumerable<Park> GetParksByFullState(string state)
	    {
		    var fullStateDictionary = ParkServiceHelper
			    .GetStateDictionary()
			    .ToDictionary(kp => kp.Value, kp => kp.Key);

		    var test = _parkRepository.Find(p => p.States == fullStateDictionary[state]).ToList();
		    return _parkRepository.Find(p => p.States == fullStateDictionary[state]);
	     }

	    public IEnumerable<Park> GetParksByState(string state)
	    {
		    return _parkRepository.Find(p => p.States == state);
	    }

	    public IEnumerable<Park> GetParksByDesignation(string designation)
	    {
		    return _parkRepository.Find(p => p.Designation == designation);
	    }
	}
}
