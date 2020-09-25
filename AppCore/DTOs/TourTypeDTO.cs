using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.DTOs
{
    public class TourTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public TourTypeDTO()
        {
        }

        public TourTypeDTO(string name, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Status = status;
        }
    }
}
