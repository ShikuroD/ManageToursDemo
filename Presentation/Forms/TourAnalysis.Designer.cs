
namespace Presentation.Forms
{
    partial class TourAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSumRevenueByCons = new System.Windows.Forms.TextBox();
            this.txtSumCostByCons = new System.Windows.Forms.TextBox();
            this.txtSumRevenue = new System.Windows.Forms.TextBox();
            this.txtSumCost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSumPriceByCons = new System.Windows.Forms.TextBox();
            this.txtCountGroupByCons = new System.Windows.Forms.TextBox();
            this.txtSumPrice = new System.Windows.Forms.TextBox();
            this.txtCountGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.gridTour = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboGroupStatus = new System.Windows.Forms.ComboBox();
            this.comboTourStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboTourType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchTour = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridGroup = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTour)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSumRevenueByCons);
            this.groupBox1.Controls.Add(this.txtSumCostByCons);
            this.groupBox1.Controls.Add(this.txtSumRevenue);
            this.groupBox1.Controls.Add(this.txtSumCost);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSumPriceByCons);
            this.groupBox1.Controls.Add(this.txtCountGroupByCons);
            this.groupBox1.Controls.Add(this.txtSumPrice);
            this.groupBox1.Controls.Add(this.txtCountGroup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.gridTour);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 731);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tour";
            // 
            // txtSumRevenueByCons
            // 
            this.txtSumRevenueByCons.Location = new System.Drawing.Point(592, 397);
            this.txtSumRevenueByCons.Name = "txtSumRevenueByCons";
            this.txtSumRevenueByCons.ReadOnly = true;
            this.txtSumRevenueByCons.Size = new System.Drawing.Size(201, 23);
            this.txtSumRevenueByCons.TabIndex = 20;
            this.txtSumRevenueByCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumCostByCons
            // 
            this.txtSumCostByCons.Location = new System.Drawing.Point(592, 366);
            this.txtSumCostByCons.Name = "txtSumCostByCons";
            this.txtSumCostByCons.ReadOnly = true;
            this.txtSumCostByCons.Size = new System.Drawing.Size(201, 23);
            this.txtSumCostByCons.TabIndex = 19;
            this.txtSumCostByCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumRevenue
            // 
            this.txtSumRevenue.Location = new System.Drawing.Point(123, 397);
            this.txtSumRevenue.Name = "txtSumRevenue";
            this.txtSumRevenue.ReadOnly = true;
            this.txtSumRevenue.Size = new System.Drawing.Size(209, 23);
            this.txtSumRevenue.TabIndex = 18;
            this.txtSumRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumCost
            // 
            this.txtSumCost.Location = new System.Drawing.Point(123, 366);
            this.txtSumCost.Name = "txtSumCost";
            this.txtSumCost.ReadOnly = true;
            this.txtSumCost.Size = new System.Drawing.Size(209, 23);
            this.txtSumCost.TabIndex = 17;
            this.txtSumCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(419, 369);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Tổng chi theo điều kiện lọc:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tổng thu theo điều kiện lọc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tổng chi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tổng thu:";
            // 
            // txtSumPriceByCons
            // 
            this.txtSumPriceByCons.Location = new System.Drawing.Point(592, 335);
            this.txtSumPriceByCons.Name = "txtSumPriceByCons";
            this.txtSumPriceByCons.ReadOnly = true;
            this.txtSumPriceByCons.Size = new System.Drawing.Size(201, 23);
            this.txtSumPriceByCons.TabIndex = 12;
            this.txtSumPriceByCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCountGroupByCons
            // 
            this.txtCountGroupByCons.Location = new System.Drawing.Point(592, 303);
            this.txtCountGroupByCons.Name = "txtCountGroupByCons";
            this.txtCountGroupByCons.ReadOnly = true;
            this.txtCountGroupByCons.Size = new System.Drawing.Size(201, 23);
            this.txtCountGroupByCons.TabIndex = 11;
            this.txtCountGroupByCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumPrice
            // 
            this.txtSumPrice.Location = new System.Drawing.Point(123, 335);
            this.txtSumPrice.Name = "txtSumPrice";
            this.txtSumPrice.ReadOnly = true;
            this.txtSumPrice.Size = new System.Drawing.Size(209, 23);
            this.txtSumPrice.TabIndex = 10;
            this.txtSumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCountGroup
            // 
            this.txtCountGroup.Location = new System.Drawing.Point(123, 303);
            this.txtCountGroup.Name = "txtCountGroup";
            this.txtCountGroup.ReadOnly = true;
            this.txtCountGroup.Size = new System.Drawing.Size(209, 23);
            this.txtCountGroup.TabIndex = 9;
            this.txtCountGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số đoàn theo điều kiện lọc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lợi nhuận theo điều kiện lọc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng lợi nhuận:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng số đoàn:";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(557, 677);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(151, 46);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // gridTour
            // 
            this.gridTour.AllowUserToAddRows = false;
            this.gridTour.AllowUserToDeleteRows = false;
            this.gridTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTour.Location = new System.Drawing.Point(12, 107);
            this.gridTour.MultiSelect = false;
            this.gridTour.Name = "gridTour";
            this.gridTour.ReadOnly = true;
            this.gridTour.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridTour.RowHeadersVisible = false;
            this.gridTour.RowTemplate.Height = 25;
            this.gridTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTour.Size = new System.Drawing.Size(1237, 179);
            this.gridTour.TabIndex = 3;
            this.gridTour.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridTour_RowPrePaint);
            this.gridTour.SelectionChanged += new System.EventHandler(this.gridTour_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboGroupStatus);
            this.groupBox3.Controls.Add(this.comboTourStatus);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.comboTourType);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dateTo);
            this.groupBox3.Controls.Add(this.dateFrom);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSearchTour);
            this.groupBox3.Location = new System.Drawing.Point(12, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1237, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc";
            // 
            // comboGroupStatus
            // 
            this.comboGroupStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroupStatus.FormattingEnabled = true;
            this.comboGroupStatus.Location = new System.Drawing.Point(729, 39);
            this.comboGroupStatus.Name = "comboGroupStatus";
            this.comboGroupStatus.Size = new System.Drawing.Size(176, 23);
            this.comboGroupStatus.TabIndex = 12;
            // 
            // comboTourStatus
            // 
            this.comboTourStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTourStatus.FormattingEnabled = true;
            this.comboTourStatus.Location = new System.Drawing.Point(729, 13);
            this.comboTourStatus.Name = "comboTourStatus";
            this.comboTourStatus.Size = new System.Drawing.Size(176, 23);
            this.comboTourStatus.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(636, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Trạng thái đoàn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Trạng thái tour:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1137, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 33);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Lọc";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboTourType
            // 
            this.comboTourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTourType.FormattingEnabled = true;
            this.comboTourType.Location = new System.Drawing.Point(363, 32);
            this.comboTourType.Name = "comboTourType";
            this.comboTourType.Size = new System.Drawing.Size(257, 23);
            this.comboTourType.TabIndex = 7;
            this.comboTourType.SelectedIndexChanged += new System.EventHandler(this.comboTourType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Loại tour:";
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(1005, 37);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(108, 23);
            this.dateTo.TabIndex = 5;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(1005, 13);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(108, 23);
            this.dateFrom.TabIndex = 4;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(943, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày KT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(943, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày BĐ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên tour:";
            // 
            // txtSearchTour
            // 
            this.txtSearchTour.Location = new System.Drawing.Point(92, 32);
            this.txtSearchTour.Name = "txtSearchTour";
            this.txtSearchTour.Size = new System.Drawing.Size(184, 23);
            this.txtSearchTour.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridGroup);
            this.groupBox2.Location = new System.Drawing.Point(12, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1246, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đoàn";
            // 
            // gridGroup
            // 
            this.gridGroup.AllowUserToAddRows = false;
            this.gridGroup.AllowUserToDeleteRows = false;
            this.gridGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGroup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroup.Enabled = false;
            this.gridGroup.Location = new System.Drawing.Point(3, 19);
            this.gridGroup.MultiSelect = false;
            this.gridGroup.Name = "gridGroup";
            this.gridGroup.ReadOnly = true;
            this.gridGroup.RowTemplate.Height = 25;
            this.gridGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGroup.Size = new System.Drawing.Size(1240, 200);
            this.gridGroup.TabIndex = 0;
            this.gridGroup.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridGroup_RowPrePaint);
            // 
            // TourAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 731);
            this.Controls.Add(this.groupBox1);
            this.Name = "TourAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê tour";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTour)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridTour;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSumPriceByCons;
        private System.Windows.Forms.TextBox txtCountGroupByCons;
        private System.Windows.Forms.TextBox txtSumPrice;
        private System.Windows.Forms.TextBox txtCountGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView gridGroup;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchTour;
        private System.Windows.Forms.ComboBox comboTourType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboTourStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboGroupStatus;
        private System.Windows.Forms.TextBox txtSumRevenueByCons;
        private System.Windows.Forms.TextBox txtSumCostByCons;
        private System.Windows.Forms.TextBox txtSumRevenue;
        private System.Windows.Forms.TextBox txtSumCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}