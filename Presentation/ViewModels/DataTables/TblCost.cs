using AppCore;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.ViewModels.DataTables
{
    class TblCost : DataTable
    {
        public TblCost()
        {
            this.Create();
        }
        public TblCost(IList<Cost> arr, IList<CostType> types)
        {
            this.Create();
            this.Fill(arr, types) ;
        }

        public void Create()
        {
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("Name", typeof(string));
            this.Columns.Add("Value", typeof(decimal));
            this.Columns.Add("CostTypeId", typeof(int));
            this.Columns.Add("CostTypeName", typeof(string));
            this.Columns.Add("GroupId", typeof(int));
            this.Columns.Add("Description", typeof(string));
        }
        public void Fill(IList<Cost> arr, IList<CostType> types)
        {
            if (arr == null) return;
            foreach (var t in arr)
            {
                var typeName = types.Where(m => m.Id.Equals(t.CostTypeId)).First().Name;
                this.Rows.Add(t.Id, t.Name, t.Value, t.CostTypeId, typeName, t.GroupId, t.Description);
            }
        }

    }
}
