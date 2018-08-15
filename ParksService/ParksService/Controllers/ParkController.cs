using Microsoft.AspNetCore.Mvc;
using ParksService.Data;
using ParksService.Data.Abstract;
using ParksService.Models;

namespace ParksService.Controllers
{
	public class ParkController : BaseController
	{
		public ParkController(IWorker worker) : base(worker)
		{
		}

		public IActionResult Index()
        {
            return View();
        }

		public string GetLatitude(ParkData park)
		{
			return _worker.ParkService.ParseLatitude(park.LatLong);
		}

		public string GetLongitude(ParkData park)
		{
			return _worker.ParkService.ParseLongitude(park.LatLong);
		}

	}
}