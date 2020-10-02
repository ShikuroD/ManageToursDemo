using AppCore.DTOs;
using AppCore.Services;
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

        public TourTabVM TourVM { get; set; }

        public VMTourService(ITourService tours, ITourTypeService tourTypes, ILocationService locations)
        {
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
            vm.TourTypes = _tourTypeService.GetAll().Result;
            vm.Tours = _tourService.GetAll().Result;
            vm.Locations = _locationService.GetAll().Result;

            return vm;
        }






        //--------------------------------------------------------------------------------------------------------------------------
        //tours
        //--------------------------------------------------------------------------------------------------------------------------
        public IEnumerable<TourDTO> GetAllTours()
        {
            return _tourService.GetAll().Result;
        }
        public TourDTO GetTour(int id)
        {
            return _tourService.GetBy(id).Result;
        }
        public TourDTO AddTour(TourDTO entity)
        {
            return _tourService.Add(entity).Result;
        }
        public void UpdateTour(TourDTO entity)
        {
            _tourService.Update(entity);
        }
        public void DeleteTour(TourDTO entity)
        {
            _tourService.Delete(entity);
        }

        public void ActivateTour(TourDTO entity)
        {
            _tourService.Activate(entity);
        }

        public void DisableTour(TourDTO entity)
        {
            _tourService.Disable(entity);
        }

        //--------------------------------------------------------------------------------------------------------------------------
        ///locationss
        //--------------------------------------------------------------------------------------------------------------------------
        public IEnumerable<LocationDTO> GetAllLocations()
        {
            return _locationService.GetAll().Result;
        }
        public LocationDTO GetLocation(int id)
        {
            return _locationService.GetBy(id).Result;
        }
        public LocationDTO AddLocation(LocationDTO entity)
        {
            return _locationService.Add(entity).Result;
        }
        public void UpdateLocation(LocationDTO entity)
        {
            _locationService.Update(entity);
        }
        public void DeleteLocation(LocationDTO entity)
        {
            _locationService.Delete(entity);
        }

        public void ActivateLocation(LocationDTO entity)
        {
            _locationService.Activate(entity);
        }

        public void DisableLocation(LocationDTO entity)
        {
            _locationService.Disable(entity);
        }

        ///tourtypes
        public IEnumerable<TourTypeDTO> GetAllTourTypes()
        {
            return _tourTypeService.GetAll().Result;
        }
        public TourTypeDTO GetTourType(int id)
        {
            return _tourTypeService.GetBy(id).Result;
        }
        public TourTypeDTO AddTourType(TourTypeDTO entity)
        {
            return _tourTypeService.Add(entity).Result;
        }
        public void UpdateTourType(TourTypeDTO entity)
        {
            _tourTypeService.Update(entity);
        }
        public void DeleteTourType(TourTypeDTO entity)
        {
            _tourTypeService.Delete(entity);
        }

        public void ActivateTourType(TourTypeDTO entity)
        {
            _tourTypeService.Activate(entity);
        }

        public void DisableTourType(TourTypeDTO entity)
        {
            _tourTypeService.Disable(entity);
        }
    }
}
