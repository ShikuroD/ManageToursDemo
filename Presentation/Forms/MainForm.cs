using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using AppCore.Services;
using Microsoft.Extensions.Logging;
using Presentation.Forms;
using Presentation.ViewModels;
using Presentation.ViewModels.DataTables;
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
        private readonly IUnitOfWork _unitOfWork;

        private IList<Tour> _tours;
        private IList<Tour> _toursForSearch;
        private IList<TourType> _tourTypes;
        private IList<Location> _locations;

        private int _selectedIndex = -1;
        private int _selectedGroupIndex = -1;
        
        private void LoadTours()
        {
            _tours = _unitOfWork.Tours.GetAll();
        }
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
        private void LoadTourGridView(int selectedIndex = -1)
        {
            TblTourManage tblTour = new TblTourManage(_toursForSearch, _tourTypes);
            
            this.gridViewTour.DataSource = tblTour;
            if (selectedIndex < 0)
            {
                this.gridViewTour.ClearSelection();
                this.EnableTourButton(false);
            }
            else this.gridViewTour.Rows[selectedIndex].Selected = true;
        }
        private void LoadTourDetailGridView(IList<TourDetail> arr)
        {
            TblSelectClass tblTourDetail = new TblSelectClass(_locations, arr);

            this.gridViewTourDetail.DataSource = tblTourDetail;
            this.gridViewTourDetail.ClearSelection();
            this.SetUpTourDetailGridView();
        }
        private void EnableTourButton(bool b)
        {
            btnChangeTourStatus.Enabled = b;
            btnDeleteTour.Enabled = b;
            btnEditTourDetail.Enabled = b;

            btnAddGroup.Enabled = b;
        }
        private void LoadTourInfo()
        {
            if(this.gridViewTour.SelectedRows.Count > 0)
            {
                var row = this.gridViewTour.SelectedRows[0];
                _selectedIndex = row.Index;
                
                if( (STATUS)row.Cells["Status"].Value == STATUS.AVAILABLE)
                {
                    btnChangeTourStatus.Text = "ẨN";
                    this.EnableTourButton(true);
                }
                else
                {
                    btnChangeTourStatus.Text = "HIỆN";
                    this.EnableTourButton(true);
                }

                var dets = _unitOfWork.Tours.GetTourDetailsByTourId((Int32)row.Cells["Id"].Value);
                this.LoadTourDetailGridView(dets);
            }
            else
            {
                this.gridViewTourDetail.DataSource = null;
                this.EnableTourButton(false);
            }
        }
        private void LoadComboTourType()
        {
            IList<SelectClass> arr = _tourTypes.Cast<SelectClass>().ToList();
            arr.Add(new SelectClass
            {
                Id = 0,
                Name = "Tất cả",
                Status = STATUS.AVAILABLE
            });
            comboTourType.Items.Clear();
            comboTourType.DataSource = new TblSelectClass(arr.OrderBy(m => m.Id).ToList());
            comboTourType.DisplayMember = "Name";
            comboTourType.ValueMember = "Id"; 
        }
        private void SearchTour()
        {
            var search = this.txtTourSearch.Text.Trim();
            var type = this.comboTourType.SelectedIndex;
            var res = _tours.ToList().AsQueryable();
            if (type > 0)
            {
                res = res.Where(m => m.TourTypeId == type);
            }
            if (!String.IsNullOrEmpty(search))
            {
                res = res.Where(m => m.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            _toursForSearch = res.ToList();
        }
        public MainForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this._tours = _unitOfWork.Tours.GetAll();
            this._toursForSearch = _tours.ToList();
            this._tourTypes = _unitOfWork.TourTypes.GetAll();
            this._locations = _unitOfWork.Locations.GetAll();

            this.LoadComboTourType();
            this.LoadTourGridView();

            
            this.SetUpTourGridView();

        }


        private void btnEditTour_Click(object sender, EventArgs e)
        {
            var tour = _tours.Where(m => m.Id.Equals(Int32.Parse(gridViewTour.SelectedRows[0].Cells[0].Value.ToString()))).First();
            var dialog = new TourDetailDialog(_unitOfWork, tour, _locations, _tourTypes);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                tour = dialog.returnTour();
                _unitOfWork.Tours.Update(tour);
                var routeArr = dialog.returnRoutes();
                foreach(TourDetail t in routeArr)
                {
                    t.TourId = tour.Id;
                }
                _unitOfWork.Tours.UpdateTourDetails(routeArr);

                var priceArr = dialog.returnPrices();
                foreach (Price p in priceArr)
                {
                    var temp = _unitOfWork.Tours.GetPrice(tour.Id, p.Id);
                    if (temp != null) _unitOfWork.Tours.DeletePrice(tour.Id, temp);
                    p.TourId = tour.Id;
                    _unitOfWork.Tours.AddPrice(tour.Id, p);
                }

                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTours();
                SearchTour();
                LoadTourGridView(_selectedIndex);
            }
            dialog.Dispose();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            var dialog = new TourDetailDialog(_unitOfWork, null, _locations, _tourTypes);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                var tour = dialog.returnTour();
                tour = _unitOfWork.Tours.Add(tour);
                var routeArr = dialog.returnRoutes();
                foreach (TourDetail t in routeArr)
                {
                    t.TourId = tour.Id;
                }
                _unitOfWork.Tours.UpdateTourDetails(routeArr);

                var priceArr = dialog.returnPrices();
                foreach (Price p in priceArr)
                {
                    var temp = _unitOfWork.Tours.GetPrice(tour.Id, p.Id);
                    if (temp != null) _unitOfWork.Tours.DeletePrice(tour.Id, temp);
                    p.TourId = tour.Id;
                    _unitOfWork.Tours.AddPrice(tour.Id, p);
                }

                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTours();
                SearchTour();
                LoadTourGridView(_selectedIndex);
            }
            dialog.Dispose();
        }
        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            var tourId = gridViewTour.SelectedRows[0].Cells[0].Value.ToString();
            var tourName = gridViewTour.SelectedRows[0].Cells[1].Value.ToString();
            var res = MessageBox.Show("Xóa tour\nId: " + tourId + "\nTên: " + tourName + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes) MessageBox.Show("yes please");
            else MessageBox.Show("no lol");
        }
        private void btnChangeTourStatus_Click(object sender, EventArgs e)
        {
            var toShow = btnChangeTourStatus.Text.Equals("ẨN") ? false : true;
            DialogResult check;
            if (toShow)
            {
                check = MessageBox.Show("Kích hoạt tour này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else check = MessageBox.Show("Ẩn tour này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                var row = gridViewTour.Rows[_selectedIndex];
                var tour = _unitOfWork.Tours.GetBy(Int32.Parse(row.Cells[0].Value.ToString()));

                if (!toShow)
                {
                    _unitOfWork.Tours.Disable(tour);
                }
                else
                {
                    _unitOfWork.Tours.Activate(tour);
                }

                this._tours = _unitOfWork.Tours.GetAll();
                this.SearchTour();
                this.LoadTourGridView(_selectedIndex);
                this.LoadTourInfo();
            }
            
        }
        private void gridViewTour_SelectionChanged(object sender, EventArgs e)
        {
            this.LoadTourInfo();
        }


        private void btnTourSearch_Click(object sender, EventArgs e)
        {
            SearchTour();
            LoadTourGridView();
        }

        private void btnManageLocation_Click(object sender, EventArgs e)
        {
            GenericForm<Location> dialog = new GenericForm<Location>(_unitOfWork);
            _locations = _unitOfWork.Locations.GetAll();
        }

        private void btnManageTourType_Click(object sender, EventArgs e)
        {
            GenericForm<TourType> dialog = new GenericForm<TourType>(_unitOfWork);
            _tourTypes = _unitOfWork.TourTypes.GetAll();
            LoadComboTourType();
        }

        private void btnManageCostType_Click(object sender, EventArgs e)
        {
            GenericForm<CostType> dialog = new GenericForm<CostType>(_unitOfWork);
        }

        private void btnManageJob_Click(object sender, EventArgs e)
        {
            GenericForm<Job> dialog = new GenericForm<Job>(_unitOfWork);
        }

        private void txtTourSearch_TextChanged(object sender, EventArgs e)
        {
            SearchTour();
            LoadTourGridView();
        }

        private void comboTourType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTour();
            LoadTourGridView();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            PersonForm<Employee> dialog = new PersonForm<Employee>(_unitOfWork);
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            PersonForm<Customer> dialog = new PersonForm<Customer>(_unitOfWork);
        }

        private void gridViewTour_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var index = e.RowIndex;
            var cell = gridViewTour.Rows[index].Cells["StatusName"];
            if (cell.Value.ToString().Equals("O")) cell.Style.BackColor = Color.Green;
            else cell.Style.BackColor = Color.Red;
        }

        private void gridViewGroup_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var index = e.RowIndex;
            var cell = gridViewGroup.Rows[index].Cells["StatusName"];
            if (cell.Value.ToString().Equals("O")) cell.Style.BackColor = Color.Green;
            else cell.Style.BackColor = Color.Red;
        }
    }
}
