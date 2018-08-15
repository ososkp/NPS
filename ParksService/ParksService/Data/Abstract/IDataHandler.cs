using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParksService.Models;

namespace ParksService.Data.Abstract
{
    public interface IDataHandler
    {
		IParkData ParkData { get; }
		IPark Park { get; }
    }
}
