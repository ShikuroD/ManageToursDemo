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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITourAnalysisService _tourAnalysisService;

        private IList<Tour> _tours;
        private IList<Tour> _toursForSearch;
        private IList<TourType> _tourTypes;
        private IList<Location> _locations;

        private int _selectedIndex = -1;
        private int _selectedGroupIndex = -1;
        
        private bool viewMode = false;
        private bool _toViewOnly = false;
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
            this.gridViewTour.Columns["StatusName"].Width = 50;

            this.gridViewTour.Columns["TourTypeId"].Visible = false;
            this.gridViewTour.Columns["Status"].Visible = false;  
        }
        private void SetUpGroupGridView()
        {
            this.gridViewGroup.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridViewGroup.Columns["Id"].DisplayIndex = 0;
            this.gridViewGroup.Columns["Id"].HeaderText = "ID";
            this.gridViewGroup.Columns["Id"].Width = 30;

            this.gridViewGroup.Columns["Name"].DisplayIndex = 1;
            this.gridViewGroup.Columns["Name"].HeaderText = "Tên";

            this.gridViewGroup.Columns["Value"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridViewGroup.Columns["Value"].DisplayIndex = 2;
            this.gridViewGroup.Columns["Value"].HeaderText = "Giá";
            this.gridViewGroup.Columns["Value"].Width = 120;
            this.gridViewGroup.Columns["Value"].DefaultCellStyle.Format = "##,#";

            this.gridViewGroup.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridViewGroup.Columns["StartDate"].DisplayIndex = 3;
            this.gridViewGroup.Columns["StartDate"].HeaderText = "Bắt đầu";
            this.gridViewGroup.Columns["StartDate"].Width = 120;
            this.gridViewGroup.Columns["StartDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            this.gridViewGroup.Columns["EndDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridViewGroup.Columns["EndDate"].DisplayIndex = 4;
            this.gridViewGroup.Columns["EndDate"].HeaderText = "Kết thúc";
            this.gridViewGroup.Columns["EndDate"].Width = 120;
            this.gridViewGroup.Columns["EndDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            this.gridViewGroup.Columns["Description"].DisplayIndex = 5;
            this.gridViewGroup.Columns["Description"].HeaderText = "Mô tả";

            this.gridViewGroup.Columns["StatusName"].DisplayIndex = 6;
            this.gridViewGroup.Columns["StatusName"].HeaderText = "Trạng thái";
            this.gridViewGroup.Columns["StatusName"].Width = 50;

            this.gridViewGroup.Columns["Status"].Visible = false;
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
            else
            {
                this.gridViewTour.Rows[selectedIndex].Selected = true;

                this.SetUpGroupGridView();
            }
        }
        private void LoadTourDetailGridView(IList<TourDetail> arr)
        {
            TblSelectClass tblTourDetail = new TblSelectClass(_locations, arr);

            this.gridViewTourDetail.DataSource = tblTourDetail;
            this.gridViewTourDetail.ClearSelection();
            this.SetUpTourDetailGridView();
        }

        private void LoadGroupGridView(IList<AppCore.Models.Group> arr, int selectedIndex = -1)
        {
            var table = new TblGroup(arr);

            this.gridViewGroup.DataSource = table;
            this.SetUpGroupGridView();

            if (selectedIndex < 0)
            {
                this.gridViewGroup.ClearSelection();
                this.EnableGroupButton(false);
            }
            else this.gridViewGroup.Rows[selectedIndex].Selected = true;
        }
        private void EnableTourButton(bool b)
        {
            btnChangeTourStatus.Enabled = b;
            btnDeleteTour.Enabled = b;
            btnEditTourDetail.Enabled = b;

            btnAddGroup.Enabled = b;
            txtPriceFrom.Enabled = b;
            txtPriceTo.Enabled = b;
            dateFrom.Enabled = b;
            dateTo.Enabled = b;
            txtSearchGroup.Enabled = b;
        }
        private void EnableGroupButton(bool b)
        {
            btnDeleteGroup.Enabled = b;
            btnEditGroup.Enabled = b;
            btnChangeStatusGroup.Enabled = b;

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
                    btnChangeTourStatus.Text = "KÍCH HOẠT";
                    this.EnableTourButton(true);
                }

                var tourId = (Int32)row.Cells["Id"].Value;
                var dets = _unitOfWork.Tours.GetTourDetailsByTourId(tourId);
                this.LoadTourDetailGridView(dets);
                var groups = _unitOfWork.Tours.GetGroupsByTourId(tourId);
                this.LoadGroupGridView(groups);
                this.SetUpGroupGridView();
            }
            else
            {
                this.gridViewTourDetail.DataSource = null;
                this.EnableTourButton(false);
                this.gridViewGroup.DataSource = null;
                this.EnableGroupButton(false);
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
        private IList<AppCore.Models.Group> SearchGroup(IList<AppCore.Models.Group> groups)
        {
            var search = this.txtSearchGroup.Text.Trim();
            var res = groups.ToList().AsQueryable();
            if (!String.IsNullOrEmpty(search))
            {
                res = res.Where(m => m.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            if (txtPriceFrom.BackColor.Equals(Color.OrangeRed) || txtPriceTo.BackColor.Equals(Color.OrangeRed)
                || String.IsNullOrEmpty(txtPriceFrom.Text.Trim()) || String.IsNullOrEmpty(txtPriceTo.Text.Trim())) ;
            //MessageBox.Show("Số nhập không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            else
            {
                var from = decimal.Parse(txtPriceFrom.Text);
                var to = decimal.Parse(txtPriceTo.Text);
                res = res.Where(m => decimal.Compare(m.Price, from) >= 0 && decimal.Compare(m.Price, to) <= 0);
            }
            var dateX = dateFrom.Value.Date;
            var dateY = dateTo.Value.Date;
            res = res.Where(m => DateTime.Compare(m.StartDate,dateX) >= 0 && DateTime.Compare(m.StartDate, dateY) <= 0);

            return res.ToList();
        }
        public MainForm(IUnitOfWork unitOfWork, ITourAnalysisService tourAnalysisService)
        {
            _unitOfWork = unitOfWork;
            _tourAnalysisService = tourAnalysisService;
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
            dateTo.MinDate = dateFrom.Value.Date; 

        }


        private void btnEditTour_Click(object sender, EventArgs e)
        {
            var tour = _tours.Where(m => m.Id.Equals(Int32.Parse(gridViewTour.SelectedRows[0].Cells[0].Value.ToString()))).First();
            using (var dialog = new TourDetailDialog(_unitOfWork, tour, _locations, _tourTypes))
            {
                var check = dialog.ShowDialog();

                if (check.Equals(DialogResult.OK))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTours();
                    SearchTour();
                    LoadTourGridView(_selectedIndex);
                }
                dialog.Dispose();
            }
                
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            var dialog = new TourDetailDialog(_unitOfWork, null, _locations, _tourTypes);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTours();
                SearchTour();
                LoadTourGridView(_selectedIndex);
            }
            dialog.Dispose();
        }
        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Xóa tour này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                var tourId = Int32.Parse(gridViewTour.SelectedRows[0].Cells[0].Value.ToString());
                _unitOfWork.Tours.Delete(_unitOfWork.Tours.GetBy(tourId));
                LoadTours();
                SearchTour();
                LoadTourGridView(_selectedIndex - 1);
            }
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

        

        private void gridViewGroup_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridViewGroup.SelectedRows.Count > 0)
            {
                var row = this.gridViewGroup.SelectedRows[0];
                _selectedGroupIndex = row.Index;
                
                if ((STATUS)row.Cells["Status"].Value == STATUS.AVAILABLE)
                {
                    btnChangeStatusGroup.Text = "ẨN";
                    this.EnableGroupButton(true);
                }
                else
                {
                    btnChangeStatusGroup.Text = "KÍCH HOẠT";
                    this.EnableGroupButton(true);
                }
                if (DateTime.Compare(DateTime.Today, ((DateTime)row.Cells["StartDate"].Value).Date) > 0)
                {
                    _toViewOnly = true;
                }
                else _toViewOnly = false;
            }
            else
            {
                this.EnableGroupButton(false);
                _toViewOnly = false;
            }
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            var tour = _tours.Where(m => m.Id.Equals(Int32.Parse(gridViewTour.SelectedRows[0].Cells[0].Value.ToString()))).First();
            var dialog = new GroupForm(_unitOfWork, _tourAnalysisService, tour, null, false);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var tourId = Int32.Parse(this.gridViewTour.SelectedRows[0].Cells["Id"].Value.ToString());
                var groups = _unitOfWork.Tours.GetGroupsByTourId(tourId);
                this.LoadGroupGridView(groups, _selectedGroupIndex);
            }
            dialog.Dispose();
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            var tour = _tours.Where(m => m.Id.Equals(Int32.Parse(gridViewTour.Rows[_selectedIndex].Cells["Id"].Value.ToString()))).First();
            var group = _unitOfWork.Tours.GetGroup(tour.Id, Int32.Parse(gridViewGroup.Rows[_selectedGroupIndex].Cells["Id"].Value.ToString()));
            var dialog = new GroupForm(_unitOfWork,_tourAnalysisService, tour, group, _toViewOnly);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var tourId = Int32.Parse(this.gridViewTour.SelectedRows[0].Cells["Id"].Value.ToString());
                var groups = _unitOfWork.Tours.GetGroupsByTourId(tourId);
                this.LoadGroupGridView(groups, _selectedGroupIndex);
            }
            dialog.Dispose();
        }

        private void btnChangeStatusGroup_Click(object sender, EventArgs e)
        {
            var toShow = btnChangeStatusGroup.Text.Equals("ẨN") ? false : true;
            DialogResult check;
            if (toShow)
            {
                check = MessageBox.Show("Kích hoạt tour này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else check = MessageBox.Show("Ẩn tour này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                var row = gridViewGroup.Rows[_selectedGroupIndex];
                var tourId = Int32.Parse(gridViewTour.Rows[_selectedIndex].Cells["Id"].Value.ToString());
                var groupId = Int32.Parse(gridViewGroup.Rows[_selectedGroupIndex].Cells["Id"].Value.ToString());
                if (!toShow)
                {
                    _unitOfWork.Tours.DisableGroup(tourId, groupId);
                }
                else
                {
                    _unitOfWork.Tours.ActivateGroup(tourId, groupId);
                }

                var groups = _unitOfWork.Tours.GetGroupsByTourId(tourId);
                this.LoadGroupGridView(groups, _selectedGroupIndex);
            }
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Xóa đoàn khách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                var tourId = Int32.Parse(gridViewTour.SelectedRows[0].Cells[0].Value.ToString());
                var groupId = Int32.Parse(gridViewGroup.SelectedRows[0].Cells[0].Value.ToString());
                _unitOfWork.Tours.DeleteGroup(_unitOfWork.Tours.GetGroup(tourId,groupId));

                var groups = _unitOfWork.Tours.GetGroupsByTourId(tourId);
                this.LoadGroupGridView(groups, _selectedGroupIndex - 1);
            }
        }

        private void txtSearchGroup_TextChanged(object sender, EventArgs e)
        {
            var tourId = Int32.Parse(gridViewTour.SelectedRows[0].Cells[0].Value.ToString());
            var groups = _unitOfWork.Tours.GetGroupsByTourId(tourId);
            this.LoadGroupGridView(groups);
        }

        private void txtPriceFrom_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(@"^[1-9]{1}[0-9]{0,12}$");
            if (regex.IsMatch(txtPriceFrom.Text)) txtPriceFrom.BackColor = Color.White;
            else txtPriceFrom.BackColor = Color.OrangeRed;

        }

        private void txtPriceTo_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(@"^[1-9]{1}[0-9]{0,12}$");
            if (regex.IsMatch(txtPriceTo.Text)) txtPriceTo.BackColor = Color.White;
            else txtPriceTo.BackColor = Color.OrangeRed;

        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateFrom.Value, dateTo.Value) < 0)
            {
                this.dateTo.MinDate = this.dateFrom.Value.Date;
                //this.dateTo.Value = this.dateFrom.Value.Date;
            }
            else
            {
                this.dateTo.Value = this.dateFrom.Value.Date;
                this.dateTo.MinDate = this.dateFrom.Value.Date;
            }
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tourId = Int32.Parse(gridViewTour.SelectedRows[0].Cells[0].Value.ToString());
            var groups = _unitOfWork.Tours.GetGroupsByTourId(tourId);
            groups = this.SearchGroup(groups);
            this.LoadGroupGridView(groups);
        }

        private void setVisibleButtons(bool b)
        {
            btnAddTour.Visible = b;
            btnEditTourDetail.Visible = b;
            btnDeleteTour.Visible = b;
            btnChangeTourStatus.Visible = b;

            btnAddGroup.Visible = b;
            btnEditGroup.Visible = b;
            btnDeleteGroup.Visible = b;
            btnChangeStatusGroup.Visible = b;

            
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (viewMode)
            {
                button.Text = "DANH SÁCH TOUR THEO HIỆN TẠI ";
                viewMode = false;
                LoadTours();
                SearchTour();
                LoadTourGridView();
                setVisibleButtons(true);
            }
            else
            {
                button.Text = "QUAY LẠI";
                viewMode = true;
                setVisibleButtons(false);

            }
        }

        private void btnAnalyzeTour_Click(object sender, EventArgs e)
        {
            var dialog = new TourAnalysis(_unitOfWork, _tourAnalysisService);
            dialog.Dispose();
        }

        private void btnAnalyzeEmployee_Click(object sender, EventArgs e)
        {
            var dialog = new EmployeeAnalysis(_unitOfWork, _tourAnalysisService);
            dialog.Dispose();
        }
    }
}
