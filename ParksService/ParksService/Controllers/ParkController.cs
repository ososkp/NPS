using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParksService.Data;
using ParksService.Data.Abstract;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Controllers
{
	public class ParkController : BaseController
	{
		public ParkController(IParkRepository parkRepository, IMapper mapper) : base(parkRepository, mapper)
		{
		}

		public IActionResult Index()
        {
            return View();
        }
	}
}