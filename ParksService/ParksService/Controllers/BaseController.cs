using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksService.Data.Abstract;
using ParksService.Data.Abstract.Repositories;

namespace ParksService.Controllers
{
    public abstract class BaseController : Controller
    {
	    // ReSharper disable once InconsistentNaming
	    protected IParkRepository _parkRepository;

	    protected BaseController(IParkRepository parkRepository)
	    {
		    _parkRepository = parkRepository;
	    }
    }
}