using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using AppCore.Services;
using Microsoft.Extensions.Logging;
using Presentation.ViewModels;
using Presentation.VMServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private readonly IVMTourService _tourService;
        private readonly IUnitOfWork _unitOfWork;

        public TourTabVM TourTabVM { get; set; }

        
        
        private void SetUpTourGridView()
        {
            //this.UseCellFormat(this.gridViewTour);

            this.gridViewTour.Columns["Id"].DisplayIndex = 0;
            this.gridViewTour.Columns["Id"].HeaderText = "ID";
            this.gridViewTour.Columns["Id"].Width = 40;

            this.gridViewTour.Columns["Name"].DisplayIndex = 1;
            this.gridViewTour.Columns["Name"].HeaderText = "Tên";

            this.gridViewTour.Columns["TourTypeName"].DisplayIndex = 2;
            this.gridViewTour.Columns["TourTypeName"].HeaderText = "Loại";


            this.gridViewTour.Columns["Description"].DisplayIndex = 3;
            this.gridViewTour.Columns["Description"].HeaderText = "Mô tả";

            this.gridViewTour.Columns["StatusName"].DisplayIndex = 4;
            this.gridViewTour.Columns["StatusName"].HeaderText = "Trạng thái";
            this.gridViewTour.Columns["StatusName"].Width = 50;

            this.gridViewTour.Columns["TourTypeId"].Visible = false;
            this.gridViewTour.Columns["Status"].Visible = false;
            
        }
        private DataTable GetTourTable()
        {
            DataTable tab = new DataTable();
            tab.Columns.Add("ID", typeof(int));
            tab.Columns.Add("Name", typeof(string));
            tab.Columns.Add("TourTypeId", typeof(int));
            tab.Columns.Add("TourTypeName", typeof(string));
            tab.Columns.Add("Description", typeof(string));
            tab.Columns.Add("Status", typeof(STATUS));
            tab.Columns.Add("StatusName", typeof(string));

            return tab;
        }
        private void FillTourTable(DataTable tab)
        {
            foreach (var t in TourTabVM.Tours)
            {
                var tourTypeName = TourTabVM.TourTypes.Where(m => m.Id.Equals(t.TourTypeId)).First().Name;
                var statusName = t.Status == STATUS.AVAILABLE ? "O" : "X";
                tab.Rows.Add(t.Id, t.Name, t.TourTypeId, tourTypeName, t.Description, t.Status, statusName);
            }
        }
        private void LoadTourGridView()
        {
            //BindingSource src = new BindingSource();
            //src.DataSource = typeof(Tour);
            DataTable tab = GetTourTable();
            this.FillTourTable(tab);
            this.gridViewTour.DataSource = tab;
            this.SetUpTourGridView();
        }
        private void EnableButton(bool b)
        {
            btnEditTour.Enabled = b;
            btnManageGroup.Enabled = b;
            btnManagePrice.Enabled = b;
            btnTourDetail.Enabled = b;
        }
        private void LoadTourInfo()
        {
            if(this.gridViewTour.SelectedRows.Count > 0)
            {
                var row = this.gridViewTour.SelectedRows[0];
                this.txtTourId.Text = row.Cells["Id"].Value.ToString();
                this.txtTourName.Text = row.Cells["Name"].Value.ToString();
                this.txtTourType.Text = row.Cells["TourTypeName"].Value.ToString();
                this.txtDescription.Text = row.Cells["Description"].Value.ToString();

                if( (STATUS)row.Cells["Status"].Value == STATUS.AVAILABLE)
                {
                    btnChangeTourStatus.Text = "ẨN";
                    btnChangeTourStatus.Enabled = true;
                    btnDeleteTour.Enabled = true;
                    this.EnableButton(true);
                }
                else
                {
                    btnChangeTourStatus.Text = "HIỆN";
                    btnChangeTourStatus.Enabled = true;
                    btnDeleteTour.Enabled = true;
                    this.EnableButton(false);
                }
            }
            
            
        }
        public MainForm(IUnitOfWork unitOfWork, IVMTourService tours)
        {
            _unitOfWork = unitOfWork;
            _tourService = tours;

            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TourTabVM = _tourService.LoadTourTabData();
            this.LoadTourGridView();
            this.LoadTourInfo();
        }

        private void btnTourDetail_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            //ConfirmDialog dlg = new ConfirmDialog();
            var res = MessageBox.Show("YES or NO?","câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.OK) MessageBox.Show("yes please");
            else MessageBox.Show("no lol");
        }
        private void btnChangeTourStatus_Click(object sender, EventArgs e)
        {
            var index = gridViewTour.SelectedRows[0].Index;
            var row = gridViewTour.SelectedRows[0];
            var tour = _unitOfWork.Tours.GetBy(Int32.Parse(row.Cells[0].Value.ToString()));
            if (btnChangeTourStatus.Text.Equals("ẨN"))
            {
                _unitOfWork.Tours.Disable(tour);
            }
            else
            {
                _unitOfWork.Tours.Activate(tour);
            }
            this.TourTabVM = _tourService.LoadTourTabData();
            this.LoadTourGridView();
            gridViewTour.ClearSelection();
            gridViewTour.Rows[index].Selected = true;
            this.LoadTourInfo();
            
        }

        private void gridViewTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void gridViewTour_Click(object sender, EventArgs e)
        {
            this.LoadTourInfo();
        }

        
    }
}
