using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AppCore.Models
{
    public class Price
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get;set; }

        //[DataType(DataType.Currency)]
        public decimal Value { get; set; }

        [Display(Name = "Start date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EndDate { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;
        public Price()
        {
        }

        public Price(string name, int tourId, decimal value, DateTime startDate, DateTime endDate, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            TourId = tourId;
            Value = value;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }
        public Price(Price price)
        {
            Name = price.Name;
            TourId = price.TourId;
            Value = price.Value;
            StartDate = price.StartDate;
            EndDate = price.EndDate;
            Status = price.Status;
        }
        public void Copy(Price price)
        {
            Name = price.Name;
            TourId = price.TourId;
            Value = price.Value;
            StartDate = price.StartDate;
            EndDate = price.EndDate;
            Status = price.Status;
        }
    }
}
