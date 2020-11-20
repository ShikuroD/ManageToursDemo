using AppCore;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.ViewModels.DataTables
{
    class TblPerson : DataTable
    {
        public TblPerson()
        {
            //this.Create();
        }
        public TblPerson(IList<Person> arr, bool forEmpAnalysis = false)
        {
            this.Create(forEmpAnalysis);
            this.Fill(arr, forEmpAnalysis);
        }

        public TblPerson(IList<Attendant> arr, IList<Employee> emps, IList<Job> jobs)
        {
            this.CreateForAttendant();
            this.Fill(arr, emps, jobs);
        }

        public TblPerson(IList<GroupDetail> arr, IList<Customer> customers)
        {
            this.CreateForGroupDetail();
            this.Fill(arr, customers);
        }

        public void Create(bool forEmpAnalysis = false)
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("Name", typeof(string));
            this.Columns.Add("Sex", typeof(SEX));
            this.Columns.Add("SexName", typeof(string));
            this.Columns.Add("IdentityCode", typeof(string));
            this.Columns.Add("PhoneNumber", typeof(string));
            this.Columns.Add("Address", typeof(string));
            this.Columns.Add("Status", typeof(STATUS));
            this.Columns.Add("StatusName", typeof(string));
            if(forEmpAnalysis) this.Columns.Add("TurnCount", typeof(int));
        }

        public void CreateForAttendant()
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("EmployeeId", typeof(int));
            this.Columns.Add("Name", typeof(string));
            this.Columns.Add("Sex", typeof(SEX));
            this.Columns.Add("SexName", typeof(string));
            this.Columns.Add("JobId", typeof(int));
            this.Columns.Add("JobName", typeof(string));
        }
        public void CreateForGroupDetail()
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("CustomerId", typeof(int));
            this.Columns.Add("Name", typeof(string));
            this.Columns.Add("Sex", typeof(SEX));
            this.Columns.Add("SexName", typeof(string));
        }


        public void Fill(IList<Person> arr, bool forEmpAnalysis = false)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                string sex = "Khác";
                if (t.Sex == SEX.MALE) sex = "Nam";
                else if (t.Sex == SEX.FEMALE) sex = "Nữ";

                var statusName = t.Status == STATUS.AVAILABLE ? "O" : "X";
                if(forEmpAnalysis) this.Rows.Add(t.Id, t.Name, t.Sex, sex, t.IdentityCode, t.PhoneNumber, t.Address, t.Status, statusName, (t as Employee).TurnCount);
                else this.Rows.Add(t.Id, t.Name,t.Sex, sex, t.IdentityCode, t.PhoneNumber, t.Address, t.Status, statusName);
            }
        }
        public void Fill(IList<Attendant> arr, IList<Employee> emps, IList<Job> jobs)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                var emp = emps.Where(m => m.Id.Equals(t.EmployeeId)).First();
                string sex = "Khác";
                if (emp.Sex == SEX.MALE) sex = "Nam";
                else if (emp.Sex == SEX.FEMALE) sex = "Nữ";

                var jobName = jobs.Where(m => m.Id.Equals(t.JobId)).First().Name;
                this.Rows.Add(t.Id, t.EmployeeId, emp.Name, emp.Sex, sex, t.JobId, jobName);
            }
        }
        public void Fill(IList<GroupDetail> arr, IList<Customer> emps)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                var emp = emps.Where(m => m.Id.Equals(t.CustomerId)).First();
                string sex = "Khác";
                if (emp.Sex == SEX.MALE) sex = "Nam";
                else if (emp.Sex == SEX.FEMALE) sex = "Nữ";
                this.Rows.Add(t.Id, t.CustomerId, emp.Name, emp.Sex, sex);
            }
        }
    }
}
