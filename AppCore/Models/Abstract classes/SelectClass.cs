﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class SelectClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public SelectClass()
        {
        }

        public SelectClass(string name, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Status = status;
        }
    }
}
