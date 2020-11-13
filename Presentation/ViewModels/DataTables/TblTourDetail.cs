using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.ViewModels.DataTables
{
    class TblTourDetail : DataTable
    {
        
        public TblTourDetail()
        {
            this.Create();
        }
        public TblTourDetail(IList<TourDetail> arr, IList<Location> locations)
        {
            
            this.Create();
            this.Fill(arr, locations);
        }

        public void Create()
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("TourId", typeof(int));
            this.Columns.Add("LocationId", typeof(int));
            this.Columns.Add("LocationName", typeof(string));
        }
        public void Fill(IList<TourDetail> arr, IList<Location> locations)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                var locName = locations.Where(m => m.Id.Equals(t.LocationId)).First().Name;
                this.Rows.Add(t.Id, t.TourId, t.LocationId, locName);
            }
        }
    }
}
