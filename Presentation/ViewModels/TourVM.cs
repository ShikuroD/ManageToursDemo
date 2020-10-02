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

        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public TourVM() { }
        public TourVM(string name, string description, string tourTypeName, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Description = description;
            Status = status;
            TourTypeName = tourTypeName;
        }
    }
}
