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

        
        private void LoadTourGridView()
        {
            BindingSource src = new BindingSource();
            src.DataSource = typeof(Tour);
            this.gridViewTour.DataSource = src;

            foreach(var t in TourTabVM.Tours)
            {
                src.Add(t);
            }
            this.gridViewTour.Columns["Id"].HeaderText = "ID";
            this.gridViewTour.Columns["Name"].HeaderText = "Tên";
            this.gridViewTour.Columns["TourTypeId"].HeaderText = "Loại";
            this.gridViewTour.Columns["Description"].HeaderText = "Mô tả";

            this.gridViewTour.Columns["Id"].DisplayIndex = 0;
            this.gridViewTour.Columns["Name"].DisplayIndex = 2;
            this.gridViewTour.Columns["TourTypeId"].DisplayIndex = 1;
            this.gridViewTour.Columns["Description"].DisplayIndex = 3;
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


    }
}
