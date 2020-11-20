using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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

        public IList<Group> Groups { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        [NotMapped]
        public decimal SumRevenue { get; set; }
        [NotMapped]
        public decimal SumCost { get; set; }
        [NotMapped]
        public decimal SumPrice { get; set; }

        public Tour() { }
        public Tour(string name, string description, int tourTypeId, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Description = description;
            Status = status;
            TourTypeId = tourTypeId;
        }
        public Tour Clone()
        {
            var res = new Tour(this.Name, this.Description, this.TourTypeId, this.Status);
            res.Id = this.Id;
            res.Groups = this.Groups.Select(m => m.Clone()).ToList();
            return res;
        }
    }
    
}
