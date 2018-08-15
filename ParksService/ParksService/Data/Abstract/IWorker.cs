using System;
using System.Linq;
using System.Threading.Tasks;
using ParksService.Services.Abstract;

namespace ParksService.Data.Abstract
{
    public interface IWorker
    {
	    IParkService ParkService { get; }
    }
}
