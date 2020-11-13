using AppCore;
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
    public partial class PersonDialog<T> : Form  where T : Person
    {
        private T _model = null;
        private string title;
        private string confirmMsg;
        private Type _type;

        private void hideId()
        {
            lblId.Visible = false;
            txtId.Visible = false;
        }
        private void LoadComboSex()
        {
            Dictionary<SEX, string> comboSrc = new Dictionary<SEX, string>();
       
            comboSrc.Add(SEX.MALE, "Nam");
            comboSrc.Add(SEX.FEMALE, "Nữ");
            comboSrc.Add(SEX.OTHER, "Khác");

            comboSex.DataSource = new BindingSource(comboSrc, null);
            comboSex.DisplayMember = "Value";
            comboSex.ValueMember = "Key";
        }
        private void LoadView()
        {
            if (_model == null) return;

            txtId.Text = _model.Id.ToString();
            txtName.Text = _model.Name;
            txtIdentityCode.Text = _model.IdentityCode;
            txtPhoneNumber.Text = _model.PhoneNumber;
            txtAddress.Text = _model.Address;

            comboSex.SelectedValue = _model.Sex;
        }
        public T returnModel()
        {
            if (_model == null)
            {
                if (_type.Equals(typeof(Employee))) _model = new Employee() as T;
                else _model = new Customer() as T;
            }
            _model.Name = txtName.Text;
            _model.IdentityCode = txtIdentityCode.Text;
            _model.PhoneNumber = txtPhoneNumber.Text; ;
            _model.Address = txtAddress.Text;
            _model.Sex = ((KeyValuePair<SEX, string>)comboSex.SelectedItem).Key;

            return _model;
        }
        public PersonDialog(T model)
        {
            _type = typeof(T);
            
            InitializeComponent();

            LoadComboSex();
            if (model == null)
            {
                this.hideId();
                if (_type.Equals(typeof(Employee)))
                {
                    title = "Thêm nhân viên";
                }
                else
                {
                    title = "Thêm khách hàng";
                }
            }
            else
            {
                _model = model;
                if (_type.Equals(typeof(Employee)))
                {
                    title = "Cập nhật nhân viên";
                }
                else
                {
                    title = "Cập nhật khách hàng";
                }
            }
            confirmMsg = title + " này?";

            this.Text = title;
            this.LoadView();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text)) lblNameError.Visible = true;
            else lblNameError.Visible = false;
        }

        private void txtIdentityCode_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(@"^[0-9]{10}$");
            if (regex.IsMatch(txtIdentityCode.Text)) lblIdentityCodeError.Visible = false;
            else lblIdentityCodeError.Visible = true;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(@"^[0-9]{10}$");
            if (regex.IsMatch(txtPhoneNumber.Text)) lblPhoneError.Visible = false;
            else lblPhoneError.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lblNameError.Visible || lblIdentityCodeError.Visible || lblPhoneError.Visible
                ||String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtIdentityCode.Text) || String.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Dữ liệu nhập chưa chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
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
    }
}
