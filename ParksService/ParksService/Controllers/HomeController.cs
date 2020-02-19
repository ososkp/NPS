using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParksService.ViewModels;
using System.Diagnostics;
using AutoMapper;
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

        public IActionResult About()
        {
            var viewModel = GetAndMapParks();
            return View(viewModel);
        }

        public IActionResult Explore()
        {
            var viewModel = GetAndMapParks();
            return View(viewModel);
        }

        public IActionResult Directory()
        {
            var viewModel = GetAndMapParks();
            return View(viewModel);
        }

        public IEnumerable<ParkViewModel> GetAndMapParks()
        {
            var parks = _parkService.GetAll();
            return _mapper.Map<IEnumerable<ParkViewModel>>(parks);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
