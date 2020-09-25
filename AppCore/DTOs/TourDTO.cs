using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.DTOs
{
    public class TourDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int TourTypeId { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public TourDTO() { }
        public TourDTO(string name, string description, int tourTypeId, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Description = description;
            Status = status;
            TourTypeId = tourTypeId;
        }
    }
}
