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
    public partial class SelectPersonDialog : Form
    {
        private IList<Person> _origin;
        private IList<Person> _arr;
        private IList<Attendant> _attendants;
        private IList<GroupDetail> _groupDets;
        private IList<Attendant> _attendantsModified;
        private IList<GroupDetail> _groupDetsModified;
        private IList<Job> _jobs;

        private IUnitOfWork _unitOfWork;
        private ITourAnalysisService _service;
        private DateTime _from;
        private DateTime _to;
        private bool _forAttendant = true;
        private int _selectedIndex = -1;
        private int _nextId;
        private string confirmMsg;

        private void LoadComboJob()
        {
            IList<SelectClass> arr = _jobs.Cast<SelectClass>().ToList();
            comboJob.Items.Clear();
            comboJob.DisplayMember = "Name";
            comboJob.ValueMember = "Id";
            comboJob.DataSource = new TblSelectClass(arr);
        }
        private void LoadComboSex()
        {
            Dictionary<SEX, string> comboSrc = new Dictionary<SEX, string>();
            comboSrc.Add(SEX.ALL, "Tất cả");
            comboSrc.Add(SEX.MALE, "Nam");
            comboSrc.Add(SEX.FEMALE, "Nữ");
            comboSrc.Add(SEX.OTHER, "Khác");


            comboSex.DataSource = new BindingSource(comboSrc, null);
            comboSex.DisplayMember = "Value";
            comboSex.ValueMember = "Key";
        }
        private void LoadGridView(int selectedIndex = -1)
        {
            Search();
            TblPerson table = new TblPerson(_arr);
            this.gridView.DataSource = table;
            if (selectedIndex < 0) this.gridView.ClearSelection();
            else this.gridView.Rows[selectedIndex].Selected = true;

        }
        private void SetUpGridView()
        {
            var col_Id = gridView.Columns["Id"];
            var col_Name = gridView.Columns["Name"];
            var col_Sex = gridView.Columns["Sex"];
            var col_SexName = gridView.Columns["SexName"];
            var col_IdentityCode = gridView.Columns["IdentityCode"];
            var col_PhoneNumber = gridView.Columns["PhoneNumber"];
            var col_Address = gridView.Columns["Address"];
            var col_Status = gridView.Columns["Status"];
            var col_StatusName = gridView.Columns["StatusName"];

            col_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_Id.DisplayIndex = 0;
            col_Id.HeaderText = "ID";
            col_Id.Width = 50;

            col_Name.DisplayIndex = 1;
            col_Name.HeaderText = "Tên";

            col_SexName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_SexName.DisplayIndex = 2;
            col_SexName.HeaderText = "Giới tính";
            col_SexName.Width = 60;

            col_IdentityCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_IdentityCode.DisplayIndex = 3;
            col_IdentityCode.HeaderText = "CMND";
            col_IdentityCode.Width = 100;

            col_PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_PhoneNumber.DisplayIndex = 4;
            col_PhoneNumber.HeaderText = "SĐT";
            col_PhoneNumber.Width = 100;

            col_Address.DisplayIndex = 5;
            col_Address.HeaderText = "Địa chỉ";

            col_StatusName.Visible = false;
            col_Sex.Visible = false;
            col_Status.Visible = false;
        }
        private void Search()
        {
            var searchName = txtSearchName.Text.Trim().ToLower();
            var searchSex = ((KeyValuePair<SEX, string>)comboSex.SelectedItem).Key;
            var searchPhone = txtSearchPhone.Text.Trim();
            var searchIdentity = txtSearchIdentityCode.Text.Trim();
            var res = _origin.AsQueryable();

            if (searchSex != SEX.ALL)
            {
                res = res.Where(m => m.Sex.Equals(searchSex));
            }
            if (!String.IsNullOrEmpty(searchName))
            {
                res = res.Where(m => m.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase));
            }
            if (!String.IsNullOrEmpty(searchIdentity))
            {
                res = res.Where(m => m.IdentityCode.Contains(searchIdentity));
            }
            if (!String.IsNullOrEmpty(searchPhone))
            {
                res = res.Where(m => m.PhoneNumber.Contains(searchPhone));
            }

            _arr = res.ToList();
        }

        public SelectPersonDialog(IUnitOfWork unitOfWork,ITourAnalysisService service, DateTime from, DateTime to, 
            IList<Employee> empsAvai, IList<Attendant> attendants, IList<Attendant> attendantsModified, int nextId, IList<Job> jobs)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _service = service;
            _from = from;
            _to = to;
            _attendants = attendants;
            _attendantsModified = attendantsModified;
            _jobs = jobs;
            _forAttendant = true;
            _origin = empsAvai.Cast<Person>().ToList();
            _nextId = nextId;
            this.Text = "Chọn nhân viên";
            confirmMsg = this.Text + " này?";
            LoadComboSex();
            LoadComboJob();
            LoadGridView();
            SetUpGridView();
        }
        public SelectPersonDialog(IUnitOfWork unitOfWork, ITourAnalysisService service, DateTime from, DateTime to, 
            IList<Customer> cusAvai, IList<GroupDetail> groupDetails, IList<GroupDetail> groupDetsModified, int nextId)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _service = service;
            _from = from;
            _to = to;
            _groupDets = groupDetails;
            _groupDetsModified = groupDetsModified;
            _forAttendant = false;
            _origin = cusAvai.Cast<Person>().ToList();
            _nextId = nextId;
            this.Text = "Chọn khách hàng";
            confirmMsg = this.Text + " này?";
            boxJob.Visible = false;
            LoadComboSex();
            LoadGridView();
            SetUpGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridView.SelectedRows.Count > 0)
            {
                var row = this.gridView.SelectedRows[0];
                _selectedIndex = row.Index;
            }
            else _selectedIndex = -1;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void comboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Hủy thao tác?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_selectedIndex < 0)
            {
                MessageBox.Show("Chưa có người được chọn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            var personId = Int32.Parse(gridView.Rows[_selectedIndex].Cells["Id"].Value.ToString());
            if (_forAttendant)
            {
                if (_attendants.Where(m => m.EmployeeId.Equals(personId)).Any())
                {
                    MessageBox.Show("Nhân viên đã có trong đoàn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                if (!_service.CanEmployeeBeAdded(personId, _from, _to))
                {
                    MessageBox.Show("Nhân viên đã tham gia đoàn khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
            }
            else
            {
                if (_groupDets.Where(m => m.CustomerId.Equals(personId)).Any())
                {
                    MessageBox.Show("Khách hàng đã có trong đoàn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                if (!_service.CanCustomerBeAdded(personId, _from, _to))
                {
                    MessageBox.Show("Khách hàng đã tham gia đoàn khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
            }
            var check = MessageBox.Show(confirmMsg, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            if (_forAttendant)
            {
                var jobId = (int)comboJob.SelectedValue;
                var temp = new Attendant(0, personId, jobId);
                temp.Id = _nextId + 1;
                _attendants.Add(temp);
                _attendantsModified.Add(temp);
            }
            else
            {
                var temp = new GroupDetail(0, personId);
                temp.Id = _nextId + 1;
                _groupDets.Add(temp);
                _groupDetsModified.Add(temp);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtSearchIdentityCode_TextChanged(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
            LoadGridView();
        }
    }
}
