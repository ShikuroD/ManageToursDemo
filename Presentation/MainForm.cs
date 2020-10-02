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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private readonly IVMTourService _tourService;
        private readonly ITourTypeService _tempTours;

        public TourTabVM TourTabVM { get; set; }
        public MainForm(IVMTourService tours, ITourTypeService tempTours)
        {
            _tourService = tours;
            _tempTours = tempTours;

            //TourVM = _tourService.LoadTourVMData();
            InitializeComponent();
        }
        private void LoadLocationListView()
        {
            this.listLocation.Items.Clear();
            foreach (var loc in this.TourTabVM.Locations)
            {
                ListViewItem item = new ListViewItem(loc.Id.ToString());
                item.SubItems.Add(loc.Name);
                item.SubItems.Add(loc.Status.ToString());

                this.listLocation.Items.Add(item);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab == this.tabTours)
            {
                this.TourTabVM = _tourService.LoadTourTabData();
                this.LoadLocationListView();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TourTabVM = _tourService.LoadTourTabData();
            this.LoadLocationListView();
        }

        private void listLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdateLocation.Enabled = true;
            btnDeleteLocation.Enabled = true;
        }

        private void listLocation_Leave(object sender, EventArgs e)
        {
            btnUpdateLocation.Enabled = false;
            btnDeleteLocation.Enabled = false;
        }
    }
}
