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
        public int JobId { get; set; }
        public Job Job { get; set; }

        public Attendant()
        {
        }

        public Attendant(int groupId, int employeeId, int jobId)
        {
            GroupId = groupId;
            EmployeeId = employeeId;
            JobId = jobId;
        }
    }
}
