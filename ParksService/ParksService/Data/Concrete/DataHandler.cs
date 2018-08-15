using ParksService.Data.Abstract;
using ParksService.Models;
using ParksService.ViewModels;

namespace ParksService.Data.Concrete
{
    public class DataHandler : IDataHandler
    {
		public IParkData ParkData { get; }
		public IPark Park { get; }

		public DataHandler()
		{
			ParkData = new ParkData();
			Park = new Park();
		}
    }
}
