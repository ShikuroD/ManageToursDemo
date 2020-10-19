using AppCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.ViewModels
{
    public class TourVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string TourTypeName { get; set; }

        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public TourVM() { }
        public TourVM(string name, string description, string tourTypeName, decimal price,
            DateTime start, DateTime end, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Description = description;
            StartDate = start;
            EndDate = end;
            Status = status;
            Price = price;
            TourTypeName = tourTypeName;
        }
    }
}
