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
    public partial class EmployeeAnalysis : Form
    {
        private IList<Employee> _origin;
        private IList<Employee> _arr;

        private IUnitOfWork _unitOfWork;
        private ITourAnalysisService _serivce;
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
            TblPerson table = new TblPerson(_arr.Cast<Person>().ToList(), true);
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
            var col_TurnCount = gridView.Columns["TurnCount"];
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

            col_TurnCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_TurnCount.DisplayIndex = 6;
            col_TurnCount.HeaderText = "Số lượt tham gia đoàn";
            col_TurnCount.Width = 150;

            col_StatusName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_StatusName.DisplayIndex = 7;
            col_StatusName.HeaderText = "Trạng thái";
            col_StatusName.Width = 70;

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
        public EmployeeAnalysis(IUnitOfWork unitOfWork, ITourAnalysisService serivce)
        {
            _unitOfWork = unitOfWork;
            _serivce = serivce;
            _origin = _unitOfWork.Employees.GetAll();
            _arr = _origin.ToList();

            InitializeComponent();

            this.LoadComboSex();

          
            _serivce.FilterEmployeeByDate(_arr, DateTime.MinValue.Date, DateTime.MaxValue.Date);
            
            this.LoadGridView();

            this.SetUpGridView();

            gridView.ClearSelection();
            this.ShowDialog();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
            //Search();
            //_serivce.FilterEmployeeByDate(_arr, dateFrom.Value.Date, dateTo.Value.Date);
            //LoadGridView();
        }
        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            //Search();
            //_serivce.FilterEmployeeByDate(_arr, dateFrom.Value.Date, dateTo.Value.Date);
            //LoadGridView();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            _serivce.FilterEmployeeByDate(_arr, dateFrom.Value.Date, dateTo.Value.Date);
            LoadGridView();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            Search();
            _serivce.FilterEmployeeByDate(_arr, DateTime.MinValue.Date, DateTime.MaxValue.Date);
            LoadGridView();
        }

        private void comboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
            _serivce.FilterEmployeeByDate(_arr, DateTime.MinValue.Date, DateTime.MaxValue.Date);
            LoadGridView();
        }

        private void txtSearchIdentityCode_TextChanged(object sender, EventArgs e)
        {
            Search();
            _serivce.FilterEmployeeByDate(_arr, DateTime.MinValue.Date, DateTime.MaxValue.Date);
            LoadGridView();
        }

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
            Search();
            _serivce.FilterEmployeeByDate(_arr, DateTime.MinValue.Date, DateTime.MaxValue.Date);
            LoadGridView();
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
