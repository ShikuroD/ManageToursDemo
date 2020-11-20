using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using AppCore.Services;
using Presentation.ViewModels.DataTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class TourAnalysis : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITourAnalysisService _service;

        private IList<Tour> _tours;
        private IList<Tour> _toursForSearch;
        private IList<TourType> _tourTypes;

        private int _selectedIndex = -1;

        private void LoadTours()
        {
            _tours = _unitOfWork.Tours.GetAll();
            foreach(Tour t in _tours)
            {
                t.Groups = _unitOfWork.Tours.GetGroupsByTourId(t.Id);
                _service.AnalyzeGroups(t.Groups);
                _service.AnalyzeTour(t);
            }
        }
        private void AnalyzeTourForSearch()
        {
            
            foreach (Tour t in _toursForSearch)
            {
                _service.AnalyzeGroups(t.Groups);
                _service.AnalyzeTour(t);
            }
        }

        private void SetUpTourGridView()
        {
            this.gridTour.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridTour.Columns["Id"].DisplayIndex = 0;
            this.gridTour.Columns["Id"].HeaderText = "ID";
            this.gridTour.Columns["Id"].Width = 60;

            this.gridTour.Columns["Name"].DisplayIndex = 1;
            this.gridTour.Columns["Name"].HeaderText = "Tên";

            this.gridTour.Columns["TourTypeName"].DisplayIndex = 2;
            this.gridTour.Columns["TourTypeName"].HeaderText = "Loại";


            this.gridTour.Columns["Description"].DisplayIndex = 3;
            this.gridTour.Columns["Description"].HeaderText = "Mô tả";

            this.gridTour.Columns["StatusName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridTour.Columns["StatusName"].DisplayIndex = 4;
            this.gridTour.Columns["StatusName"].HeaderText = "Trạng thái";
            this.gridTour.Columns["StatusName"].Width = 150;

            this.gridTour.Columns["TourTypeId"].Visible = false;
            this.gridTour.Columns["Status"].Visible = false;
        }
        private void SetUpGroupGridView()
        {
            this.gridGroup.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["Id"].DisplayIndex = 0;
            this.gridGroup.Columns["Id"].HeaderText = "ID";
            this.gridGroup.Columns["Id"].Width = 60;

            this.gridGroup.Columns["Name"].DisplayIndex = 1;
            this.gridGroup.Columns["Name"].HeaderText = "Tên";

            this.gridGroup.Columns["Value"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["Value"].DisplayIndex = 2;
            this.gridGroup.Columns["Value"].HeaderText = "Giá";
            this.gridGroup.Columns["Value"].Width = 90;
            this.gridGroup.Columns["Value"].DefaultCellStyle.Format = "##,#";

            this.gridGroup.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["StartDate"].DisplayIndex = 3;
            this.gridGroup.Columns["StartDate"].HeaderText = "Bắt đầu";
            this.gridGroup.Columns["StartDate"].Width = 100;
            this.gridGroup.Columns["StartDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            this.gridGroup.Columns["EndDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["EndDate"].DisplayIndex = 4;
            this.gridGroup.Columns["EndDate"].HeaderText = "Kết thúc";
            this.gridGroup.Columns["EndDate"].Width = 100;
            this.gridGroup.Columns["EndDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            this.gridGroup.Columns["Description"].DisplayIndex = 5;
            this.gridGroup.Columns["Description"].HeaderText = "Mô tả";

            this.gridGroup.Columns["StatusName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["StatusName"].DisplayIndex = 6;
            this.gridGroup.Columns["StatusName"].HeaderText = "Giá";
            this.gridGroup.Columns["StatusName"].Width = 100;

            this.gridGroup.Columns["GroupDetailCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["GroupDetailCount"].DisplayIndex = 7;
            this.gridGroup.Columns["GroupDetailCount"].HeaderText = "Số khách";
            this.gridGroup.Columns["GroupDetailCount"].Width = 70;
            this.gridGroup.Columns["GroupDetailCount"].DefaultCellStyle.Format = "##,#";

            this.gridGroup.Columns["AttendantCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["AttendantCount"].DisplayIndex = 8;
            this.gridGroup.Columns["AttendantCount"].HeaderText = "số nhân viên";
            this.gridGroup.Columns["AttendantCount"].Width = 70;
            this.gridGroup.Columns["AttendantCount"].DefaultCellStyle.Format = "##,#";

            this.gridGroup.Columns["PriceSum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["PriceSum"].DisplayIndex = 9;
            this.gridGroup.Columns["PriceSum"].HeaderText = "Tổng thu";
            this.gridGroup.Columns["PriceSum"].Width = 90;
            this.gridGroup.Columns["PriceSum"].DefaultCellStyle.Format = "##,#";

            this.gridGroup.Columns["CostSum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["CostSum"].DisplayIndex = 10;
            this.gridGroup.Columns["CostSum"].HeaderText = "Chi phí";
            this.gridGroup.Columns["CostSum"].Width = 90;
            this.gridGroup.Columns["CostSum"].DefaultCellStyle.Format = "##,#";

            this.gridGroup.Columns["Revenue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridGroup.Columns["Revenue"].DisplayIndex = 11;
            this.gridGroup.Columns["Revenue"].HeaderText = "Lãi";
            this.gridGroup.Columns["Revenue"].Width = 90;
            this.gridGroup.Columns["Revenue"].DefaultCellStyle.Format = "##,#";

            this.gridGroup.Columns["Status"].Visible = false;
        }
        private void LoadTourGridView(int selectedIndex = -1)
        {
            TblTourManage tblTour = new TblTourManage(_toursForSearch, _tourTypes);

            this.gridTour.DataSource = tblTour;
            if (selectedIndex < 0)
            {
                this.gridTour.ClearSelection();
            }
            else
            {
                this.gridTour.Rows[selectedIndex].Selected = true;
                this.SetUpGroupGridView();

            }
            
        }
        private void LoadGroupGridView(IList<Group> arr, int selectedIndex = -1)
        {
            var table = new TblGroup(arr, true);

            this.gridGroup.DataSource = table;
            this.SetUpGroupGridView();

            if (selectedIndex < 0)
            {
                this.gridGroup.ClearSelection();
            }
            else this.gridGroup.Rows[selectedIndex].Selected = true;
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
        private void LoadComboStatus(ComboBox combo)
        {
            Dictionary<STATUS, string> comboSrc = new Dictionary<STATUS, string>();
            comboSrc.Add(STATUS.ALL, "Tất cả");
            comboSrc.Add(STATUS.AVAILABLE, "Hiện");
            comboSrc.Add(STATUS.DISABLED, "Ẩn");

            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
            combo.DataSource = new BindingSource(comboSrc, null);
        }
        private void SearchTour()
        {
            var search = this.txtSearchTour.Text.Trim();
            var type = this.comboTourType.SelectedIndex;
            var res = _tours.Select(m => m.Clone()).ToList().AsQueryable();
            if (type > 0)
            {
                res = res.Where(m => m.TourTypeId == type);
            }
            if (!String.IsNullOrEmpty(search))
            {
                res = res.Where(m => m.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            var tourStatus = ((KeyValuePair<STATUS, string>)comboTourStatus.SelectedItem).Key;
            if (!tourStatus.Equals(STATUS.ALL))
            {
                res = res.Where(m => m.Status.Equals(tourStatus));
            }
            var groupStatus = ((KeyValuePair<STATUS, string>)comboGroupStatus.SelectedItem).Key;
            var from = dateFrom.Value.Date;
            var to = dateTo.Value.Date;
            _toursForSearch = res.ToList();
            
            if (!groupStatus.Equals(STATUS.ALL))
            {
                foreach(Tour t in _toursForSearch)
                {
                    t.Groups = t.Groups.ToList().Where(m => m.Status.Equals(groupStatus) && DateTime.Compare(m.StartDate, from) >= 0 && DateTime.Compare(m.StartDate, to) <= 0).ToList();
                    
                }
            }
            else
            {
                foreach (Tour t in _toursForSearch)
                {
                    t.Groups = t.Groups.ToList().Where(m => DateTime.Compare(m.StartDate, from) >= 0 && DateTime.Compare(m.StartDate, to) <= 0).ToList();
                }
            }
            

            AnalyzeTourForSearch();
        }
        public TourAnalysis(IUnitOfWork unitOfWork, ITourAnalysisService service)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _service = service;

            this._tours = _unitOfWork.Tours.GetAll();
            this._toursForSearch = _tours.ToList();
            this._tourTypes = _unitOfWork.TourTypes.GetAll();
            this.LoadComboTourType();
            this.LoadComboStatus(this.comboTourStatus);
            this.LoadComboStatus(this.comboGroupStatus);
            LoadTours();

            this.LoadTourGridView();


            this.SetUpTourGridView();
            dateTo.MinDate = dateFrom.Value.Date;

            this.ShowDialog();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTour();
            LoadTourGridView();
        }

        private void comboTourType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridTour_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var index = e.RowIndex;
            var cell = gridTour.Rows[index].Cells["StatusName"];
            if (cell.Value.ToString().Equals("O")) cell.Style.BackColor = Color.Green;
            else cell.Style.BackColor = Color.Red;
        }

        private void gridGroup_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var index = e.RowIndex;
            var cell = gridGroup.Rows[index].Cells["StatusName"];
            if (cell.Value.ToString().Equals("O")) cell.Style.BackColor = Color.Green;
            else cell.Style.BackColor = Color.Red;
        }

        private void LoadTourInfo(Tour tour)
        {
            txtCountGroup.Text = tour.Groups == null ? "0" : tour.Groups.Count.ToString();
            txtSumPrice.Text = tour.SumPrice.ToString("N");
            txtSumCost.Text = tour.SumCost.ToString("N");
            txtSumRevenue.Text = tour.SumRevenue.ToString("N");
        }
        private void LoadTourSubInfo(Tour tour)
        {
            txtCountGroupByCons.Text = tour.Groups == null ? "0" : tour.Groups.Count.ToString();
            txtSumPriceByCons.Text = tour.SumPrice.ToString("N");
            txtSumCostByCons.Text = tour.SumCost.ToString("N");
            txtSumRevenueByCons.Text = tour.SumRevenue.ToString("N");
        }
        private void ClearTourInfo()
        {
            txtCountGroup.Text = "";
            txtSumPrice.Text = "";
            txtSumCost.Text = "";
            txtSumRevenue.Text = "";

            txtCountGroupByCons.Text = "";
            txtSumPriceByCons.Text = "";
            txtSumCostByCons.Text = "";
            txtSumRevenueByCons.Text = "";
        }
        private void gridTour_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridTour.SelectedRows.Count > 0)
            {
                var row = this.gridTour.SelectedRows[0];
                _selectedIndex = row.Index;
                var tourId = (Int32)row.Cells["Id"].Value;

                var tour = _tours.Where(m => m.Id.Equals(tourId)).First();
                var tourSub = _toursForSearch.Where(m => m.Id.Equals(tourId)).First();
                this.LoadGroupGridView(tourSub.Groups);
                this.LoadTourInfo(tour);
                this.LoadTourSubInfo(tourSub);
                this.SetUpGroupGridView();
            }
            else
            {
                ClearTourInfo();
                this.gridGroup.DataSource = null;
               
            }
        }
    }
}
