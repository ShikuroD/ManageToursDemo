using AppCore;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Presentation.ViewModels.DataTables
{
    class TblPerson : DataTable
    {
        public TblPerson()
        {
            this.Create();
        }
        public TblPerson(IList<Person> arr)
        {
            this.Create();
            this.Fill(arr);
        }


        public void Create()
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
        }


        public void Fill(IList<Person> arr)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                string sex = "Khác";
                if (t.Sex == SEX.MALE) sex = "Nam";
                else if (t.Sex == SEX.FEMALE) sex = "Nữ";

                var statusName = t.Status == STATUS.AVAILABLE ? "O" : "X";
                this.Rows.Add(t.Id, t.Name,t.Sex, sex, t.IdentityCode, t.PhoneNumber, t.Address, t.Status, statusName);
            }
        }
    }
}
