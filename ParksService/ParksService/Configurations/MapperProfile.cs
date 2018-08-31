using AutoMapper;
using ParksService.Helpers;
using ParksService.Models;
using ParksService.ViewModels;

namespace ParksService.Configurations
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			Mapper.Initialize(cfg =>
			{
				CreateMap<Park, ParkViewModel>()
					.ForMember(dest => dest.FullState,
						opts => opts.MapFrom(src => ParkServiceHelper.GetFullState(src.States)))
					.ForMember(dest => dest.Address,
						opts => opts.MapFrom(src => ParkServiceHelper.MapAddress(src)))
					.ForMember(dest => dest.EntranceFees,
						opts => opts.MapFrom(src => ParkServiceHelper.MapEntranceFee(src)));
//					.ForMember(dest => dest.OperatingHours,
//						opts => opts.MapFrom(src => ParkServiceHelper.MapOperatingHours(src)));
//					.ForMember(dest => dest.Images,
//						opts => opts.MapFrom(src => ParkServiceHelper.MapImageData(src)));
			});
		}
	}
}
