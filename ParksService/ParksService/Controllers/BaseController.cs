using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParksService.Services.Abstract;

namespace ParksService.Controllers
{
    public abstract class BaseController : Controller
    {
	    protected readonly IParkService _parkService;
	    protected readonly IMapper _mapper;

	    protected BaseController(IParkService parkService, IMapper mapper)
	    {
		    _parkService = parkService;
		    _mapper = mapper;
	    }
    }
}