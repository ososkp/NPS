using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
    public interface IEntranceFeeService
    {
	    IEnumerable<EntranceFee> GetAll();
	    void WriteData(IEnumerable<EntranceFee> data);
	}
}
