namespace Presentation.Forms
{
    partial class TourDetailDialog
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
            this.listLocation = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveRoute = new System.Windows.Forms.Button();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.listRoute = new System.Windows.Forms.ListBox();
            this.lbId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTourType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPrice = new System.Windows.Forms.Button();
            this.btnEditPrice = new System.Windows.Forms.Button();
            this.btnChangePriceStatus = new System.Windows.Forms.Button();
            this.gridPrice = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // listLocation
            // 
            this.listLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listLocation.FormattingEnabled = true;
            this.listLocation.ItemHeight = 15;
            this.listLocation.Location = new System.Drawing.Point(7, 54);
            this.listLocation.Name = "listLocation";
            this.listLocation.Size = new System.Drawing.Size(170, 259);
            this.listLocation.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRemoveRoute);
            this.groupBox1.Controls.Add(this.btnAddRoute);
            this.groupBox1.Controls.Add(this.listRoute);
            this.groupBox1.Controls.Add(this.listLocation);
            this.groupBox1.Location = new System.Drawing.Point(362, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập lịch trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lịch trình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách địa điểm";
            // 
            // btnRemoveRoute
            // 
            this.btnRemoveRoute.Location = new System.Drawing.Point(187, 202);
            this.btnRemoveRoute.Name = "btnRemoveRoute";
            this.btnRemoveRoute.Size = new System.Drawing.Size(32, 35);
            this.btnRemoveRoute.TabIndex = 3;
            this.btnRemoveRoute.Text = "<<";
            this.btnRemoveRoute.UseVisualStyleBackColor = true;
            this.btnRemoveRoute.Click += new System.EventHandler(this.btnRemoveRoute_Click);
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(187, 131);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(32, 35);
            this.btnAddRoute.TabIndex = 2;
            this.btnAddRoute.Text = ">>";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // listRoute
            // 
            this.listRoute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listRoute.FormattingEnabled = true;
            this.listRoute.ItemHeight = 15;
            this.listRoute.Location = new System.Drawing.Point(225, 54);
            this.listRoute.Name = "listRoute";
            this.listRoute.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listRoute.Size = new System.Drawing.Size(170, 259);
            this.listRoute.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(21, 32);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 15);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên tour:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 29);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(111, 23);
            this.txtId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại:";
            // 
            // comboTourType
            // 
            this.comboTourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTourType.FormattingEnabled = true;
            this.comboTourType.Location = new System.Drawing.Point(80, 104);
            this.comboTourType.Name = "comboTourType";
            this.comboTourType.Size = new System.Drawing.Size(258, 23);
            this.comboTourType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mô tả:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(80, 143);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(258, 154);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.gridPrice);
            this.groupBox2.Location = new System.Drawing.Point(16, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 250);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng giá";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddPrice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnChangePriceStatus, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(619, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(122, 222);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPrice.Location = new System.Drawing.Point(3, 3);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(116, 68);
            this.btnAddPrice.TabIndex = 0;
            this.btnAddPrice.Text = "THÊM";
            this.btnAddPrice.UseVisualStyleBackColor = true;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // btnEditPrice
            // 
            this.btnEditPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditPrice.Enabled = false;
            this.btnEditPrice.Location = new System.Drawing.Point(3, 77);
            this.btnEditPrice.Name = "btnEditPrice";
            this.btnEditPrice.Size = new System.Drawing.Size(116, 68);
            this.btnEditPrice.TabIndex = 1;
            this.btnEditPrice.Text = "CẬP NHẬT";
            this.btnEditPrice.UseVisualStyleBackColor = true;
            this.btnEditPrice.Click += new System.EventHandler(this.btnEditPrice_Click);
            // 
            // btnChangePriceStatus
            // 
            this.btnChangePriceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangePriceStatus.Enabled = false;
            this.btnChangePriceStatus.Location = new System.Drawing.Point(3, 151);
            this.btnChangePriceStatus.Name = "btnChangePriceStatus";
            this.btnChangePriceStatus.Size = new System.Drawing.Size(116, 68);
            this.btnChangePriceStatus.TabIndex = 2;
            this.btnChangePriceStatus.Text = "ẨN";
            this.btnChangePriceStatus.UseVisualStyleBackColor = true;
            this.btnChangePriceStatus.Click += new System.EventHandler(this.btnChangePriceStatus_Click);
            // 
            // gridPrice
            // 
            this.gridPrice.AllowUserToAddRows = false;
            this.gridPrice.AllowUserToDeleteRows = false;
            this.gridPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPrice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrice.Location = new System.Drawing.Point(6, 22);
            this.gridPrice.MultiSelect = false;
            this.gridPrice.Name = "gridPrice";
            this.gridPrice.ReadOnly = true;
            this.gridPrice.RowHeadersVisible = false;
            this.gridPrice.RowTemplate.Height = 25;
            this.gridPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrice.Size = new System.Drawing.Size(607, 222);
            this.gridPrice.TabIndex = 0;
            this.gridPrice.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridPrice_RowPrePaint);
            this.gridPrice.SelectionChanged += new System.EventHandler(this.gridPrice_SelectionChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(443, 605);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(138, 41);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(625, 605);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 41);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TourDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 657);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTourType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.groupBox1);
            this.Name = "TourDetailDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết tour";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveRoute;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.ListBox listRoute;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTourType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddPrice;
        private System.Windows.Forms.Button btnEditPrice;
        private System.Windows.Forms.Button btnChangePriceStatus;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}