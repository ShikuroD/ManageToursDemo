using AppCore;
using AppCore.Models;
using Presentation.ViewModels.DataTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.ViewModels
{
    public class ComboSelectClass<T> : ComboBox where T : SelectClass
    {
        private IList<SelectClass> arr;

        public ComboSelectClass(IList<T> inp, bool forSearch = false)
        {
            var typeClass = typeof(T);
            if (typeClass == typeof(TourType)) MessageBox.Show("comboTourType");
            if (typeClass == typeof(CostType)) MessageBox.Show("comboCostType");
            if (typeClass == typeof(Job)) MessageBox.Show("comboJob");

            arr = inp.Cast<SelectClass>().ToList();
            if (forSearch)
                arr.Add(new SelectClass
                {
                    Id = 0,
                    Name = "Tất cả",
                    Status = STATUS.AVAILABLE
                });
            this.DataSource = new TblSelectClass(arr.OrderBy(m => m.Id).ToList());
            this.DisplayMember = "Name";
        }
    }
}
