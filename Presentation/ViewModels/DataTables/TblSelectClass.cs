using AppCore;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.ViewModels.DataTables
{
    public class TblSelectClass : DataTable
    {
        public TblSelectClass()
        {
            this.Create();
        }
        public TblSelectClass(IList<SelectClass> arr)
        {
            this.Create();
            this.Fill(arr);
        }
        public TblSelectClass(IList<Location> locs, IList<TourDetail> arr)
        {
            this.Create_ViewTourDetail();
            this.Fill_ViewTourDetail(locs, arr);
        }


        public void Create()
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("Name", typeof(string));
            this.Columns.Add("Status", typeof(STATUS));
            this.Columns.Add("StatusName", typeof(string));
        }
        public void Create_ViewTourDetail()
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("Name", typeof(string));
        }


        public void Fill(IList<SelectClass> arr)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                var statusName = t.Status == STATUS.AVAILABLE ? "O" : "X";
                this.Rows.Add(t.Id, t.Name, t.Status, statusName);
            }
        }
        public void Fill_ViewTourDetail(IList<Location> locs, IList<TourDetail> arr)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                var name = locs.Where(m => m.Id.Equals(t.LocationId)).Select(m => m.Name).FirstOrDefault();
                this.Rows.Add(t.LocationId, name);
            }
        }
    }
}
