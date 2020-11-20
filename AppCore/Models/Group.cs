using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.RegularExpressions;

namespace AppCore.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Start date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime EndDate { get; set; }

        //[DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public int TourId { get; set; }

        public Tour Tour { get; set; }

        public IList<Cost> Costs { get; set; }
        public IList<Attendant> Attendants { get; set; }
        public IList<GroupDetail> GroupDetails { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        [NotMapped]
        public int GroupDetailsCount { get; set; }
        [NotMapped]
        public int AttendantsCount { get; set; }
        [NotMapped]
        public decimal PriceSum { get; set; }
        [NotMapped]
        public decimal CostSum { get; set; }
        [NotMapped]
        public decimal Revenue { get; set; }

        public Group()
        {
        }

        public Group(string name, DateTime startDate, DateTime endDate, decimal price, string description, int tourId, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
            Description = description;
            TourId = tourId;
            Status = status;
        }
        public Group(Group group)
        {
            this.Copy(group);
        }
        public void Copy(Group g)
        {
            Name = g.Name;
            StartDate = g.StartDate;
            EndDate = g.EndDate;
            Price = g.Price;
            Description = g.Description;
            TourId = g.TourId;
            Status = g.Status;
        }
        public Group Clone()
        {
            var res = new Group(this);
            res.Id = this.Id;
            return res;
        }
    }
}
