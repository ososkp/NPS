﻿using AutoMapper;
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
					.ForMember(dest => dest.Latitude,
						opts => opts.MapFrom(src => ParkServiceHelper.ParseLatitude(src.LatLong)))
					.ForMember(dest => dest.Longitude,
						opts => opts.MapFrom(src => ParkServiceHelper.ParseLongitude(src.LatLong)))
				.ForMember(dest => dest.FullState,
					opts => opts.MapFrom(src => ParkServiceHelper.GetFullState(src.States)));

			});
		}
	}
}