using Microsoft.AspNetCore.Mvc;
using ParksService.Data;
using ParksService.Data.Abstract;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Controllers
{
	public class ParkController : BaseController
	{
		public ParkController(IParkRepository parkRepository) : base(parkRepository)
		{
		}

		public IActionResult Index()
        {
            return View();
        }
	}
}