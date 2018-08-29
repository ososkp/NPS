using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParksService.Services.Abstract;
using ParksService.ViewModels;

namespace ParksService.Controllers
{
    public class ExploreController : BaseController
    {
	    public ExploreController(IParkService parkService, IMapper mapper) : base(parkService, mapper)
	    {
	    }

		public IActionResult Index()
        {
	        var parks = _parkService.GetAll();
	        var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

			return View(viewModel);
        }

	    public IActionResult GetParksByState(string state)
	    {
		    var data = _parkService.GetParksByFullState(state);
		    var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(data);

			return Json(new { viewModel });
	    }

	    public IActionResult GetParksByDesignation(string designation)
	    {
		    var data = _parkService.GetParksByGeneralDesignation(designation);
		    var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(data);

		    return Json(new { viewModel });
		}
    }
}