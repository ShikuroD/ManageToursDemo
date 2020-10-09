using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class Attendant
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Attendant()
        {
        }

        public Attendant(int groupId, Group group, int employeeId, Employee employee)
        {
            GroupId = groupId;
            Group = group;
            EmployeeId = employeeId;
            Employee = employee;
        }
    }
}
