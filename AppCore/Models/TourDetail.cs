using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class TourDetail
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int Order { get; set; }

        public TourDetail()
        {
        }

        public TourDetail(int tourId, int locationId, int order)
        {
            TourId = tourId;
            LocationId = locationId;
            Order = order;
        }
    }
}
