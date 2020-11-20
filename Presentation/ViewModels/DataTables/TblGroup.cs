using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using AppCore.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.ViewModels.DataTables
{
    class TblGroup : DataTable
    {
        public TblGroup()
        {
            this.Create();
        }
        public TblGroup(IList<Group> arr, bool forAnalysis = false)
        {
            this.Create(forAnalysis);
            this.Fill(arr, forAnalysis);
        }
        

        public void Create(bool forAnalysis = false)
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("Name", typeof(string));
            this.Columns.Add("Value", typeof(decimal));
            this.Columns.Add("StartDate", typeof(DateTime));
            this.Columns.Add("EndDate", typeof(DateTime));
            this.Columns.Add("Description", typeof(string));
            this.Columns.Add("Status", typeof(STATUS));
            this.Columns.Add("StatusName", typeof(string));

            if (forAnalysis)
            {
                this.Columns.Add("GroupDetailCount", typeof(int));
                this.Columns.Add("AttendantCount", typeof(int));
                this.Columns.Add("PriceSum", typeof(decimal));
                this.Columns.Add("CostSum", typeof(decimal));
                this.Columns.Add("Revenue", typeof(decimal));
            }
            
        }
        public void Fill(IList<Group> arr, bool forAnalysis)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                var statusName = t.Status.Equals(STATUS.AVAILABLE) ? "O" : "X";
                if(forAnalysis) 
                    this.Rows.Add(t.Id, t.Name, t.Price, t.StartDate, t.EndDate, t.Description, t.Status, statusName,
                    t.GroupDetailsCount, t.AttendantsCount, t.PriceSum, t.CostSum, t.Revenue); 
                else this.Rows.Add(t.Id, t.Name, t.Price, t.StartDate, t.EndDate, t.Description, t.Status, statusName);
            }
        }

    }
}
