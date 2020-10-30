using AppCore;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.ViewModels.DataTables
{
    public class TblTourManage : DataTable
    {
        public TblTourManage()
        {
            this.Create();
        }
        public TblTourManage(IList<Tour> tours, IList<TourType> tourTypes)
        {
            this.Create();
            this.Fill(tours, tourTypes);
        }
        public void Create()
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("Name", typeof(string));
            this.Columns.Add("TourTypeId", typeof(int));
            this.Columns.Add("TourTypeName", typeof(string));
            this.Columns.Add("Description", typeof(string));
            this.Columns.Add("Status", typeof(STATUS));
            this.Columns.Add("StatusName", typeof(string));
        }
        public void Fill(IList<Tour> tours, IList<TourType> tourTypes)
        {
            if (tours == null) return;
            foreach (var t in tours)
            {
                var tourTypeName = tourTypes.Where(m => m.Id.Equals(t.TourTypeId)).First().Name;
                var statusName = t.Status == STATUS.AVAILABLE ? "O" : "X";
                this.Rows.Add(t.Id, t.Name, t.TourTypeId, tourTypeName, t.Description, t.Status, statusName);
            }
        }
    }
}
