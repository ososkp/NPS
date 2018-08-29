using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParksService.Data;
using ParksService.Data.Abstract;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Controllers
{
	public class ParkController : BaseController
	{
		public ParkController(IParkService parkService, IMapper mapper)
			: base(parkService, mapper)
		{
		}

		public IActionResult Index()
        {
            return View();
        }
	}
}