
using AppCore.Models;
using AutoMapper;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentaton.ViewModels
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Tour, TourVM>();
            CreateMap<TourVM, Tour>();
        }
    }
}
