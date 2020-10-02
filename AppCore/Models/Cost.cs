using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class Cost
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Value { get; set; }
        public string Description { get; set; }

        public int CostTypeId { get; set; }
        public CostType CostType { get; set; }
        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public Cost()
        {
        }

        public Cost(string name, double value, string description, int costTypeId, CostType costType, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Value = value;
            Description = description;
            CostTypeId = costTypeId;
            CostType = costType;
            Status = status;
        }
    }
}
