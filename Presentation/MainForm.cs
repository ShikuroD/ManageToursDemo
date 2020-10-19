using AppCore;
using AppCore.Models;
using AppCore.Services;
using Microsoft.Extensions.Logging;
using Presentation.ViewModels;
using Presentation.VMServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private readonly IVMTourService _tourService;

        public TourTabVM TourTabVM { get; set; }

        private void UseCellFormat(DataGridView dg)
        {
            dg.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    var column = dg.Columns[e.ColumnIndex];
                    if (column.DataPropertyName == "TourTypeId" && e.Value != null)
                    {
                        e.Value = TourTabVM.TourTypes.Where(m => m.Id.Equals(e.Value)).First().Name;
                        e.FormattingApplied = true;
                    }
                    if (column.DataPropertyName == "Status" && e.Value != null)
                    {
                        string res = "";

                        if (e.Value.Equals(STATUS.AVAILABLE)) res = "OK";
                        else res = "Đã ẩn";

                        e.Value = res;
                        e.FormattingApplied = true;
                    }
                }
            };
        }
        private void SetUpTourGridView()
        {
            this.UseCellFormat(this.gridViewTour);

            this.gridViewTour.Columns["Id"].DisplayIndex = 0;
            this.gridViewTour.Columns["Id"].HeaderText = "ID";
            this.gridViewTour.Columns["Id"].Width = 40;

            this.gridViewTour.Columns["Name"].DisplayIndex = 1;
            this.gridViewTour.Columns["Name"].HeaderText = "Tên";

            this.gridViewTour.Columns["TourTypeId"].DisplayIndex = 2;
            this.gridViewTour.Columns["TourTypeId"].HeaderText = "Loại";

            this.gridViewTour.Columns["Description"].DisplayIndex = 3;
            this.gridViewTour.Columns["Description"].HeaderText = "Mô tả";

            this.gridViewTour.Columns["Status"].HeaderText = "Trạng thái";
            this.gridViewTour.Columns["Status"].Width = 50;


            this.gridViewTour.Columns["Prices"].Visible = false;
            this.gridViewTour.Columns["TourType"].Visible = false;
            this.gridViewTour.Columns["Groups"].Visible = false;
            this.gridViewTour.Columns["TourDetails"].Visible = false;
        }
        private void LoadTourGridView()
        {
            BindingSource src = new BindingSource();
            src.DataSource = typeof(Tour);
            this.gridViewTour.DataSource = src;
            this.SetUpTourGridView();

            foreach (var t in TourTabVM.Tours)
            {
                src.Add(t);
            }

        }
        public MainForm(IVMTourService tours)
        {
            _tourService = tours;

            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TourTabVM = _tourService.LoadTourTabData();
            this.LoadTourGridView();
        }

        private void btnTourDetail_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            ConfirmDialog dlg = new ConfirmDialog();
            var res = dlg.Show("test dialog");

            if (res) MessageBox.Show("yes please");
            else MessageBox.Show("no lol");
        }

        private void gridViewTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
