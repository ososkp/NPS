using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParksService.Data.Abstract.Repositories;
using ParksService.Services.Abstract;
using ParksService.ViewModels;

namespace ParksService.Controllers
{
    public class ExploreController : BaseController
    {
	    public ExploreController(IParkRepository parkRepository, INpsService npsService, IMapper mapper) 
		    : base(parkRepository, npsService, mapper)
	    {
	    }

		public IActionResult Index()
        {
	        var parks = _parkRepository.GetAll();
	        var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(parks);

			return View();
        }

	    public IActionResult GetParksByState(string state)
	    {
		    var data = _npsService.ParkService.GetParksByFullState(state);
		    var viewModel = _mapper.Map<IEnumerable<ParkViewModel>>(data);

			return Json(new { viewModel });
	    }
    }
}