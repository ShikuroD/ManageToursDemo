using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class Location : SelectClass
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public Location() : base()
        {
        }

        public Location(string name, STATUS status = STATUS.AVAILABLE) : base(name, status)
        {
            
        }
    }
}
