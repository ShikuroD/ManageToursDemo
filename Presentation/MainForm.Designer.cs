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
            this.pnTableTourButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditTour = new System.Windows.Forms.Button();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.btnChangeTourStatus = new System.Windows.Forms.Button();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.pnTourInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTourDetail = new System.Windows.Forms.Button();
            this.btnManagePrice = new System.Windows.Forms.Button();
            this.btnManageGroup = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.txtTourType = new System.Windows.Forms.TextBox();
            this.txtTourId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnManageCostType = new System.Windows.Forms.Button();
            this.btnManageTourType = new System.Windows.Forms.Button();
            this.btnManageLocation = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTourSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridViewTour = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnTableTourButton.SuspendLayout();
            this.pnTourInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTableTourButton
            // 
            this.pnTableTourButton.ColumnCount = 3;
            this.pnTableTourButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnTableTourButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnTableTourButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnTableTourButton.Controls.Add(this.btnEditTour, 0, 0);
            this.pnTableTourButton.Controls.Add(this.btnDeleteTour, 2, 0);
            this.pnTableTourButton.Controls.Add(this.btnChangeTourStatus, 1, 0);
            this.pnTableTourButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnTableTourButton.Location = new System.Drawing.Point(34, 348);
            this.pnTableTourButton.Name = "pnTableTourButton";
            this.pnTableTourButton.RowCount = 1;
            this.pnTableTourButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnTableTourButton.Size = new System.Drawing.Size(315, 65);
            this.pnTableTourButton.TabIndex = 2;
            // 
            // btnEditTour
            // 
            this.btnEditTour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditTour.Enabled = false;
            this.btnEditTour.Location = new System.Drawing.Point(3, 3);
            this.btnEditTour.Name = "btnEditTour";
            this.btnEditTour.Size = new System.Drawing.Size(99, 59);
            this.btnEditTour.TabIndex = 0;
            this.btnEditTour.Text = "CẬP NHẬT";
            this.btnEditTour.UseVisualStyleBackColor = false;
            this.btnEditTour.Click += new System.EventHandler(this.btnEditTour_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteTour.Enabled = false;
            this.btnDeleteTour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteTour.Location = new System.Drawing.Point(213, 3);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(99, 59);
            this.btnDeleteTour.TabIndex = 0;
            this.btnDeleteTour.Text = "XÓA";
            this.btnDeleteTour.UseVisualStyleBackColor = false;
            // 
            // btnChangeTourStatus
            // 
            this.btnChangeTourStatus.Enabled = false;
            this.btnChangeTourStatus.Location = new System.Drawing.Point(108, 3);
            this.btnChangeTourStatus.Name = "btnChangeTourStatus";
            this.btnChangeTourStatus.Size = new System.Drawing.Size(99, 59);
            this.btnChangeTourStatus.TabIndex = 1;
            this.btnChangeTourStatus.Text = "ẨN";
            this.btnChangeTourStatus.UseVisualStyleBackColor = true;
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
            // pnTourInfo
            // 
            this.pnTourInfo.Controls.Add(this.tableLayoutPanel1);
            this.pnTourInfo.Controls.Add(this.txtDescription);
            this.pnTourInfo.Controls.Add(this.label4);
            this.pnTourInfo.Controls.Add(this.txtTourName);
            this.pnTourInfo.Controls.Add(this.pnTableTourButton);
            this.pnTourInfo.Controls.Add(this.txtTourType);
            this.pnTourInfo.Controls.Add(this.txtTourId);
            this.pnTourInfo.Controls.Add(this.label3);
            this.pnTourInfo.Controls.Add(this.label2);
            this.pnTourInfo.Controls.Add(this.label1);
            this.pnTourInfo.Location = new System.Drawing.Point(321, 12);
            this.pnTourInfo.Name = "pnTourInfo";
            this.pnTourInfo.Size = new System.Drawing.Size(373, 657);
            this.pnTourInfo.TabIndex = 3;
            this.pnTourInfo.TabStop = false;
            this.pnTourInfo.Text = "Thông tin tour du lịch";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnTourDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnManagePrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnManageGroup, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 450);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 167);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnTourDetail
            // 
            this.btnTourDetail.Enabled = false;
            this.btnTourDetail.Location = new System.Drawing.Point(3, 3);
            this.btnTourDetail.Name = "btnTourDetail";
            this.btnTourDetail.Size = new System.Drawing.Size(309, 49);
            this.btnTourDetail.TabIndex = 0;
            this.btnTourDetail.Text = "Quản lí chi tiết";
            this.btnTourDetail.UseVisualStyleBackColor = true;
            this.btnTourDetail.Click += new System.EventHandler(this.btnTourDetail_Click);
            // 
            // btnManagePrice
            // 
            this.btnManagePrice.Enabled = false;
            this.btnManagePrice.Location = new System.Drawing.Point(3, 58);
            this.btnManagePrice.Name = "btnManagePrice";
            this.btnManagePrice.Size = new System.Drawing.Size(309, 47);
            this.btnManagePrice.TabIndex = 1;
            this.btnManagePrice.Text = "Quản lí giá";
            this.btnManagePrice.UseVisualStyleBackColor = true;
            // 
            // btnManageGroup
            // 
            this.btnManageGroup.Enabled = false;
            this.btnManageGroup.Location = new System.Drawing.Point(3, 113);
            this.btnManageGroup.Name = "btnManageGroup";
            this.btnManageGroup.Size = new System.Drawing.Size(309, 51);
            this.btnManageGroup.TabIndex = 2;
            this.btnManageGroup.Text = "Quản lí đoàn khách";
            this.btnManageGroup.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 199);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(249, 121);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô tả:";
            // 
            // txtTourName
            // 
            this.txtTourName.Location = new System.Drawing.Point(97, 152);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.ReadOnly = true;
            this.txtTourName.Size = new System.Drawing.Size(249, 23);
            this.txtTourName.TabIndex = 5;
            // 
            // txtTourType
            // 
            this.txtTourType.Location = new System.Drawing.Point(97, 105);
            this.txtTourType.Name = "txtTourType";
            this.txtTourType.ReadOnly = true;
            this.txtTourType.Size = new System.Drawing.Size(249, 23);
            this.txtTourType.TabIndex = 4;
            // 
            // txtTourId
            // 
            this.txtTourId.Location = new System.Drawing.Point(97, 56);
            this.txtTourId.Name = "txtTourId";
            this.txtTourId.ReadOnly = true;
            this.txtTourId.Size = new System.Drawing.Size(93, 23);
            this.txtTourId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại tour:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tour:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(11, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quán lí thông tin hệ thống";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnManageCostType, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnManageTourType, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnManageLocation, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnManageCustomer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnManageEmployee, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 257);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnManageCostType
            // 
            this.btnManageCostType.Location = new System.Drawing.Point(3, 207);
            this.btnManageCostType.Name = "btnManageCostType";
            this.btnManageCostType.Size = new System.Drawing.Size(258, 47);
            this.btnManageCostType.TabIndex = 2;
            this.btnManageCostType.Text = "LOẠI CHI PHÍ";
            this.btnManageCostType.UseVisualStyleBackColor = true;
            // 
            // btnManageTourType
            // 
            this.btnManageTourType.Location = new System.Drawing.Point(3, 156);
            this.btnManageTourType.Name = "btnManageTourType";
            this.btnManageTourType.Size = new System.Drawing.Size(258, 45);
            this.btnManageTourType.TabIndex = 1;
            this.btnManageTourType.Text = "LOẠI TOUR";
            this.btnManageTourType.UseVisualStyleBackColor = true;
            // 
            // btnManageLocation
            // 
            this.btnManageLocation.Location = new System.Drawing.Point(3, 105);
            this.btnManageLocation.Name = "btnManageLocation";
            this.btnManageLocation.Size = new System.Drawing.Size(258, 45);
            this.btnManageLocation.TabIndex = 0;
            this.btnManageLocation.Text = "ĐỊA ĐIỂM";
            this.btnManageLocation.UseVisualStyleBackColor = true;
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(258, 45);
            this.btnManageCustomer.TabIndex = 3;
            this.btnManageCustomer.Text = "KHÁCH HÀNG";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.Location = new System.Drawing.Point(3, 54);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(258, 45);
            this.btnManageEmployee.TabIndex = 4;
            this.btnManageEmployee.Text = "NHÂN VIÊN";
            this.btnManageEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTourSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gridViewTour);
            this.groupBox2.Controls.Add(this.btnAddTour);
            this.groupBox2.Location = new System.Drawing.Point(700, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 657);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tour";
            // 
            // txtTourSearch
            // 
            this.txtTourSearch.Location = new System.Drawing.Point(90, 32);
            this.txtTourSearch.Name = "txtTourSearch";
            this.txtTourSearch.Size = new System.Drawing.Size(284, 23);
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
            this.gridViewTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTour.Location = new System.Drawing.Point(6, 78);
            this.gridViewTour.Name = "gridViewTour";
            this.gridViewTour.ReadOnly = true;
            this.gridViewTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTour.Size = new System.Drawing.Size(540, 508);
            this.gridViewTour.TabIndex = 0;
            this.gridViewTour.Text = "dataGridView1";
            this.gridViewTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTour_CellContentClick);
            this.gridViewTour.Click += new System.EventHandler(this.gridViewTour_Click);
            // 
            // panel1
            // 
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnTourInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Quản lí tour du lịch";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnTableTourButton.ResumeLayout(false);
            this.pnTourInfo.ResumeLayout(false);
            this.pnTourInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pnTableTourButton;
        private System.Windows.Forms.Button btnEditTour;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.GroupBox pnTourInfo;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.TextBox txtTourType;
        private System.Windows.Forms.TextBox txtTourId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTourDetail;
        private System.Windows.Forms.Button btnManagePrice;
        private System.Windows.Forms.Button btnManageGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}