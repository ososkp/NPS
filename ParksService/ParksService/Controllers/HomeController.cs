using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParksService.ViewModels;
using System.Diagnostics;
using System.Linq;
using AutoMapper;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;


namespace ParksService.Controllers
{
	public class HomeController : BaseController
    {
		public HomeController(IParkRepository parkRepository, IMapper mapper) : base(parkRepository, mapper)
		{
		}

        public IActionResult Index()
        {
	        return View();
		}

	    [HttpGet]
	    public IActionResult GetParks()
	    {
		    var parks = _parkRepository.GetAll().ToList();
		    var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

			return Json(new {viewModel});
	    }

	    [HttpPost]
	    public IActionResult PopulateParks([FromBody] IEnumerable<Park> data)
	    {
		    // Repopulate the local Json and app data

			_parkRepository.RepopulateParksList(data);

			return Content("Ok");
	    }

        public IActionResult About()
        {
	        var parks = _parkRepository.GetAll();
			var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

			return View(viewModel);
		}

	    public IActionResult Explore()
	    {
			var parks = _parkRepository.GetAll();
		    var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

		    return View(viewModel);
		}

        public IActionResult Directory()
        {
			var parks = _parkRepository.GetAll();
	        var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

	        return View(viewModel);
		}

		[HttpGet]
	    public IActionResult ViewDetails(Guid id)
		{
		    var park = _parkRepository.Find(p => p.Id == id).FirstOrDefault();
			var viewModel = _mapper.Map<ParkViewModel>(park);

		    return PartialView("_ViewDetailsModal", viewModel);
	    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
