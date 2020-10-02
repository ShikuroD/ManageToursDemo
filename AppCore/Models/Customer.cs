using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SEX Sex { get; set; }
        public string IdentityCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
