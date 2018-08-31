using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
    public interface IImageDataService
    {
	    IEnumerable<ImageData> GetAll();
	    void WriteData(IEnumerable<ImageData> data);
	}
}
