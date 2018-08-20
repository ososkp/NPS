using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParksService.ViewModels;
using System.Diagnostics;
using System.Linq;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;


namespace ParksService.Controllers
{
	public class HomeController : BaseController
    {
		public HomeController(IParkRepository parkRepository) : base(parkRepository)
		{
		}

        public IActionResult Index()
        {
	        return View();
		}

	    [HttpGet]
	    public IActionResult GetParks()
	    {
		    var data = _parkRepository.GetAll();
		    return Json(new {data});
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
	        return View(_parkRepository.GetAll());
		}

	    public IActionResult Explore()
	    {
		    return View(_parkRepository.GetAll());
	    }

        public IActionResult Directory()
        {
	        return View(_parkRepository.GetAll());
		}

	    public IActionResult ViewDetails(string id)
	    {
		    var park = _parkRepository.Find(p => p.Id == id).FirstOrDefault();
		    return PartialView("_ViewDetailsModal", park);
	    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
