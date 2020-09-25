using AppCore.DTOs;
using AppCore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Tour, TourDTO>();
            CreateMap<TourDTO, Tour>();

            CreateMap<TourType, TourTypeDTO>();
            CreateMap<TourTypeDTO, TourType>();

            CreateMap<TourDetail, TourDetailDTO>();
            CreateMap<TourDetailDTO, TourDetail>();

            CreateMap<Location, LocationDTO>();
            CreateMap<LocationDTO, Location>();

            CreateMap<Price, PriceDTO>();
            CreateMap<PriceDTO, Price>();
        }
    }
}
