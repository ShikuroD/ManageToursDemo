using AppCore;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Presentation.ViewModels.DataTables
{
    class TblPrice : DataTable
    {
        public TblPrice()
        {
            this.Create();
        }
        public TblPrice(IList<Price> arr)
        {
            this.Create();
            this.Fill(arr);
        }
        
        public void Create()
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("Name", typeof(string));
            this.Columns.Add("Value", typeof(decimal));
            this.Columns.Add("StartDate", typeof(DateTime));
            this.Columns.Add("EndDate", typeof(DateTime));
            this.Columns.Add("Status", typeof(STATUS));
            this.Columns.Add("StatusName", typeof(string));
        }
        public void Fill(IList<Price> arr)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                var statusName = t.Status == STATUS.AVAILABLE ? "O" : "X";
                this.Rows.Add(t.Id, t.Name, t.Value, t.StartDate, t.EndDate, t.Status, statusName);
            }
        }

    }
}
