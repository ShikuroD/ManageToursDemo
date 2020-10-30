using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models.Abstract_classes
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public STATUS Status { get; set; }

        public BaseEntity()
        {

        }
        public BaseEntity(string name, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Status = status;
        }
    }
}
