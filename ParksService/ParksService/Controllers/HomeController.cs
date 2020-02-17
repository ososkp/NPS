using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParksService.ViewModels;
using System.Diagnostics;
using AutoMapper;
using ParksService.Models;
using ParksService.Services.Abstract;
using Microsoft.AspNetCore.Hosting;

namespace ParksService.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IHostingEnvironment env, IParkService parkService, IMapper mapper)
            : base(env, parkService, mapper)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetParks()
        {
            var parks = _parkService.GetAll();
            var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

            return Json(new { viewModel });
        }

        [HttpGet]
        public Park GetParkById(Guid id)
        {
            return _parkService.GetParkById(id);
        }

        [HttpPost]
        public IActionResult PopulateParks([FromBody] IEnumerable<Park> parks)
        {
            // Repopulate the local Json and app data
            _parkService.RepopulateParksList(parks);

            return Content("Ok");
        }

        public IActionResult About()
        {
            var parks = _parkService.GetAll();
            var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

            return View(viewModel);
        }

        public IActionResult Explore()
        {
            var parks = _parkService.GetAll();
            var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

            return View(viewModel);
        }

        public IActionResult Directory()
        {
            var parks = _parkService.GetAll();
            var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult ViewDetails(Guid id)
        {
            var park = _parkService.GetParkById(id);
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
