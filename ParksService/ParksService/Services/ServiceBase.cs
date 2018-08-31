using ParksService.Data.Abstract;

namespace ParksService.Services
{
    public abstract class ServiceBase
    {
		protected IUnitOfWork _unitOfWork;

		protected ServiceBase(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
	}
}
