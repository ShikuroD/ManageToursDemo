using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int TourTypeId { get; set; }
        public TourType TourType { get; set; }

        public IList<Price> Prices { get; set; }

        public IList<TourDetail> TourDetails { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public Tour() { }
        public Tour(string name, string description, int tourTypeId, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Description = description;
            Status = status;
            TourTypeId = tourTypeId;
        }
    }
    
}
