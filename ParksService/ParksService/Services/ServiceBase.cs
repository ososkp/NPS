using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParksService.Data.Abstract;

namespace ParksService.Services
{
    public abstract class ServiceBase
    {
	    protected IDataHandler _dataHandler;

		protected ServiceBase(IDataHandler dataHandler)
		{
			_dataHandler = dataHandler;
		}
    }
}
