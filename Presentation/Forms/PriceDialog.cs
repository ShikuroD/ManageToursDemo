using AppCore.Interfaces;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class PriceDialog : Form
    {
        private Price _model;
        private IUnitOfWork _unitOfWork;
        private IList<Price> _prices;

        private string title;
        private string confirmMsg;
        private string _tourName;
        private void hideId()
        {
            lblId.Visible = false;
            txtId.Visible = false;
        }
        
        private void LoadModel()
        {
            if (_model == null)
            {
                txtName.Text = _tourName; return;
            }

            txtId.Text = _model.Id.ToString();
            txtName.Text = _model.Name;
            txtValue.Text = _model.Value.ToString();
            dateStart.Value = _model.StartDate.Date;
            dateEnd.Value = _model.EndDate.Date;
        }
        public Price returnModel()
        {
            if (_model == null) _model = new Price();

            _model.Name = txtName.Text;
            _model.Value = decimal.Parse(txtValue.Text);
            _model.StartDate = dateStart.Value.Date;
            _model.EndDate = dateEnd.Value.Date;

            return _model;
        }
        public PriceDialog(IUnitOfWork unitOfWork, Price model, IList<Price> prices, string tourName)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _prices = prices;
            if (model == null)
            {
                this.hideId();
                title = "Thêm giá";
            }
            else
            {
                _model = model;
                title = "Cập nhật giá";
            }
            _tourName = tourName;
            confirmMsg = title + " này?";
            

            LoadModel();
            this.dateEnd.MinDate = this.dateStart.Value.Date;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text)) lblNameError.Visible = true;
            else lblNameError.Visible = false;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(@"^[1-9]+[0-9]*$");
            if (regex.IsMatch(txtValue.Text)) lblValueError.Visible = false;
            else lblValueError.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lblNameError.Visible || lblValueError.Visible)
            {
                MessageBox.Show("Dữ liệu nhập chưa chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            var res = true;
            var start = dateStart.Value.Date;
            var end = dateEnd.Value.Date;
            foreach(Price p in _prices)
            {
                if (_model != null && _model.Id.Equals(p.Id)) continue;
                if(DateTime.Compare(start, p.StartDate.Date) >= 0 && DateTime.Compare(start, p.EndDate) <= 0)
                {
                    res = false; break;
                }
                else if (DateTime.Compare(end, p.StartDate.Date) >= 0 && DateTime.Compare(end, p.EndDate) <= 0)
                {
                    res = false; break;
                }
            }
            if(!res)
            {
                MessageBox.Show("Thời gian áp dụng bị trùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            var check = MessageBox.Show(confirmMsg, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Hủy thao tác?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            this.dateEnd.MinDate = this.dateStart.Value.Date;
            this.dateEnd.Value = this.dateStart.Value.Date;
        }
    }
}
