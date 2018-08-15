using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksService.Data.Abstract;

namespace ParksService.Controllers
{
    public abstract class BaseController : Controller
    {
	    // ReSharper disable once InconsistentNaming
	    protected IWorker _worker;

	    protected BaseController(IWorker worker)
	    {
			_worker = worker;
	    }
    }
}