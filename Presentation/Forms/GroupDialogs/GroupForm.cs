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
    public partial class GroupForm : Form
    {
        private IList<Attendant> _attendants;
        private IList<GroupDetail> _groupDets;
        private IList<Customer> _customers;
        private IList<Employee> _employees;
        private IList<Customer> _customersAvailable;
        private IList<Employee> _employeesAvailable;
        private IList<Job> _jobs;
        private IList<Job> _jobsAvailable;
        private IList<Cost> _costs;
        private IList<CostType> _costTypes;
        private IList<Price> _prices;

        private IList<Attendant> _attendantsModified = new List<Attendant>();
        private IList<GroupDetail> _groupDetsModified = new List<GroupDetail>();
        private IList<Cost> _costsModified = new List<Cost>();
        private IList<Attendant> _attendantsDeleted = new List<Attendant>();
        private IList<GroupDetail> _groupDetsDeleted = new List<GroupDetail>();
        private IList<Cost> _costsDeleted = new List<Cost>();

        private IUnitOfWork _unitOfWork;
        private ITourAnalysisService _service;
        private Group _model;
        private Tour _tour;

        private int _selectedCostIndex = -1;
        private int _selectedPersonIndex = -1;
        private int _nextAttendantIndex = 0;
        private int _nextGroupDetailIndex = 0;

        private string title;
        private string confirmMsg;
        private bool _toBeEdited = false;
        private bool _forCustomer = true;
        

        private void hideId()
        {
            this.lblId.Visible = false; this.txtId.Visible = false;
        }
        
        private void LoadModel()
        {
            if (!_toBeEdited)
            {
                txtName.Text = _tour.Name; return;
            }

            txtId.Text = _model.Id.ToString();
            txtName.Text = _model.Name;
            txtValue.Text = _model.Price.ToString("#,##0.00");
            dateStart.Value = _model.StartDate.Date;
            dateEnd.Value = _model.EndDate.Date;
        }
        private Group returnModel()
        {
            var res = new Group();
            if (_toBeEdited) res.Id = _model.Id;

            res.Name = txtName.Text;
            res.Price = decimal.Parse(txtValue.Text);
            res.StartDate = dateStart.Value.Date;
            res.EndDate = dateEnd.Value.Date;
            res.TourId = _tour.Id;

            return res;
        }
        private decimal sumCost()
        {
            decimal sum = 0;
            foreach(Cost c in _costs)
            {
                sum += c.Value;
            }
            return sum;
        }
        private void LoadCosts(int selectedIndex = -1)
        {
            _costs = _costs.OrderBy(m => m.Id).ToList();
            var table = new TblCost(_costs, _costTypes);
            this.gridCost.DataSource = table;
            if (selectedIndex < 0) this.gridCost.ClearSelection();
            else this.gridCost.Rows[selectedIndex].Selected = true;

            txtSumCost.Text = sumCost().ToString("#,##0.00");
        }
        private void SetUpGridCost()
        {
            this.gridCost.Columns["CostTypeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridCost.Columns["CostTypeName"].DisplayIndex = 0;
            this.gridCost.Columns["CostTypeName"].HeaderText = "Loại";
            this.gridCost.Columns["CostTypeName"].Width = 120;

            this.gridCost.Columns["Name"].DisplayIndex = 1;
            this.gridCost.Columns["Name"].HeaderText = "Tên";

            this.gridCost.Columns["Value"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridCost.Columns["Value"].DisplayIndex = 2;
            this.gridCost.Columns["Value"].HeaderText = "Giá";
            this.gridCost.Columns["Value"].Width = 120;
            this.gridCost.Columns["Value"].DefaultCellStyle.Format = "##,#";

            
            this.gridCost.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridCost.Columns["Description"].DisplayIndex = 3;
            this.gridCost.Columns["Description"].HeaderText = "Mô tả";
            this.gridCost.Columns["Description"].Width = 180;

            this.gridCost.Columns["Id"].Visible = false;
            this.gridCost.Columns["CostTypeId"].Visible = false;
            this.gridCost.Columns["GroupId"].Visible = false;
        }
        private void LoadSelectedCost()
        {
            if (this.gridCost.SelectedRows.Count > 0)
            {
                var row = this.gridCost.SelectedRows[0];
                _selectedCostIndex = row.Index;
                this.EnableCostButton(true);
            }
            else
            {
                this.EnableCostButton(false);
            }
        }
        private void LoadPersons(bool forCustomer, int selectedIndex = -1)
        {
            _costs = _costs.OrderBy(m => m.Id).ToList();
            if (forCustomer)
            {
                var table = new TblPerson(_groupDets, _customers);
                this.gridPerson.DataSource = table;
                this.SetUpGridGroupDetail();
            }
            else
            {
                var table = new TblPerson(_attendants, _employees, _jobs);
                this.gridPerson.DataSource = table;
                this.SetUpGridAttendant();
            }
            
            if (selectedIndex < 0) this.gridPerson.ClearSelection();
            else this.gridPerson.Rows[selectedIndex].Selected = true;
        }
        private void SetUpGridAttendant()
        {
            this.gridPerson.Columns["EmployeeId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPerson.Columns["EmployeeId"].DisplayIndex = 0;
            this.gridPerson.Columns["EmployeeId"].HeaderText = "ID";
            this.gridPerson.Columns["EmployeeId"].Width = 50;

            this.gridPerson.Columns["Name"].DisplayIndex = 1;
            this.gridPerson.Columns["Name"].HeaderText = "Tên";

            this.gridPerson.Columns["SexName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPerson.Columns["SexName"].DisplayIndex = 2;
            this.gridPerson.Columns["SexName"].HeaderText = "Giới tính";
            this.gridPerson.Columns["SexName"].Width = 100;

            this.gridPerson.Columns["JobName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPerson.Columns["JobName"].DisplayIndex = 3;
            this.gridPerson.Columns["JobName"].HeaderText = "Công việc";
            this.gridPerson.Columns["JobName"].Width = 150;

            this.gridPerson.Columns["Id"].Visible = false;
            this.gridPerson.Columns["Sex"].Visible = false;
            this.gridPerson.Columns["JobId"].Visible = false;
        }
        private void SetUpGridGroupDetail()
        {
            this.gridPerson.Columns["CustomerId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPerson.Columns["CustomerId"].DisplayIndex = 0;
            this.gridPerson.Columns["CustomerId"].HeaderText = "ID";
            this.gridPerson.Columns["CustomerId"].Width = 50;

            this.gridPerson.Columns["Name"].DisplayIndex = 1;
            this.gridPerson.Columns["Name"].HeaderText = "Tên";

            this.gridPerson.Columns["SexName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridPerson.Columns["SexName"].DisplayIndex = 2;
            this.gridPerson.Columns["SexName"].HeaderText = "Giới tính";
            this.gridPerson.Columns["SexName"].Width = 100;

            this.gridPerson.Columns["Id"].Visible = false;
            this.gridPerson.Columns["Sex"].Visible = false;
        }
        private void LoadSelectedPerson()
        {
            if (this.gridPerson.SelectedRows.Count > 0)
            {
                var row = this.gridPerson.SelectedRows[0];
                _selectedPersonIndex = row.Index;
                this.EnablePersonButton(true);
            }
            else
            {
                this.EnablePersonButton(false);
            }
        }
        private void EnableCostButton(bool b)
        {
            btnEditCost.Enabled = b;
            btnDeleteCost.Enabled = b;
        }
        private void EnablePersonButton(bool b)
        {
            btnDeletePerson.Enabled = b;
        }
        
        public GroupForm(IUnitOfWork unitOfWork, ITourAnalysisService service, Tour tour, Group group, bool toView)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _service = service;
            
            _tour = tour;
            _jobs = _unitOfWork.Jobs.GetAll();
            _jobsAvailable = _jobs.Where(m => m.Status.Equals(STATUS.AVAILABLE)).ToList();
            _costTypes = _unitOfWork.CostTypes.GetAll();
            _customers = _unitOfWork.Customers.GetAll();
            _employees = _unitOfWork.Employees.GetAll();
            _prices = _unitOfWork.Tours.GetPricesByTourId(_tour.Id).Where(m => DateTime.Compare(m.EndDate.Date, DateTime.Today) >= 0).OrderBy(m => m.StartDate).ToList();
            _customersAvailable = _customers.Where(m => m.Status.Equals(STATUS.AVAILABLE)).ToList();
            _employeesAvailable = _employees.Where(m => m.Status.Equals(STATUS.AVAILABLE)).ToList();

            if (group == null)
            {
                this.hideId();
                _attendants = new List<Attendant>();
                _groupDets = new List<GroupDetail>();
                _costs = new List<Cost>();
                txtName.Text = _tour.Name;
                title = "Thêm đoàn khách";
            }
            else
            {
                _toBeEdited = true;
                _model = group;
                _attendants = _unitOfWork.Tours.GetAttendantsByGroupId(_model);
                _nextAttendantIndex = _attendants.Any() ? _attendants.Last().Id : 0;
                _groupDets = _unitOfWork.Tours.GetGroupDetailsByGroupId(_model);
                _nextGroupDetailIndex = _groupDets.Any() ? _groupDets.Last().Id : 0;
                _costs = _unitOfWork.Tours.GetCostsByGroupId(_model);
                title = "Cập nhật đoàn khách";
                LoadModel();
            }

            confirmMsg = title + " này?";

            this.Text = title;

            LoadCosts();

            LoadPersons(_forCustomer);

            SetUpGridCost();
            if (_forCustomer) this.SetUpGridGroupDetail(); else this.SetUpGridAttendant();

            
            this.dateStart.MinDate = this.dateStart.Value.Date;
            this.dateEnd.MinDate = this.dateStart.Value.Date;

            if (_model != null && DateTime.Compare(_model.EndDate.Date, DateTime.Today) < 0)
            {
                dateStart.Enabled = false;
                dateEnd.Enabled = false;
            }
            if (toView)
            {
                btnAddCost.Visible = false;
                btnEditCost.Visible = false;
                btnDeleteCost.Visible = false;

                btnOk.Visible = false;
                btnCancel.Visible = false;

                btnAddPerson.Visible = false;
                btnDeletePerson.Visible = false;
                btnShowPrice.Visible = false;
                dateStart.Enabled = false;
                dateEnd.Enabled = false;

                btnOKView.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;
            if (radio.Checked)
            {
                _forCustomer = true;
            }
            else
            {
                _forCustomer = false;
            }
            LoadPersons(_forCustomer);
        }

        private void gridCost_SelectionChanged(object sender, EventArgs e)
        {
            this.LoadSelectedCost();
        }

        private void gridPerson_SelectionChanged(object sender, EventArgs e)
        {
            this.LoadSelectedPerson();
        }

        private void btnShowPrice_Click(object sender, EventArgs e)
        {
            if (_attendants.Count == 0 && _groupDets.Count == 0)
            {
                var dialog = new PriceListDialog(_prices);
                var check = dialog.ShowDialog();
                if (check.Equals(DialogResult.OK))
                {
                    var priceId = dialog.getSelectedPriceId();
                    var price = _prices.Where(m => m.Id.Equals(priceId)).First();
                    txtValue.Text = String.Format("{0:n0}", price.Value);

                    if (DateTime.Compare(price.StartDate, dateStart.Value.Date) < 0)
                    {
                        dateStart.MinDate = price.StartDate.Date;
                        dateStart.MaxDate = price.EndDate.Date;
                        dateEnd.MinDate = price.StartDate.Date;

                        dateStart.Value = price.StartDate.Date;
                        dateEnd.Value = dateStart.Value.Date;
                    }
                    else
                    {
                        dateStart.Value = price.StartDate.Date;
                        dateEnd.Value = dateStart.Value.Date;

                        dateStart.MinDate = this.dateStart.Value.Date;
                        dateEnd.MinDate = this.dateStart.Value.Date;
                        dateStart.MaxDate = price.EndDate.Date;
                    }
                }
                dialog.Dispose();
            }
            else
            {
                MessageBox.Show("Không thể thay đổi giá khi danh sách nhân viên và khách hàng không rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateStart.Value.Date, dateEnd.Value.Date) < 0)
            {
                this.dateEnd.MinDate = this.dateStart.Value.Date;
                //this.dateEnd.Value = this.dateStart.Value.Date;
            }
            else
            {
                this.dateEnd.Value = this.dateStart.Value.Date;
                this.dateEnd.MinDate = this.dateStart.Value.Date;
            }
        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            var dialog = new CostDialog(_unitOfWork, _costs, _costsModified, _costTypes, null);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCosts();
            }
            dialog.Dispose();
        }

        private void btnEditCost_Click(object sender, EventArgs e)
        {
            var cost = _costs.Where(m => m.CostTypeId.Equals(Int32.Parse(gridCost.SelectedRows[0].Cells["CostTypeId"].Value.ToString()))).First();
            var dialog = new CostDialog(_unitOfWork, _costs, _costsModified, _costTypes, cost);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCosts(_selectedCostIndex);
            }
            dialog.Dispose();
        }

        private void btnDeleteCost_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Xóa chi phí này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.OK))
            {
                var cost = _costs.Where(m => m.CostTypeId.Equals(Int32.Parse(gridCost.SelectedRows[0].Cells["CostTypeId"].Value.ToString()))).First();
                _costs.Remove(cost);
                _costsModified.Remove(cost);
                _costsDeleted.Add(cost);
            }

            LoadCosts(_selectedCostIndex - 1);
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
            if (String.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("Giá chưa được chọn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (_costs.Count < 1)
            {
                MessageBox.Show("Đoàn chưa thêm chi phí", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (_groupDets.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (_attendants.Count == 0)
            {
                MessageBox.Show("Danh sách nhân viên rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            var check = MessageBox.Show(confirmMsg, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;


            //execute
            var tempModel = returnModel();
            
            if (_toBeEdited)
            {
                _model.Copy(tempModel);
                _unitOfWork.Tours.UpdateGroup(_model);
            }
            else
            {
                _model = new Group(tempModel);
                _model = _unitOfWork.Tours.AddGroup(_tour.Id, _model);
            }

            if (_toBeEdited)
            {
                // costs
                var tempArr = _unitOfWork.Tours.GetCostsByGroupId(_model);
                foreach (Cost c in _costsDeleted)
                {
                    var res = tempArr.Where(m => m.CostTypeId.Equals(c.CostTypeId));
                    if (res.Any())
                    {
                        _unitOfWork.Tours.DeleteCost(_model, res.First());
                        tempArr.Remove(res.First());
                    }
                }
                foreach (Cost c in _costsModified)
                {
                    var res = tempArr.Where(m => m.CostTypeId.Equals(c.CostTypeId));
                    if (res.Any())
                    {
                        var temp = res.First();
                        temp.Copy(c);
                        _unitOfWork.Tours.UpdateCost(_model, temp);
                    }
                    else
                    {
                        var temp = new Cost(c);
                        temp.GroupId = _model.Id;
                        _unitOfWork.Tours.AddCost(_model, temp);
                    }
                }

                //groupdetail
                var detArr = _unitOfWork.Tours.GetGroupDetailsByGroupId(_model);
                foreach (GroupDetail c in _groupDetsDeleted)
                {
                    var res = detArr.Where(m => m.Id.Equals(c.Id));
                    if (res.Any())
                    {
                        _unitOfWork.Tours.DeleteGroupDetail(_model, res.First());
                        detArr.Remove(res.First());
                    }
                }
                foreach (GroupDetail c in _groupDetsModified)
                {
                    var res = detArr.Where(m => m.Id.Equals(c.Id));
                    if (res.Any())
                    {
                        var temp = res.First();
                        temp.Copy(c);
                        _unitOfWork.Tours.UpdateGroupDetail(_model, temp);
                    }
                    else
                    {
                        var temp = new GroupDetail(c);
                        temp.GroupId = _model.Id;
                        _unitOfWork.Tours.AddGroupDetail(_model, temp);
                    }
                }

                //attendants
                var attArr = _unitOfWork.Tours.GetAttendantsByGroupId(_model);
                foreach (Attendant c in _attendantsDeleted)
                {
                    var res = attArr.Where(m => m.Id.Equals(c.Id));
                    if (res.Any())
                    {
                        _unitOfWork.Tours.DeleteAttendant(_model, res.First());
                        attArr.Remove(res.First());
                    }
                }
                foreach (Attendant c in _attendantsModified)
                {
                    var res = attArr.Where(m => m.Id.Equals(c.Id));
                    if (res.Any())
                    {
                        var temp = res.First();
                        temp.Copy(c);
                        _unitOfWork.Tours.UpdateAttendant(_model, temp);
                    }
                    else
                    {
                        var temp = new Attendant(c);
                        temp.GroupId = _model.Id;
                        _unitOfWork.Tours.AddAttendant(_model, temp);
                    }
                }
            }
            else
            {
                foreach (Cost c in _costsModified)
                {
                    var temp = new Cost(c);
                    temp.GroupId = _model.Id;
                    _unitOfWork.Tours.AddCost(_model, temp);
                }

                foreach (GroupDetail c in _groupDetsModified)
                {
                    var temp = new GroupDetail(c);
                    temp.GroupId = _model.Id;
                    _unitOfWork.Tours.AddGroupDetail(_model, temp);
                }
                foreach (Attendant c in _attendantsModified)
                {
                    var temp = new Attendant(c);
                    temp.GroupId = _model.Id;
                    _unitOfWork.Tours.AddAttendant(_model, temp);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            SelectPersonDialog dialog;
            if (_forCustomer)
            {

                dialog = new SelectPersonDialog(_unitOfWork, _service, dateStart.Value.Date, dateEnd.Value.Date,
                    _customersAvailable, _groupDets, _groupDetsModified, _nextGroupDetailIndex);
                _nextGroupDetailIndex++;
            }
            else
            {
                dialog = new SelectPersonDialog(_unitOfWork, _service, dateStart.Value.Date, dateEnd.Value.Date, 
                    _employeesAvailable, _attendants, _attendantsModified, _nextAttendantIndex, _jobsAvailable);
                _nextAttendantIndex++;
            }
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPersons(_forCustomer, _selectedPersonIndex);
            }
            dialog.Dispose();
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Xóa chi phí này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.OK))
            {
                if (_forCustomer)
                {
                    var temp = _groupDets.Where(m => m.Id.Equals(Int32.Parse(gridPerson.SelectedRows[0].Cells["Id"].Value.ToString()))).First();
                    _groupDets.Remove(temp);
                    _groupDetsModified.Remove(temp);
                    _groupDetsDeleted.Add(temp);
                }
                else
                {
                    var temp = _attendants.Where(m => m.Id.Equals(Int32.Parse(gridPerson.SelectedRows[0].Cells["Id"].Value.ToString()))).First();
                    _attendants.Remove(temp);
                    _attendantsModified.Remove(temp);
                    _attendantsDeleted.Add(temp);
                }

                LoadPersons(_forCustomer, _selectedPersonIndex - 1);
            }
        }
    }
}
