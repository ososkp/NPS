using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using ParksService.Models;
using ParksService.Services.Abstract;
using ParksService.ViewModels;
using System.Collections.Generic;
using System;

namespace ParksService.Controllers
{
    public class ParkController : BaseController
    {
        public ParkController(IHostingEnvironment env, IParkService parkService, IMapper mapper)
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

        [HttpGet]
        public IActionResult ViewDetails(Guid id)
        {
            var park = _parkService.GetParkById(id);
            var viewModel = _mapper.Map<ParkViewModel>(park);

            return PartialView("_ViewDetailsModal", viewModel);
        }
    }
}