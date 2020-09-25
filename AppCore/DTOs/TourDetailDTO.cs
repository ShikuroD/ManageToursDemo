using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.DTOs
{
    public class TourDetailDTO
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int LocationId { get; set; }
        public int Order { get; set; }

        public TourDetailDTO()
        {
        }

        public TourDetailDTO(int tourId, int locationId, int order)
        {
            TourId = tourId;
            LocationId = locationId;
            Order = order;
        }
    }
}
