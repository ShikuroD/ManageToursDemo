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
    public partial class PriceListDialog : Form
    {
        private int _selectedId;
        public PriceListDialog(IList<Price> prices)
        {
            InitializeComponent();
            
            this.gridView.DataSource = new TblPrice(prices);

            this.gridView.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridView.Columns["Id"].DisplayIndex = 0;
            this.gridView.Columns["Id"].HeaderText = "ID";
            this.gridView.Columns["Id"].Width = 30;

            this.gridView.Columns["Name"].DisplayIndex = 1;
            this.gridView.Columns["Name"].HeaderText = "Tên";

            this.gridView.Columns["Value"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridView.Columns["Value"].DisplayIndex = 2;
            this.gridView.Columns["Value"].HeaderText = "Giá";
            this.gridView.Columns["Value"].Width = 120;
            this.gridView.Columns["Value"].DefaultCellStyle.Format = "##,#";

            this.gridView.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridView.Columns["StartDate"].DisplayIndex = 3;
            this.gridView.Columns["StartDate"].HeaderText = "Bắt đầu";
            this.gridView.Columns["StartDate"].Width = 120;
            this.gridView.Columns["StartDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            this.gridView.Columns["EndDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gridView.Columns["EndDate"].DisplayIndex = 4;
            this.gridView.Columns["EndDate"].HeaderText = "Kết thúc";
            this.gridView.Columns["EndDate"].Width = 120;
            this.gridView.Columns["EndDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            this.gridView.Columns["Status"].Visible = false;
            this.gridView.Columns["StatusName"].Visible = false;

        }
        public int getSelectedPriceId()
        {
            return _selectedId;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(gridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa có giá nào được chọn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            
            if (MessageBox.Show("Chọn giá này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.OK)){
                _selectedId = Int32.Parse(gridView.SelectedRows[0].Cells["Id"].Value.ToString());

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
