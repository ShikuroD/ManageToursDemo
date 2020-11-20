using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppCore.Models
{
    public class Cost
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[DataType(DataType.Currency)]
        public decimal Value { get; set; }
        public string Description { get; set; }

        public int CostTypeId { get; set; }
        public CostType CostType { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public Cost()
        {
        }

        public Cost(string name, decimal value, string description, int costTypeId, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Value = value;
            Description = description;
            CostTypeId = costTypeId;
            Status = status;
        }
        public Cost(Cost cost)
        {
            Copy(cost);
        }
        public void Copy(Cost cost)
        {
            Name = cost.Name;
            Value = cost.Value;
            Description = cost.Description;
            CostTypeId = cost.CostTypeId;
            Status = cost.Status;
        }
    }
}
