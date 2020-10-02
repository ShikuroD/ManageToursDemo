using AppCore.DTOs;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.VMServices
{
    public interface IVMTourService
    {
        //View models
        TourTabVM LoadTourTabData();

        

        ///tours
        IEnumerable<TourDTO> GetAllTours();
        TourDTO GetTour(int id);
        TourDTO AddTour(TourDTO entity);
        void UpdateTour(TourDTO entity);
        void DeleteTour(TourDTO entity);
        void ActivateTour(TourDTO entity);
        void DisableTour(TourDTO entity);

        ///locations
        IEnumerable<LocationDTO> GetAllLocations();
        LocationDTO GetLocation(int id);
        LocationDTO AddLocation(LocationDTO entity);
        void UpdateLocation(LocationDTO entity);
        void DeleteLocation(LocationDTO entity);
        void ActivateLocation(LocationDTO entity);
        void DisableLocation(LocationDTO entity);

        ///tourtypes
        IEnumerable<TourTypeDTO> GetAllTourTypes();
        TourTypeDTO GetTourType(int id);
        TourTypeDTO AddTourType(TourTypeDTO entity);
        void UpdateTourType(TourTypeDTO entity);
        void DeleteTourType(TourTypeDTO entity);
        void ActivateTourType(TourTypeDTO entity);
        void DisableTourType(TourTypeDTO entity);
    }
}
