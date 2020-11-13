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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridViewGroup = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnChangeStatusGroup = new System.Windows.Forms.Button();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTourSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTourType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewTourDetail = new System.Windows.Forms.DataGridView();
            this.txtTourSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridViewTour = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnTour.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGroup)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTourDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditTourDetail
            // 
            this.btnEditTourDetail.BackColor = System.Drawing.Color.Chocolate;
            this.btnEditTourDetail.Enabled = false;
            this.btnEditTourDetail.FlatAppearance.BorderSize = 2;
            this.btnEditTourDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditTourDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditTourDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTourDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditTourDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditTourDetail.Location = new System.Drawing.Point(833, 307);
            this.btnEditTourDetail.Name = "btnEditTourDetail";
            this.btnEditTourDetail.Size = new System.Drawing.Size(200, 44);
            this.btnEditTourDetail.TabIndex = 0;
            this.btnEditTourDetail.Text = "CẬP NHẬT CHI TIẾT";
            this.btnEditTourDetail.UseVisualStyleBackColor = false;
            this.btnEditTourDetail.Click += new System.EventHandler(this.btnEditTour_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteTour.Enabled = false;
            this.btnDeleteTour.FlatAppearance.BorderSize = 0;
            this.btnDeleteTour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDeleteTour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTour.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteTour.Location = new System.Drawing.Point(281, 3);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(134, 35);
            this.btnDeleteTour.TabIndex = 0;
            this.btnDeleteTour.Text = "XÓA";
            this.btnDeleteTour.UseVisualStyleBackColor = false;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // btnChangeTourStatus
            // 
            this.btnChangeTourStatus.BackColor = System.Drawing.Color.DarkCyan;
            this.btnChangeTourStatus.Enabled = false;
            this.btnChangeTourStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnChangeTourStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnChangeTourStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTourStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeTourStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChangeTourStatus.Location = new System.Drawing.Point(142, 3);
            this.btnChangeTourStatus.Name = "btnChangeTourStatus";
            this.btnChangeTourStatus.Size = new System.Drawing.Size(133, 35);
            this.btnChangeTourStatus.TabIndex = 1;
            this.btnChangeTourStatus.Text = "ẨN";
            this.btnChangeTourStatus.UseVisualStyleBackColor = false;
            this.btnChangeTourStatus.Click += new System.EventHandler(this.btnChangeTourStatus_Click);
            // 
            // btnAddTour
            // 
            this.btnAddTour.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddTour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTour.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddTour.Location = new System.Drawing.Point(3, 3);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(133, 35);
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
            this.groupBox1.Size = new System.Drawing.Size(174, 338);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(161, 302);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnManageCostType
            // 
            this.btnManageCostType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageCostType.Location = new System.Drawing.Point(3, 203);
            this.btnManageCostType.Name = "btnManageCostType";
            this.btnManageCostType.Size = new System.Drawing.Size(155, 44);
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
            this.btnManageJob.Size = new System.Drawing.Size(155, 44);
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
            this.btnManageTourType.Size = new System.Drawing.Size(155, 44);
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
            this.btnManageLocation.Size = new System.Drawing.Size(155, 44);
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
            this.btnManageCustomer.Size = new System.Drawing.Size(155, 44);
            this.btnManageCustomer.TabIndex = 3;
            this.btnManageCustomer.Text = "KHÁCH HÀNG";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageEmployee.Location = new System.Drawing.Point(3, 53);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(155, 44);
            this.btnManageEmployee.TabIndex = 4;
            this.btnManageEmployee.Text = "NHÂN VIÊN";
            this.btnManageEmployee.UseVisualStyleBackColor = true;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // pnTour
            // 
            this.pnTour.Controls.Add(this.groupBox3);
            this.pnTour.Controls.Add(this.btnEditTourDetail);
            this.pnTour.Controls.Add(this.tableLayoutPanel1);
            this.pnTour.Controls.Add(this.btnTourSearch);
            this.pnTour.Controls.Add(this.label1);
            this.pnTour.Controls.Add(this.comboTourType);
            this.pnTour.Controls.Add(this.groupBox2);
            this.pnTour.Controls.Add(this.txtTourSearch);
            this.pnTour.Controls.Add(this.label5);
            this.pnTour.Controls.Add(this.gridViewTour);
            this.pnTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnTour.Location = new System.Drawing.Point(214, 12);
            this.pnTour.Name = "pnTour";
            this.pnTour.Size = new System.Drawing.Size(1038, 657);
            this.pnTour.TabIndex = 5;
            this.pnTour.TabStop = false;
            this.pnTour.Text = "Danh sách tour";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.gridViewGroup);
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(21, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1009, 300);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách đoàn khách";
            // 
            // gridViewGroup
            // 
            this.gridViewGroup.AllowUserToAddRows = false;
            this.gridViewGroup.AllowUserToDeleteRows = false;
            this.gridViewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridViewGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewGroup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewGroup.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewGroup.Location = new System.Drawing.Point(3, 76);
            this.gridViewGroup.MultiSelect = false;
            this.gridViewGroup.Name = "gridViewGroup";
            this.gridViewGroup.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewGroup.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewGroup.RowHeadersVisible = false;
            this.gridViewGroup.RowTemplate.Height = 25;
            this.gridViewGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewGroup.Size = new System.Drawing.Size(864, 221);
            this.gridViewGroup.TabIndex = 5;
            this.gridViewGroup.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridViewGroup_RowPrePaint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteGroup, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnChangeStatusGroup, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnEditGroup, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnAddGroup, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(873, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(133, 278);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteGroup.Enabled = false;
            this.btnDeleteGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDeleteGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteGroup.Location = new System.Drawing.Point(3, 210);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(127, 65);
            this.btnDeleteGroup.TabIndex = 6;
            this.btnDeleteGroup.Text = "XÓA";
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatusGroup
            // 
            this.btnChangeStatusGroup.BackColor = System.Drawing.Color.DarkCyan;
            this.btnChangeStatusGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeStatusGroup.Enabled = false;
            this.btnChangeStatusGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnChangeStatusGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnChangeStatusGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatusGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeStatusGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeStatusGroup.Location = new System.Drawing.Point(3, 141);
            this.btnChangeStatusGroup.Name = "btnChangeStatusGroup";
            this.btnChangeStatusGroup.Size = new System.Drawing.Size(127, 63);
            this.btnChangeStatusGroup.TabIndex = 5;
            this.btnChangeStatusGroup.Text = "ẨN";
            this.btnChangeStatusGroup.UseVisualStyleBackColor = false;
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.BackColor = System.Drawing.Color.Chocolate;
            this.btnEditGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditGroup.Enabled = false;
            this.btnEditGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnEditGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEditGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditGroup.Location = new System.Drawing.Point(3, 72);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(127, 63);
            this.btnEditGroup.TabIndex = 4;
            this.btnEditGroup.Text = "CHI TIẾT";
            this.btnEditGroup.UseVisualStyleBackColor = false;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddGroup.Enabled = false;
            this.btnAddGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddGroup.Location = new System.Drawing.Point(3, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(127, 63);
            this.btnAddGroup.TabIndex = 3;
            this.btnAddGroup.Text = "THÊM";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddTour, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteTour, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeTourStatus, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(409, 310);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 41);
            this.tableLayoutPanel1.TabIndex = 8;
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
            this.comboTourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTourType.FormattingEnabled = true;
            this.comboTourType.Location = new System.Drawing.Point(526, 32);
            this.comboTourType.Name = "comboTourType";
            this.comboTourType.Size = new System.Drawing.Size(301, 23);
            this.comboTourType.TabIndex = 5;
            this.comboTourType.SelectedIndexChanged += new System.EventHandler(this.comboTourType_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewTourDetail);
            this.groupBox2.Location = new System.Drawing.Point(833, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 252);
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
            this.gridViewTourDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewTourDetail.Enabled = false;
            this.gridViewTourDetail.Location = new System.Drawing.Point(3, 19);
            this.gridViewTourDetail.MultiSelect = false;
            this.gridViewTourDetail.Name = "gridViewTourDetail";
            this.gridViewTourDetail.ReadOnly = true;
            this.gridViewTourDetail.RowHeadersVisible = false;
            this.gridViewTourDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTourDetail.Size = new System.Drawing.Size(194, 230);
            this.gridViewTourDetail.TabIndex = 0;
            this.gridViewTourDetail.Text = "dataGridView1";
            // 
            // txtTourSearch
            // 
            this.txtTourSearch.Location = new System.Drawing.Point(90, 32);
            this.txtTourSearch.Name = "txtTourSearch";
            this.txtTourSearch.Size = new System.Drawing.Size(244, 23);
            this.txtTourSearch.TabIndex = 2;
            this.txtTourSearch.TextChanged += new System.EventHandler(this.txtTourSearch_TextChanged);
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
            this.gridViewTour.Location = new System.Drawing.Point(6, 71);
            this.gridViewTour.MultiSelect = false;
            this.gridViewTour.Name = "gridViewTour";
            this.gridViewTour.ReadOnly = true;
            this.gridViewTour.RowHeadersVisible = false;
            this.gridViewTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTour.Size = new System.Drawing.Size(821, 233);
            this.gridViewTour.TabIndex = 0;
            this.gridViewTour.Text = "dataGridView1";
            this.gridViewTour.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridViewTour_RowPrePaint);
            this.gridViewTour.SelectionChanged += new System.EventHandler(this.gridViewTour_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 657);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí tour du lịch";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnTour.ResumeLayout(false);
            this.pnTour.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGroup)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridViewGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnChangeStatusGroup;
        private System.Windows.Forms.Button btnEditGroup;
    }
}