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
using System.Text;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class GenericForm<T> : Form where T : SelectClass
    {
        private IList<T> _origin;
        private IList<T> _arr;

        private IUnitOfWork _unitOfWork;
        private Type _type;
        private int selectedIndex = 0;

        private string title;
        private string msgAdd;
        private string msgEdit;
        private string msgShow;
        private string msgHide;
        private void LoadMessages()
        {
            if (_type.Equals(typeof(Location)))
            {
                title = "Quản lí địa điểm"; msgAdd = "Thêm địa điểm này?"; msgEdit = "Sửa địa điểm này?"; msgShow = "Kích hoạt địa điểm này?"; msgHide = "Ẩn địa điểm này?";
            }
            else if (_type.Equals(typeof(CostType)))
            {
                title = "Quản lí loại chi phí"; msgAdd = "Thêm loại chi phí này?"; msgEdit = "Sửa loại chi phí này?"; msgShow = "Kích hoạt loại chi phí này?"; msgHide = "Ẩn loại chi phí này?";
            }
            else if (_type.Equals(typeof(TourType)))
            {
                title = "Quản lí loại tour"; msgAdd = "Thêm loại tour này?"; msgEdit = "Sửa loại tour này?"; msgShow = "Kích hoạt loại tour này?"; msgHide = "Ẩn loại tour này?";
            }
            else
            {
                title = "Quản lí công việc"; msgAdd = "Thêm công việc này?"; msgEdit = "Sửa công việc này?"; msgShow = "Kích hoạt công việc này?"; msgHide = "Ẩn công việc này?";
            }
        }
        private void LoadData()
        {
            if (_type.Equals(typeof(Location))) _origin = _unitOfWork.Locations.GetAll().Cast<T>().ToList();
            else if (_type.Equals(typeof(CostType))) _origin = _unitOfWork.CostTypes.GetAll().Cast<T>().ToList();
            else if (_type.Equals(typeof(TourType))) _origin = _unitOfWork.TourTypes.GetAll().Cast<T>().ToList();
            else _origin = _unitOfWork.Jobs.GetAll().Cast<T>().ToList();
        }
        
        private void LoadGridView(int selectedIndex = -1)
        {
            TblSelectClass table = new TblSelectClass(_arr.Cast<SelectClass>().ToList());
            this.gridView.DataSource = table;
            if (selectedIndex < 0)
            {
                this.gridView.ClearSelection();
                
            }
            else this.gridView.Rows[selectedIndex].Selected = true;
            
        }
        private void SetUpGridView()
        {
            
            this.gridView.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridView.Columns["Id"].DisplayIndex = 0;
            this.gridView.Columns["Id"].HeaderText = "ID";
            this.gridView.Columns["Id"].Width = 40;

            this.gridView.Columns["Name"].DisplayIndex = 1;
            this.gridView.Columns["Name"].HeaderText = "Tên";

            this.gridView.Columns["StatusName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridView.Columns["StatusName"].DisplayIndex = 2;
            this.gridView.Columns["StatusName"].HeaderText = "Trạng thái";
            this.gridView.Columns["StatusName"].Width = 45;

            this.gridView.Columns["Status"].Visible = false;
        }

        private void LoadInfo()
        {
            if (this.gridView.SelectedRows.Count > 0)
            {
                var row = this.gridView.SelectedRows[0];
                var statusCell = row.Cells["Status"];
                selectedIndex = row.Index;

                if ((STATUS)statusCell.Value == STATUS.AVAILABLE)
                {
                    btnChangeStatus.Text = "ẨN";
                    this.EnableButton(true);
                }
                else
                {
                    btnChangeStatus.Text = "KÍCH HOẠT";
                    this.EnableButton(true);
                }

                txtId.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
            }
            else
            {
                txtId.Text = "";
                txtName.Text = "";
                this.EnableButton(false);
            }
        }
        private void EnableButton(bool b)
        {
            btnEdit.Enabled = b;
            btnChangeStatus.Enabled = b;
        }
        private bool ValidateNewName(string name)
        {
            var query = _origin.AsQueryable();
            if (String.IsNullOrEmpty(name) || query.Where(m => m.Name.Equals(name)).Any()) return false;
            return true;
        }
        private void Search()
        {
            var search = txtSearch.Text.Trim().ToLower();
            var res = _origin.AsQueryable();
            if (!String.IsNullOrEmpty(search))
            {
                res = res.Where(m => m.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            _arr = res.ToList();
        }
        public GenericForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _type = typeof(T);
            LoadData();
            LoadMessages();
            _arr = _origin.ToList();
            
            
            InitializeComponent();

            this.Text = title;
            this.LoadGridView();

            this.SetUpGridView();

            selectedIndex = -1;

            this.ShowDialog();
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            
            LoadInfo();
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            var name = txtAdd.Text.Trim();
            
            if (ValidateNewName(name)){
                btnAdd.Enabled = true;
                lblErrorMessage.Visible = false;
            }
            else
            {
                btnAdd.Enabled = false;
                if (String.IsNullOrEmpty(name))
                {
                    lblErrorMessage.Visible = false;
                }
                else lblErrorMessage.Visible = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show(msgEdit, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            if (ValidateNewName(txtName.Text))
            {
                var add = txtAdd.Text;
                var name = txtName.Text;
                var id = Int32.Parse(txtId.Text);
                var temp = _origin.AsQueryable().Where(m => m.Id.Equals(id)).First();
                temp.Name = name;
                dynamic obj = Convert.ChangeType(temp, _type);
                if (_type.Equals(typeof(Location)))
                {
                    _unitOfWork.Locations.Update(obj);
                }
                else if (_type.Equals(typeof(CostType)))
                {
                    _unitOfWork.CostTypes.Update(obj);
                }
                else if (_type.Equals(typeof(TourType)))
                {
                    _unitOfWork.TourTypes.Update(obj);
                }
                else
                {
                    _unitOfWork.Jobs.Update(obj);
                }

                txtAdd.Text = add;
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Search();
                LoadGridView(selectedIndex);
            }
            else
            {
                MessageBox.Show("Tên muốn thay đổi đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(txtId.Text);
            var temp = _origin.AsQueryable().Where(m => m.Id.Equals(id)).First();

            var toShow = btnChangeStatus.Text.Equals("ẨN") ? false : true;
            var check = MessageBox.Show(toShow?msgShow:msgHide, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            dynamic obj = Convert.ChangeType(temp, _type);

            if (_type.Equals(typeof(Location)))
            {
                if (toShow) _unitOfWork.Locations.Activate(obj);
                else _unitOfWork.Locations.Disable(obj);
            }
            else if (_type.Equals(typeof(CostType)))
            {
                if (toShow) _unitOfWork.CostTypes.Activate(obj);
                else _unitOfWork.CostTypes.Disable(obj);
            }
            else if (_type.Equals(typeof(TourType)))
            {
                if (toShow) _unitOfWork.TourTypes.Activate(obj);
                else _unitOfWork.TourTypes.Disable(obj);
            }
            else
            {
                if (toShow) _unitOfWork.Jobs.Activate(obj);
                else _unitOfWork.Jobs.Disable(obj);
            }


            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            Search();
            LoadGridView(selectedIndex);
           
        }

        private void gridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridView.ClearSelection();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show(msgAdd, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            var name = txtAdd.Text.Trim();
            if (!ValidateNewName(name))
            {
                MessageBox.Show("Tên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_type.Equals(typeof(Location)))
            {
                var obj = new Location(name);
                _unitOfWork.Locations.Add(obj);
            }
            else if (_type.Equals(typeof(CostType)))
            {
                var obj = new CostType(name);
                _unitOfWork.CostTypes.Add(obj);
            }
            else if (_type.Equals(typeof(TourType)))
            {
                var obj = new TourType(name);
                _unitOfWork.TourTypes.Add(obj);
            }
            else
            {
                var obj = new Job(name);
                _unitOfWork.Jobs.Add(obj);
            }
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            Search();
            LoadGridView(selectedIndex);
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

        private void gridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var index = e.RowIndex;
            var cell = gridView.Rows[index].Cells["StatusName"];
            //if (cell.Value.ToString().Equals("O")) cell.Style.BackColor = Color.Green;
            //else cell.Style.BackColor = Color.Red;
        }

        private void gridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var index = e.RowIndex;
            var cell = gridView.Rows[index].Cells["StatusName"];
            if (cell.Value.ToString().Equals("O")) cell.Style.BackColor = Color.Green;
            else cell.Style.BackColor = Color.Red;
        }
    }
}
