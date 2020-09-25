using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using AppCore.Models;

namespace AppCore.DTOs
{
    public class PriceDTO
    {
        public int Id { get; set; }
        public int TourId { get; set; }

        [DataType(DataType.Currency)]
        public double Value { get; set; }

        [Display(Name = "Start date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime EndDate { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public PriceDTO()
        {
        }

        public PriceDTO(int tourId, double value, DateTime startDate, DateTime endDate, STATUS status = STATUS.AVAILABLE)
        {
            TourId = tourId;
            Value = value;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }
    }
}
