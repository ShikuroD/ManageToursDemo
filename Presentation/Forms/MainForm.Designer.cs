namespace Presentation
{
    partial class MainForm
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
            this.btnEditTourDetail = new System.Windows.Forms.Button();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.btnChangeTourStatus = new System.Windows.Forms.Button();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnManageCostType = new System.Windows.Forms.Button();
            this.btnManageJob = new System.Windows.Forms.Button();
            this.btnManageTourType = new System.Windows.Forms.Button();
            this.btnManageLocation = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.pnTour = new System.Windows.Forms.GroupBox();
            this.btnTourSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTourType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditTourGroup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewTourDetail = new System.Windows.Forms.DataGridView();
            this.txtTourSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridViewTour = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnTour.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTourDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditTourDetail
            // 
            this.btnEditTourDetail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditTourDetail.Enabled = false;
            this.btnEditTourDetail.Location = new System.Drawing.Point(3, 3);
            this.btnEditTourDetail.Name = "btnEditTourDetail";
            this.btnEditTourDetail.Size = new System.Drawing.Size(194, 60);
            this.btnEditTourDetail.TabIndex = 0;
            this.btnEditTourDetail.Text = "CẬP NHẬT CHI TIẾT";
            this.btnEditTourDetail.UseVisualStyleBackColor = false;
            this.btnEditTourDetail.Click += new System.EventHandler(this.btnEditTour_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteTour.Enabled = false;
            this.btnDeleteTour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteTour.Location = new System.Drawing.Point(3, 201);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(194, 61);
            this.btnDeleteTour.TabIndex = 0;
            this.btnDeleteTour.Text = "XÓA";
            this.btnDeleteTour.UseVisualStyleBackColor = false;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // btnChangeTourStatus
            // 
            this.btnChangeTourStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChangeTourStatus.Enabled = false;
            this.btnChangeTourStatus.Location = new System.Drawing.Point(3, 135);
            this.btnChangeTourStatus.Name = "btnChangeTourStatus";
            this.btnChangeTourStatus.Size = new System.Drawing.Size(194, 60);
            this.btnChangeTourStatus.TabIndex = 1;
            this.btnChangeTourStatus.Text = "ẨN";
            this.btnChangeTourStatus.UseVisualStyleBackColor = false;
            this.btnChangeTourStatus.Click += new System.EventHandler(this.btnChangeTourStatus_Click);
            // 
            // btnAddTour
            // 
            this.btnAddTour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddTour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTour.Location = new System.Drawing.Point(6, 598);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(138, 59);
            this.btnAddTour.TabIndex = 0;
            this.btnAddTour.Text = "THÊM";
            this.btnAddTour.UseVisualStyleBackColor = false;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(11, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 338);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quán lí danh sách";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnManageCostType, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnManageJob, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnManageTourType, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnManageLocation, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnManageCustomer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnManageEmployee, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 302);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnManageCostType
            // 
            this.btnManageCostType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageCostType.Location = new System.Drawing.Point(3, 203);
            this.btnManageCostType.Name = "btnManageCostType";
            this.btnManageCostType.Size = new System.Drawing.Size(258, 44);
            this.btnManageCostType.TabIndex = 2;
            this.btnManageCostType.Text = "LOẠI CHI PHÍ";
            this.btnManageCostType.UseVisualStyleBackColor = true;
            this.btnManageCostType.Click += new System.EventHandler(this.btnManageCostType_Click);
            // 
            // btnManageJob
            // 
            this.btnManageJob.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageJob.Location = new System.Drawing.Point(3, 253);
            this.btnManageJob.Name = "btnManageJob";
            this.btnManageJob.Size = new System.Drawing.Size(258, 44);
            this.btnManageJob.TabIndex = 5;
            this.btnManageJob.Text = "CÔNG VIỆC";
            this.btnManageJob.UseVisualStyleBackColor = true;
            this.btnManageJob.Click += new System.EventHandler(this.btnManageJob_Click);
            // 
            // btnManageTourType
            // 
            this.btnManageTourType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageTourType.Location = new System.Drawing.Point(3, 153);
            this.btnManageTourType.Name = "btnManageTourType";
            this.btnManageTourType.Size = new System.Drawing.Size(258, 44);
            this.btnManageTourType.TabIndex = 1;
            this.btnManageTourType.Text = "LOẠI TOUR";
            this.btnManageTourType.UseVisualStyleBackColor = true;
            this.btnManageTourType.Click += new System.EventHandler(this.btnManageTourType_Click);
            // 
            // btnManageLocation
            // 
            this.btnManageLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageLocation.Location = new System.Drawing.Point(3, 103);
            this.btnManageLocation.Name = "btnManageLocation";
            this.btnManageLocation.Size = new System.Drawing.Size(258, 44);
            this.btnManageLocation.TabIndex = 0;
            this.btnManageLocation.Text = "ĐỊA ĐIỂM";
            this.btnManageLocation.UseVisualStyleBackColor = true;
            this.btnManageLocation.Click += new System.EventHandler(this.btnManageLocation_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(258, 44);
            this.btnManageCustomer.TabIndex = 3;
            this.btnManageCustomer.Text = "KHÁCH HÀNG";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageEmployee.Location = new System.Drawing.Point(3, 53);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(258, 44);
            this.btnManageEmployee.TabIndex = 4;
            this.btnManageEmployee.Text = "NHÂN VIÊN";
            this.btnManageEmployee.UseVisualStyleBackColor = true;
            // 
            // pnTour
            // 
            this.pnTour.Controls.Add(this.btnTourSearch);
            this.pnTour.Controls.Add(this.label1);
            this.pnTour.Controls.Add(this.comboTourType);
            this.pnTour.Controls.Add(this.tableLayoutPanel3);
            this.pnTour.Controls.Add(this.groupBox2);
            this.pnTour.Controls.Add(this.txtTourSearch);
            this.pnTour.Controls.Add(this.label5);
            this.pnTour.Controls.Add(this.gridViewTour);
            this.pnTour.Controls.Add(this.btnAddTour);
            this.pnTour.Location = new System.Drawing.Point(321, 12);
            this.pnTour.Name = "pnTour";
            this.pnTour.Size = new System.Drawing.Size(931, 657);
            this.pnTour.TabIndex = 5;
            this.pnTour.TabStop = false;
            this.pnTour.Text = "Danh sách tour";
            // 
            // btnTourSearch
            // 
            this.btnTourSearch.Location = new System.Drawing.Point(340, 32);
            this.btnTourSearch.Name = "btnTourSearch";
            this.btnTourSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTourSearch.TabIndex = 7;
            this.btnTourSearch.Text = "Tìm";
            this.btnTourSearch.UseVisualStyleBackColor = true;
            this.btnTourSearch.Click += new System.EventHandler(this.btnTourSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại tour:";
            // 
            // comboTourType
            // 
            this.comboTourType.FormattingEnabled = true;
            this.comboTourType.Location = new System.Drawing.Point(526, 32);
            this.comboTourType.Name = "comboTourType";
            this.comboTourType.Size = new System.Drawing.Size(169, 23);
            this.comboTourType.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnEditTourDetail, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteTour, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnChangeTourStatus, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnEditTourGroup, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(715, 386);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 265);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnEditTourGroup
            // 
            this.btnEditTourGroup.Enabled = false;
            this.btnEditTourGroup.Location = new System.Drawing.Point(3, 69);
            this.btnEditTourGroup.Name = "btnEditTourGroup";
            this.btnEditTourGroup.Size = new System.Drawing.Size(194, 60);
            this.btnEditTourGroup.TabIndex = 2;
            this.btnEditTourGroup.Text = "QUẢN LÍ ĐOÀN";
            this.btnEditTourGroup.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewTourDetail);
            this.groupBox2.Location = new System.Drawing.Point(715, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 328);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch trình";
            // 
            // gridViewTourDetail
            // 
            this.gridViewTourDetail.AllowUserToAddRows = false;
            this.gridViewTourDetail.AllowUserToDeleteRows = false;
            this.gridViewTourDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewTourDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewTourDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTourDetail.Enabled = false;
            this.gridViewTourDetail.Location = new System.Drawing.Point(8, 26);
            this.gridViewTourDetail.MultiSelect = false;
            this.gridViewTourDetail.Name = "gridViewTourDetail";
            this.gridViewTourDetail.ReadOnly = true;
            this.gridViewTourDetail.RowHeadersVisible = false;
            this.gridViewTourDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTourDetail.Size = new System.Drawing.Size(186, 296);
            this.gridViewTourDetail.TabIndex = 0;
            this.gridViewTourDetail.Text = "dataGridView1";
            // 
            // txtTourSearch
            // 
            this.txtTourSearch.Location = new System.Drawing.Point(90, 32);
            this.txtTourSearch.Name = "txtTourSearch";
            this.txtTourSearch.Size = new System.Drawing.Size(244, 23);
            this.txtTourSearch.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tìm kiếm:";
            // 
            // gridViewTour
            // 
            this.gridViewTour.AllowUserToAddRows = false;
            this.gridViewTour.AllowUserToDeleteRows = false;
            this.gridViewTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewTour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTour.Location = new System.Drawing.Point(6, 78);
            this.gridViewTour.MultiSelect = false;
            this.gridViewTour.Name = "gridViewTour";
            this.gridViewTour.ReadOnly = true;
            this.gridViewTour.RowHeadersVisible = false;
            this.gridViewTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTour.Size = new System.Drawing.Size(696, 508);
            this.gridViewTour.TabIndex = 0;
            this.gridViewTour.Text = "dataGridView1";
            this.gridViewTour.Click += new System.EventHandler(this.gridViewTour_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 657);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Quản lí tour du lịch";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnTour.ResumeLayout(false);
            this.pnTour.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTourDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditTourDetail;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox pnTour;
        private System.Windows.Forms.DataGridView gridViewTour;
        private System.Windows.Forms.Button btnChangeTourStatus;
        private System.Windows.Forms.TextBox txtTourSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnManageLocation;
        private System.Windows.Forms.Button btnManageTourType;
        private System.Windows.Forms.Button btnManageCostType;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Button btnManageEmployee;
        private System.Windows.Forms.Button btnManageJob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridViewTourDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTourType;
        private System.Windows.Forms.Button btnTourSearch;
        private System.Windows.Forms.Button btnEditTourGroup;
    }
}