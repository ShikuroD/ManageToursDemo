using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using Presentation.ViewModels.DataTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class PersonForm<T> : Form where T : Person
    {
        private IList<T> _origin;
        private IList<T> _arr;
        private T _model;

        private IUnitOfWork _unitOfWork;
        private Type _type;
        private int _selectedIndex = -1;

        private string title;
        //private string msgAdd;
        //private string msgEdit;
        private string msgShow;
        private string msgHide;
        private void LoadMessages()
        {
            if (_type.Equals(typeof(Employee)))
            {
                title = "Quản lí nhân viên"; //msgEdit = "Sửa nhân viên này?"; 
                msgShow = "Kích hoạt nhân viên này?"; msgHide = "Ẩn nhân viên này?";
            }
            else
            {
                title = "Quản lí khách hàng"; //msgEdit = "Sửa khách hàng này?"; 
                msgShow = "Kích hoạt khách hàng này?"; msgHide = "Ẩn khách hàng này?";
            }
        }
        private void LoadData()
        {
            if (_type.Equals(typeof(Employee))) _origin = _unitOfWork.Employees.GetAll().Cast<T>().ToList();
            else _origin = _unitOfWork.Customers.GetAll().Cast<T>().ToList();
        }
        private void LoadModel(DataGridViewRow row = null)
        {
            if (row == null)
            {
                _model = null;
            }
            else
            {
                if (_type.Equals(typeof(Employee)))
                {
                    _model = new Employee(
                        row.Cells["Name"].Value.ToString(),
                        (SEX)row.Cells["Sex"].Value,
                        row.Cells["IdentityCode"].Value.ToString(),
                        row.Cells["PhoneNumber"].Value.ToString(),
                        row.Cells["Address"].Value.ToString(),
                        (STATUS)row.Cells["Status"].Value) as T;
                    _model.Id = Int32.Parse(row.Cells["Id"].Value.ToString());
                }
                else
                {
                    _model = new Customer(
                        row.Cells["Name"].Value.ToString(),
                        (SEX)row.Cells["Sex"].Value,
                        row.Cells["IdentityCode"].Value.ToString(),
                        row.Cells["PhoneNumber"].Value.ToString(),
                        row.Cells["Address"].Value.ToString(),
                        (STATUS)row.Cells["Status"].Value) as T;
                    _model.Id = Int32.Parse(row.Cells["Id"].Value.ToString());
                }
            }
        }
        private void LoadInfo(T model)
        {
            if(model == null)
            {
                txtId.Text = ""; txtName.Text = ""; txtIdentityCode.Text = ""; txtPhoneNumber.Text = ""; txtAddress.Text = "";
                txtSex.Text = "";
            }
            else
            {
                txtId.Text = model.Id.ToString(); txtName.Text = model.Name; txtIdentityCode.Text = model.IdentityCode; 
                txtPhoneNumber.Text = model.PhoneNumber; txtAddress.Text = model.Address;
                txtSex.Text = "Khác";
                if (model.Sex == SEX.MALE) txtSex.Text = "Nam";
                else if (model.Sex == SEX.FEMALE) txtSex.Text = "Nữ";
            }
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
            TblPerson table = new TblPerson(_arr.Cast<Person>().ToList());
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

            col_StatusName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_StatusName.DisplayIndex = 6;
            col_StatusName.HeaderText = "Trạng thái";
            col_StatusName.Width = 70;

            col_Sex.Visible = false;
            col_Status.Visible = false;
        }

        private void LoadSelectedRow()
        {
            if (this.gridView.SelectedRows.Count > 0)
            {
                var row = this.gridView.SelectedRows[0];
                _selectedIndex = row.Index;
                if ((STATUS)row.Cells["Status"].Value == STATUS.AVAILABLE)
                {
                    btnChangeStatus.Text = "ẨN";
                    this.EnableButton(true);
                }
                else
                {
                    btnChangeStatus.Text = "KÍCH HOẠT";
                    this.EnableButton(true);
                }

                LoadModel(row);
                LoadInfo(_model);
            }
            else
            {
                LoadModel();
                LoadInfo(_model);
                this.EnableButton(false);
            }
        }
        private void EnableButton(bool b)
        {
            btnEdit.Enabled = b;
            btnChangeStatus.Enabled = b;
        }
        
        private void Search()
        {
            var searchName = txtSearchName.Text.Trim().ToLower();
            var searchSex = ((KeyValuePair<SEX, string>)comboSex.SelectedItem).Key;
            var res = _origin.AsQueryable();
            //MessageBox.Show("before earch: " + _arr.Count + " | " + searchSex.ToString()); 
            
            if (searchSex != SEX.ALL)
            {
                res = res.Where(m => m.Sex.Equals(searchSex));
            }
            if (!String.IsNullOrEmpty(searchName))
            {
                res = res.Where(m => m.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase));
            }
            
            _arr = res.ToList();
            //MessageBox.Show("after earch: " + _arr.Count);
        }
        public PersonForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _type = typeof(T);
            LoadData();
            LoadMessages();
            _arr = _origin.ToList();
            
            InitializeComponent();

            this.Text = title;
            this.LoadComboSex();
            this.LoadGridView();

            this.SetUpGridView();

            gridView.ClearSelection();
            _selectedIndex = -1;

            this.ShowDialog();
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadSelectedRow();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            var entity = _origin.Where(m => m.Id.Equals(_model.Id)).First();
            var dialog = new PersonDialog<T>(entity);
            var check = dialog.ShowDialog();
            
            if (check.Equals(DialogResult.OK))
            {
                var temp = dialog.returnModel();
                dynamic obj = Convert.ChangeType(temp, _type);
                if (_type.Equals(typeof(Employee)))
                {
                    _unitOfWork.Employees.Update(obj);
                }
                else
                {
                    _unitOfWork.Customers.Update(obj);
                }
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Search();
                LoadGridView(_selectedIndex);
            }
            dialog.Dispose();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(txtId.Text);
            var temp = _origin.AsQueryable().Where(m => m.Id.Equals(id)).First();

            var toShow = btnChangeStatus.Text.Equals("ẨN") ? false : true;
            var check = MessageBox.Show(toShow ? msgShow : msgHide, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            dynamic obj = Convert.ChangeType(temp, _type);
            

            if (_type.Equals(typeof(Employee)))
            {
                if (toShow) _unitOfWork.Employees.Activate(obj);
                else _unitOfWork.Employees.Disable(obj);

                
            }
            else
            {
                if (toShow) _unitOfWork.Customers.Activate(obj);
                else _unitOfWork.Customers.Disable(obj);
            }


            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            Search();
            LoadGridView(_selectedIndex);
           
        }

        private void gridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridView.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new PersonDialog<T>(null);
            var check = dialog.ShowDialog();

            if (check.Equals(DialogResult.OK))
            {
                var temp = dialog.returnModel();
                dynamic obj = Convert.ChangeType(temp, _type);
                if (_type.Equals(typeof(Employee)))
                {
                    _unitOfWork.Employees.Add(obj);
                }
                else
                {
                    _unitOfWork.Customers.Add(obj);
                }
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Search();
                LoadGridView(_selectedIndex);
            }
            dialog.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //LoadData();
            Search();
            LoadGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //LoadData();
            Search();
            LoadGridView();
        }

        private void gridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var index = e.RowIndex;
            var cell = gridView.Rows[index].Cells["StatusName"];
            if (cell.Value.ToString().Equals("O")) cell.Style.BackColor = Color.Green;
            else cell.Style.BackColor = Color.Red;
        }

        private void comboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadData();
            Search();
            LoadGridView();
        }
    }
}
