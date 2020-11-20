using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Models
{
    public class Employee : Person
    {
        [NotMapped]
        public int TurnCount { get; set; }
        public Employee() : base()
        {
        }

        public Employee(string name, SEX sex, string identityCode, string phoneNumber, string address, STATUS status = STATUS.AVAILABLE)
            : base(name, sex, identityCode, phoneNumber, address, status)
        {

        }
    }
}
