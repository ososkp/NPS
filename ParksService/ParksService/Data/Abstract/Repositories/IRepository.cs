using System;
using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Data.Abstract.Repositories
{
    public interface IRepository<T> where T : class
    {
	    IEnumerable<T> Find(Func<T, bool> predicate);
	    IEnumerable<T> GetAll();
	    IEnumerable<Park> RepopulateParksList(IEnumerable<Park> data);
	}
}
