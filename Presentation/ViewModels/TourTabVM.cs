using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.ViewModels
{
    public class TourTabVM
    {
        public IList<Tour> Tours { get; set; }
        public IList<TourType> TourTypes { get; set; }
        public IList<Location> Locations { get; set; }

        public TourTabVM()
        {
        }

        public TourTabVM(IList<Tour> tours, IList<TourType> tourTypes, IList<Location> locations)
        {
            Tours = tours;
            TourTypes = tourTypes;
            Locations = locations;
        }
    }
}
