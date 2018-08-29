using ParksService.Models;
using System.Collections.Generic;

namespace ParksService.Data.Abstract.Repositories
{
    public interface IParkRepository : IRepository<Park>
    {
	    void WriteParks(IEnumerable<Park> data);
    }
}
