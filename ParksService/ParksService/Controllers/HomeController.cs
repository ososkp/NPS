using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParksService.Services;
using ParksService.ViewModels;
using System.Diagnostics;
using System.Linq;
using ParksService.Data;
using ParksService.Data.Abstract;
using ParksService.Models;
using JsonHandler = ParksService.Services.JsonHandler;


namespace ParksService.Controllers
{
	public class HomeController : BaseController
    {
		public HomeController(IWorker worker) : base(worker)
		{
		}

        public IActionResult Index()
        {
	        var data = JsonHandler.GetParks();
	        return View(data);
		}

	    [HttpGet]
	    public IActionResult GetParks()
	    {
		    var data = JsonHandler.GetParks();
		    return Json(new {data});
	    }

	    [HttpPost]
	    public IActionResult PopulateParks([FromBody] IEnumerable<ParkData> data)
	    {
		    JsonHandler.WriteParksData(data);

		    return Content("Ok");
	    }

        public IActionResult About()
        {
			var data = JsonHandler.GetParks();
	        return View(data);
		}

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
