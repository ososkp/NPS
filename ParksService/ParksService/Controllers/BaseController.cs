using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParksService.Data.Abstract.Repositories;
using ParksService.Services.Abstract;

namespace ParksService.Controllers
{
    public abstract class BaseController : Controller
    {
	    // ReSharper disable once InconsistentNaming
	    protected IParkRepository _parkRepository;
		protected INpsService _npsService;
		protected readonly IMapper _mapper;

	    protected BaseController(IParkRepository parkRepository, INpsService npsService, IMapper mapper)
	    {
		    _parkRepository = parkRepository;
		    _npsService = npsService;
			_mapper = mapper;
	    }
    }
}