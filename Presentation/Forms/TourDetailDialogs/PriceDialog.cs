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
        private IList<Price> _pricesModified;

        private int _nextPriceId;
        private string title;
        private string confirmMsg;
        private string _tourName;

        private bool _toBeEdited = false;
        private void hideId()
        {
            lblId.Visible = false;
            txtId.Visible = false;
        }
        
        private void LoadModel()
        {
            if (!_toBeEdited)
            {
                txtName.Text = _tourName; return;
            }

            txtId.Text = _model.Id.ToString();
            txtName.Text = _model.Name;
            txtValue.Text = _model.Value.ToString();
            dateStart.Value = _model.StartDate.Date;
            dateEnd.Value = _model.EndDate.Date;
        }
        private Price returnModel()
        {
            var res = new Price();
            if (_toBeEdited) res.Id = _model.Id;

            res.Name = txtName.Text;
            res.Value = decimal.Parse(txtValue.Text);
            res.StartDate = dateStart.Value.Date;
            res.EndDate = dateEnd.Value.Date;

            return res;
        }
        public PriceDialog(IUnitOfWork unitOfWork, Price model, IList<Price> prices, IList<Price> pricesModified, int nextPriceId, string tourName)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _prices = prices;
            _pricesModified = pricesModified;
            _nextPriceId = nextPriceId;
            if (model == null)
            {
                this.hideId();
                title = "Thêm giá";
            }
            else
            {
                _toBeEdited = true;
                _model = model;
                title = "Cập nhật giá";
            }
            _tourName = tourName;
            this.Text = title;
            confirmMsg = title + " này?";
            

            LoadModel();
            this.dateStart.MinDate = this.dateStart.Value.Date;
            this.dateEnd.MinDate = this.dateStart.Value.Date;

            if(_toBeEdited && DateTime.Compare(_model.EndDate.Date, DateTime.Today) < 0)
            {
                dateStart.Enabled = false;
                dateEnd.Enabled = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text)) lblNameError.Visible = true;
            else lblNameError.Visible = false;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(@"^[1-9]{1}[0-9]{0,12}$");
            if (regex.IsMatch(txtValue.Text)) lblValueError.Visible = false;
            else lblValueError.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            //validating
            if (lblNameError.Visible || lblValueError.Visible || String.IsNullOrEmpty(txtValue.Text.Trim()))
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

            //execute
            if (_toBeEdited)
            {
                var old_id = _model.Id;
                _prices.Remove(_model);
                _pricesModified.Remove(_model);
                var temp = returnModel();
                temp.Id = old_id;
                _prices.Add(temp);
                _pricesModified.Add(temp);
            }
            else
            {
                var newPrice = returnModel();
                newPrice.Id = _nextPriceId + 1;
                _prices.Add(newPrice);
                _pricesModified.Add(newPrice);
            }

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
            if(DateTime.Compare(dateStart.Value,dateEnd.Value) < 0)
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
    }
}
