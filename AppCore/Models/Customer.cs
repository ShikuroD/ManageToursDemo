using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppCore.Models
{
    public class Customer : Person
    {

        public Customer() : base()
        {
        }

        public Customer(string name, SEX sex, string identityCode, string phoneNumber, string address, STATUS status = STATUS.AVAILABLE)
            : base(name,sex,identityCode,phoneNumber,address,status)
        {
            
        }
    }
}
