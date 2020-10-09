using AppCore.Interfaces;
using AppCore.Models;
using AppCore.Services;
using AutoMapper;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.VMServices
{
    public class VMTourService : IVMTourService
    {
        private readonly ITourService _tourService;
        private readonly ITourTypeService _tourTypeService;
        private readonly ILocationService _locationService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TourTabVM TourVM { get; set; }

        public VMTourService(IUnitOfWork unitOfWork, IMapper mapper, ITourService tours, ITourTypeService tourTypes, ILocationService locations)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _tourService = tours;
            _tourTypeService = tourTypes;
            _locationService = locations;
        }

        //--------------------------------------------------------------------------------------------------------------------------
        //viewmodel
        //--------------------------------------------------------------------------------------------------------------------------
        public TourTabVM LoadTourTabData()
        {
            var vm = new TourTabVM();
            vm.TourTypes = _unitOfWork.TourTypes.GetAll();
            vm.Tours = _unitOfWork.Tours.GetAll();
            vm.Locations = _unitOfWork.Locations.GetAll();

            return vm;
        }

    }
}
