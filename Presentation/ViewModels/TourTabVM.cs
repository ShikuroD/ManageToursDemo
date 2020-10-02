using AppCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.ViewModels
{
    public class TourTabVM
    {
        public IList<TourDTO> Tours { get; set; }
        public IList<TourTypeDTO> TourTypes { get; set; }
        public IList<LocationDTO> Locations { get; set; }

        public TourTabVM()
        {
        }

        public TourTabVM(IList<TourDTO> tours, IList<TourTypeDTO> tourTypes, IList<LocationDTO> locations)
        {
            Tours = tours;
            TourTypes = tourTypes;
            Locations = locations;
        }
    }
}
