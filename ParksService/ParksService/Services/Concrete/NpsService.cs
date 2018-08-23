using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParksService.Data.Abstract.Repositories;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
    public class NpsService : ServiceBase, INpsService
    {
	    public IParkService ParkService { get; }

	    public NpsService(IParkRepository parkRepository) : base(parkRepository)
	    {
		    ParkService = new ParkService(_parkRepository);
		}
    }
}
