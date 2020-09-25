using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AppCore.Models
{
    public class Price
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get;set; }
        public double Value { get; set; }

        [Display(Name = "Start date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime EndDate { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;
        public Price()
        {
        }

        public Price(int tourId, double value, DateTime startDate, DateTime endDate, STATUS status = STATUS.AVAILABLE)
        {
            TourId = tourId;
            Value = value;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }
    }
}
