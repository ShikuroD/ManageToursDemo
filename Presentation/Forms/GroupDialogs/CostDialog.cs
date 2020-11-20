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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class CostDialog : Form
    {
        private IUnitOfWork _unitOfWork;
        private IList<Cost> _costs;
        private IList<Cost> _costsModified;
        private IList<CostType> _costTypes;
        private Cost _model;

        private string title;
        private string confirmMsg;

        private bool _toBeEdited = false;
        private int _editCostType;
        private void LoadComboCostType()
        {
            IList<SelectClass> arr = _costTypes.Cast<SelectClass>().ToList();
            comboCostType.Items.Clear();
            
            comboCostType.DisplayMember = "Name";
            comboCostType.ValueMember = "Id";
            comboCostType.DataSource = new TblSelectClass(arr);
        }
        private void LoadModel()
        {
            if (!_toBeEdited)
            {
                txtName.Text = comboCostType.SelectedText; return;
            }

            txtName.Text = _model.Name;
            txtValue.Text = _model.Value.ToString();
            txtDescription.Text = _model.Description;
            //comboCostType.SelectedIndex = _model.CostTypeId - 1;
            if (_toBeEdited) comboCostType.SelectedValue = _model.CostTypeId;
        }
        private Cost returnModel()
        {
            var res = new Cost();

            res.Name = txtName.Text;
            res.Value = decimal.Parse(txtValue.Text);
            res.Description = txtDescription.Text;
            res.CostTypeId = (int)comboCostType.SelectedValue;

            return res;
        }
        public CostDialog(IUnitOfWork unitOfWork, IList<Cost> costs, IList<Cost> costModified, IList<CostType> costTypes, Cost model)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _costs = costs;
            _costsModified = costModified;
            _costTypes = costTypes;
            if (model == null)
            {
                title = "Thêm chi phí";
            }
            else
            {
                _toBeEdited = true;
                _model = model;
                _editCostType = _model.CostTypeId;
                title = "Cập nhật chi phí";
            }
            this.Text = title;
            confirmMsg = title + " này?";

            LoadComboCostType();
            LoadModel();
            
        }

        private void comboCostType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (int)comboCostType.SelectedValue;
            if(id.Equals(_editCostType))
            {
                lblCostTYpeError.Visible = false; return;
            }
            if(_costs.Where(m => m.CostTypeId.Equals(id)).Any())
            {
                lblCostTYpeError.Visible = true;
            }
            else
            {
                lblCostTYpeError.Visible = false;
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
            if (lblNameError.Visible || lblValueError.Visible || String.IsNullOrEmpty(txtValue.Text.Trim()) || String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Dữ liệu nhập chưa chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            var check = MessageBox.Show(confirmMsg, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check.Equals(DialogResult.Cancel)) return;

            //execute
            if (_toBeEdited)
            {
                _costs.Remove(_model);
                _costsModified.Remove(_model);
                var temp = returnModel();
                _costs.Add(temp);
                _costsModified.Add(temp);
            }
            else
            {
                var newPrice = returnModel();
                _costs.Add(newPrice);
                _costsModified.Add(newPrice);
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
    }
}
