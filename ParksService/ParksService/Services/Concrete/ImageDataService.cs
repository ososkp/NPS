using System.Collections.Generic;
using ParksService.Data.Abstract;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
	public class ImageDataService : ServiceBase, IImageDataService
    {
		public ImageDataService(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		public IEnumerable<ImageData> GetAll()
		{
			return _unitOfWork.ImageDataRepository.GetAll();
		}

		public void WriteData(IEnumerable<ImageData> data)
		{
			_unitOfWork.ImageDataRepository.WriteData(data);
		}
    }
}
