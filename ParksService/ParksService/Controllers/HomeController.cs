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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
