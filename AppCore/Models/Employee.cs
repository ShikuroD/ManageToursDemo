using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppCore.Models
{
    public class Employee : Person
    {
        public Employee() : base()
        {
        }

        public Employee(string name, SEX sex, string identityCode, string phoneNumber, string address, STATUS status = STATUS.AVAILABLE)
            : base(name, sex, identityCode, phoneNumber, address, status)
        {

        }
    }
}
