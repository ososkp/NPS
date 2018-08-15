using ParksService.Data.Abstract;
using ParksService.Services;
using ParksService.Services.Abstract;
using ParksService.Services.Concrete;

namespace ParksService.Data.Concrete
{
	public class Worker : ServiceBase, IWorker
	{
		public Worker(IDataHandler dataHandler) : base(dataHandler)
		{
			ParkService = new ParkService(dataHandler);
		}

		public IParkService ParkService { get; }
	}
}
