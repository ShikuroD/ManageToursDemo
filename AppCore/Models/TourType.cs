using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class TourType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public TourType()
        {
        }

        public TourType(string name, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Status = status;
        }
    }
}
