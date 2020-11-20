using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
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
    public partial class TourDetailDialog : Form
    {
        private IList<TourType> _tourTypes;
        private IList<Location> _locations;
        private IList<Location> _locationsAvailable;

        private IList<Price> _prices;
        private int _nextPriceId;
        private IList<Price> _priceModified = new List<Price>();

        private IList<TourDetail> _routes;
        private int _routeOrder;

        private IUnitOfWork _unitOfWork;
        private Tour _tour;

        private int _selectedIndex = -1;
        private string title;
        private string confirmMsg;
        private bool _toBeEdited = false;

        private void hideId()
        {
            this.lbId.Visible = false; this.txtId.Visible = false;
        }
        private void LoadComboTourType()
        {
            IList<SelectClass> arr = _tourTypes.Cast<SelectClass>().ToList();
            comboTourType.Items.Clear();
            comboTourType.DataSource = new TblSelectClass(arr);
            comboTourType.DisplayMember = "Name";
            comboTourType.ValueMember = "Id";
        }
        private void LoadRoutes()
        {
            var table = new TblTourDetail(_routes, _locations);
            this.listRoute.DataSource = table;
            this.listRoute.DisplayMember = "LocationName";
            this.listRoute.ValueMember = "LocationId";
            this.listRoute.ClearSelected();
        }
        private void LoadLocations()
        {
            var table = new TblSelectClass(_locationsAvailable.Cast<SelectClass>().ToList(), true);
            this.listLocation.DataSource = table;
            this.listLocation.DisplayMember = "Name";
            this.listLocation.ValueMember = "Id";
            this.listLocation.SelectedIndex = 0;
        }
        private void LoadInfo()
        {
            if (_tour == null) return;
            txtId.Text = _tour.Id.ToString();
            txtName.Text = _tour.Name;
            txtDescription.Text = _tour.Description;
            comboTourType.SelectedValue = _tour.TourTypeId;
        }
        private void LoadPrices(int selectedIndex = -1)
        {
            _prices = _prices.OrderBy(m => m.Id).ToList();
            var table = new TblPrice(_prices);
            this.gridPrice.DataSource = table;
            if (selectedIndex < 0) this.gridPrice.ClearSelection();
            else this.gridPrice.Rows[selectedIndex].Selected = true;
        }
        private void SetUpGridPrice()
        {
            this.gridPrice.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPrice.Columns["Id"].DisplayIndex = 0;
            this.gridPrice.Columns["Id"].HeaderText = "ID";
            this.gridPrice.Columns["Id"].Width = 30;

            this.gridPrice.Columns["Name"].DisplayIndex = 1;
            this.gridPrice.Columns["Name"].HeaderText = "Tên";

            this.gridPrice.Columns["Value"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPrice.Columns["Value"].DisplayIndex = 2;
            this.gridPrice.Columns["Value"].HeaderText = "Giá";
            this.gridPrice.Columns["Value"].Width = 120;
            this.gridPrice.Columns["Value"].DefaultCellStyle.Format = "##,#";

            this.gridPrice.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPrice.Columns["StartDate"].DisplayIndex = 3;
            this.gridPrice.Columns["StartDate"].HeaderText = "Bắt đầu";
            this.gridPrice.Columns["StartDate"].Width = 120;
            this.gridPrice.Columns["StartDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            this.gridPrice.Columns["EndDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPrice.Columns["EndDate"].DisplayIndex = 4;
            this.gridPrice.Columns["EndDate"].HeaderText = "Kết thúc";
            this.gridPrice.Columns["EndDate"].Width = 120;
            this.gridPrice.Columns["EndDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            this.gridPrice.Columns["StatusName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPrice.Columns["StatusName"].DisplayIndex = 5;
            this.gridPrice.Columns["StatusName"].HeaderText = "Trạng thái";
            this.gridPrice.Columns["StatusName"].Width = 50;

            this.gridPrice.Columns["Status"].Visible = false;
        }
        private void LoadSelectedPrice()
        {
            if (this.gridPrice.SelectedRows.Count > 0)
            {
                var row = this.gridPrice.SelectedRows[0];
                _selectedIndex = row.Index;
                if ((STATUS)row.Cells["Status"].Value == STATUS.AVAILABLE)
                {
                    btnChangePriceStatus.Text = "ẨN";
                    this.EnableButton(true);
                }
                else
                {
                    btnChangePriceStatus.Text = "KÍCH HOẠT";
                    this.EnableButton(true);
                }
            }
            else
            {
                this.EnableButton(false);
            }
        }
        private void EnableButton(bool b)
        {
            btnEditPrice.Enabled = b;
            btnChangePriceStatus.Enabled = b;
        }
        public Tour returnTour()
        {

            if (!_toBeEdited) _tour = new Tour();

            _tour.Name = txtName.Text;
            _tour.Description = txtDescription.Text;
            _tour.TourTypeId = (int)comboTourType.SelectedValue;

            return _tour;
        }
        

        public TourDetailDialog(IUnitOfWork unitOfWork, Tour tour, IList<Location> locations, IList<TourType> tourTypes)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            if (tour == null)
            {
                this.hideId();
                title = "Thêm Tour";
                _prices = new List<Price>();
                _routes = new List<TourDetail>(); _routeOrder = 0;
            }
            else
            {
                _toBeEdited = true;
                _tour = tour;
                _prices = _unitOfWork.Tours.GetPricesByTourId(_tour.Id); 
                _routes = _unitOfWork.Tours.GetTourDetailsByTourId(_tour.Id); _routeOrder = _routes.Count;
                title = "Cập nhật tour";
            }
            var count = _unitOfWork.Tours.GetAllPrices().OrderBy(m => m.Id);
            if (count == null || count.Count() == 0) _nextPriceId = 0;
            else _nextPriceId = count.Last().Id;

            confirmMsg = title + " này?";
            _tourTypes = tourTypes;
            _locations = locations;
            _locationsAvailable = _locations.Where(m => m.Status.Equals(STATUS.AVAILABLE)).ToList(); 
            

            this.Text = title;
            LoadComboTourType();
            LoadInfo();
            LoadLocations();
            LoadRoutes();
            LoadPrices();

            this.SetUpGridPrice();

        }

        private void gridPrice_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var index = e.RowIndex;
            var cell = gridPrice.Rows[index].Cells["StatusName"];
            if (cell.Value.ToString().Equals("O")) cell.Style.BackColor = Color.Green;
            else cell.Style.BackColor = Color.Red;
        }

        private void gridPrice_SelectionChanged(object sender, EventArgs e)
        {
            LoadSelectedPrice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Hủy thao tác?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            this.DialogResult = DialogResult.Cancel;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //validating
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Tên tour không được rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            
            if (_routes.Count < 2)
            {
                MessageBox.Show("Lịch trình cần có 2 địa diểm trở lên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (_prices.Count < 1)
            {
                MessageBox.Show("Tour chưa thêm giá vé", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            var check = MessageBox.Show(confirmMsg, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;


            //execute
            _tour = returnTour();
            if (_toBeEdited) _unitOfWork.Tours.Update(_tour);
            else
            {
                _tour = _unitOfWork.Tours.Add(_tour);
            }

            foreach (TourDetail t in _routes)
            {
                t.TourId = _tour.Id;
            }
            _unitOfWork.Tours.UpdateTourDetails(_routes);


            foreach (Price p in _priceModified)
            {
                var temp = _unitOfWork.Tours.GetPrice(_tour.Id, p.Id);
                if (temp != null)
                {
                    temp.Copy(p);
                    _unitOfWork.Tours.UpdatePrice(_tour.Id, temp);
                }
                else
                {
                    temp = new Price(p.Name, _tour.Id, p.Value, p.StartDate, p.EndDate);
                    _unitOfWork.Tours.AddPrice(_tour.Id, temp);
                }
                
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            TourDetail last = _routes.Count == 0?null:_routes.Last();
            var item = (DataRowView)this.listLocation.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Chưa chọn địa điểm muốn thêm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            var temp = new TourDetail(0, Int32.Parse(item["Id"].ToString()), ++_routeOrder);
            if (last != null)
            {
                if (last.LocationId.Equals(temp.LocationId))
                {
                    MessageBox.Show("Địa diểm kế tiếp cần phải khác địa điểm kết thúc hiện tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
            }
            
            _routes.Add(temp);
            LoadRoutes();
        }

        private void btnRemoveRoute_Click(object sender, EventArgs e)
        {
            _routes.RemoveAt(_routes.Count - 1);
            _routeOrder--;
            LoadRoutes();
        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            
            var dialog = new PriceDialog(_unitOfWork, null, _prices, _priceModified, _nextPriceId, _tour==null?"":_tour.Name);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                _nextPriceId++;
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrices();
            }
            dialog.Dispose();
        }

        private void btnEditPrice_Click(object sender, EventArgs e)
        {
            var price = _prices.Where(m => m.Id.Equals(Int32.Parse(gridPrice.SelectedRows[0].Cells[0].Value.ToString()))).First();
            var dialog = new PriceDialog(_unitOfWork, price, _prices, _priceModified, _nextPriceId, _tour == null? "": _tour.Name);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {

                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrices(_selectedIndex);
            }
            dialog.Dispose();
        }

        private void btnChangePriceStatus_Click(object sender, EventArgs e)
        {
            var price = _prices.Where(m => m.Id.Equals(Int32.Parse(gridPrice.SelectedRows[0].Cells[0].Value.ToString()))).First();
            var toShow = btnChangePriceStatus.Text.Equals("ẨN") ? false : true;
            var check = MessageBox.Show(toShow ? "Kích hoạt giá này?" : "Ẩn giá này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (check.Equals(DialogResult.OK))
            {
                var old_id = price.Id;
                _prices.Remove(price);
                _priceModified.Remove(price);
                price.Id = old_id;
                price.Status = toShow ? STATUS.AVAILABLE : STATUS.DISABLED;
                _prices.Add(price);
                _priceModified.Add(price);

                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrices(_selectedIndex);
            }
        }

        private void TourDetailDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
