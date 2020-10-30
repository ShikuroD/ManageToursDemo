﻿using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using AppCore.Services;
using Microsoft.Extensions.Logging;
using Presentation.ViewModels;
using Presentation.ViewModels.DataTables;
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

        private IList<Tour> _tours;
        private IList<TourType> _tourTypes;
        private IList<Location> _locations;
        
        private void SetUpTourGridView()
        {
            
            this.gridViewTour.Columns["Id"].DisplayIndex = 0;
            this.gridViewTour.Columns["Id"].HeaderText = "ID";
            this.gridViewTour.Columns["Id"].Width = 30;

            this.gridViewTour.Columns["Name"].DisplayIndex = 1;
            this.gridViewTour.Columns["Name"].HeaderText = "Tên";

            this.gridViewTour.Columns["TourTypeName"].DisplayIndex = 2;
            this.gridViewTour.Columns["TourTypeName"].HeaderText = "Loại";


            this.gridViewTour.Columns["Description"].DisplayIndex = 3;
            this.gridViewTour.Columns["Description"].HeaderText = "Mô tả";

            this.gridViewTour.Columns["StatusName"].DisplayIndex = 4;
            this.gridViewTour.Columns["StatusName"].HeaderText = "Trạng thái";
            this.gridViewTour.Columns["StatusName"].Width = 30;

            this.gridViewTour.Columns["TourTypeId"].Visible = false;
            this.gridViewTour.Columns["Status"].Visible = false;  
        }
        private void SetUpTourDetailGridView()
        {

            this.gridViewTourDetail.Columns["Id"].DisplayIndex = 0;
            this.gridViewTourDetail.Columns["Id"].HeaderText = "ID";
            this.gridViewTourDetail.Columns["Id"].Width = 30;

            this.gridViewTourDetail.Columns["Name"].DisplayIndex = 1;
            this.gridViewTourDetail.Columns["Name"].HeaderText = "Địa điểm";

        }
        private void LoadTourGridView()
        {
            TblTourManage tblTour = new TblTourManage(_tours, _tourTypes);
            
            this.gridViewTour.DataSource = tblTour;
            //this.SetUpTourGridView();
        }
        private void LoadTourDetailGridView(IList<TourDetail> arr)
        {
            TblSelectClass tblTourDetail = new TblSelectClass(_locations, arr);

            this.gridViewTourDetail.DataSource = tblTourDetail;
            //this.SetUpTourDetailGridView();
        }
        private void EnableButton(bool b)
        {
            btnChangeTourStatus.Enabled = b;
            btnDeleteTour.Enabled = b;
            btnEditTour.Enabled = b;
        }
        private void LoadTourInfo()
        {
            if(this.gridViewTour.SelectedRows.Count > 0)
            {
                var row = this.gridViewTour.SelectedRows[0];

                if( (STATUS)row.Cells["Status"].Value == STATUS.AVAILABLE)
                {
                    btnChangeTourStatus.Text = "ẨN";
                    this.EnableButton(true);
                }
                else
                {
                    btnChangeTourStatus.Text = "HIỆN";
                    this.EnableButton(true);
                }

                var dets = _unitOfWork.Tours.GetTourDetailsByTourId((Int32)row.Cells["Id"].Value);
                this.LoadTourDetailGridView(dets);
            }
        }
        private void LoadComboToutType(IList<TourType> arr)
        {

        }
        public MainForm(IUnitOfWork unitOfWork, IVMTourService tours)
        {
            _unitOfWork = unitOfWork;
            _tourService = tours;

            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this._tours = _unitOfWork.Tours.GetAll();
            this._tourTypes = _unitOfWork.TourTypes.GetAll();
            this._locations = _unitOfWork.Locations.GetAll();

            var combo = _tourTypes.Cast<SelectClass>().ToList();
            this.comboTourType.DataSource = new TblSelectClass(combo);
            this.comboTourType.DisplayMember = "Name";

            var t = this.comboTourType.SelectedItem as TourType;
            

            this.LoadTourGridView();
            this.LoadTourInfo();
        
            this.SetUpTourGridView();
            this.SetUpTourDetailGridView();
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

            this._tours = _unitOfWork.Tours.GetAll();
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

        private void gridViewTour_Leave(object sender, EventArgs e)
        {
            this.EnableButton(false);
        }
    }
}
