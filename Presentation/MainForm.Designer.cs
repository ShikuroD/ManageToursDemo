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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTours = new System.Windows.Forms.TabPage();
            this.pnLocation = new System.Windows.Forms.GroupBox();
            this.btnUpdateLocation = new System.Windows.Forms.Button();
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.listLocation = new System.Windows.Forms.ListView();
            this.LocaId = new System.Windows.Forms.ColumnHeader();
            this.LocaName = new System.Windows.Forms.ColumnHeader();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.tabAnalysis = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabTours.SuspendLayout();
            this.pnLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTours);
            this.tabControl.Controls.Add(this.tabGroups);
            this.tabControl.Controls.Add(this.tabAnalysis);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1240, 657);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabTours
            // 
            this.tabTours.BackColor = System.Drawing.SystemColors.Control;
            this.tabTours.Controls.Add(this.pnLocation);
            this.tabTours.Location = new System.Drawing.Point(4, 34);
            this.tabTours.Name = "tabTours";
            this.tabTours.Padding = new System.Windows.Forms.Padding(3);
            this.tabTours.Size = new System.Drawing.Size(1232, 619);
            this.tabTours.TabIndex = 0;
            this.tabTours.Text = "Tours";
            // 
            // pnLocation
            // 
            this.pnLocation.Controls.Add(this.btnUpdateLocation);
            this.pnLocation.Controls.Add(this.btnDeleteLocation);
            this.pnLocation.Controls.Add(this.btnAddLocation);
            this.pnLocation.Controls.Add(this.listLocation);
            this.pnLocation.Location = new System.Drawing.Point(13, 16);
            this.pnLocation.Name = "pnLocation";
            this.pnLocation.Size = new System.Drawing.Size(200, 584);
            this.pnLocation.TabIndex = 0;
            this.pnLocation.TabStop = false;
            this.pnLocation.Text = "Locations List";
            // 
            // btnUpdateLocation
            // 
            this.btnUpdateLocation.Enabled = false;
            this.btnUpdateLocation.Location = new System.Drawing.Point(7, 540);
            this.btnUpdateLocation.Name = "btnUpdateLocation";
            this.btnUpdateLocation.Size = new System.Drawing.Size(187, 38);
            this.btnUpdateLocation.TabIndex = 1;
            this.btnUpdateLocation.Text = "Update";
            this.btnUpdateLocation.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Enabled = false;
            this.btnDeleteLocation.Location = new System.Drawing.Point(7, 496);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(187, 38);
            this.btnDeleteLocation.TabIndex = 1;
            this.btnDeleteLocation.Text = "Delete";
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(7, 452);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(187, 38);
            this.btnAddLocation.TabIndex = 1;
            this.btnAddLocation.Text = "Add";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            // 
            // listLocation
            // 
            this.listLocation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LocaId,
            this.LocaName});
            this.listLocation.FullRowSelect = true;
            this.listLocation.GridLines = true;
            this.listLocation.HideSelection = false;
            this.listLocation.Location = new System.Drawing.Point(6, 28);
            this.listLocation.Name = "listLocation";
            this.listLocation.Size = new System.Drawing.Size(188, 417);
            this.listLocation.TabIndex = 0;
            this.listLocation.UseCompatibleStateImageBehavior = false;
            this.listLocation.View = System.Windows.Forms.View.Details;
            this.listLocation.SelectedIndexChanged += new System.EventHandler(this.listLocation_SelectedIndexChanged);
            this.listLocation.Leave += new System.EventHandler(this.listLocation_Leave);
            // 
            // LocaId
            // 
            this.LocaId.Text = "ID";
            // 
            // LocaName
            // 
            this.LocaName.Text = "Name";
            this.LocaName.Width = 130;
            // 
            // tabGroups
            // 
            this.tabGroups.BackColor = System.Drawing.SystemColors.Control;
            this.tabGroups.Location = new System.Drawing.Point(4, 34);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroups.Size = new System.Drawing.Size(1232, 619);
            this.tabGroups.TabIndex = 1;
            this.tabGroups.Text = "Groups";
            // 
            // tabAnalysis
            // 
            this.tabAnalysis.BackColor = System.Drawing.SystemColors.Control;
            this.tabAnalysis.Location = new System.Drawing.Point(4, 34);
            this.tabAnalysis.Name = "tabAnalysis";
            this.tabAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalysis.Size = new System.Drawing.Size(1232, 619);
            this.tabAnalysis.TabIndex = 2;
            this.tabAnalysis.Text = "Analysis";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Traveling Tours Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabTours.ResumeLayout(false);
            this.pnLocation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTours;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.TabPage tabAnalysis;
        private System.Windows.Forms.GroupBox pnLocation;
        private System.Windows.Forms.Button btnUpdateLocation;
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.ListView listLocation;
        private System.Windows.Forms.ColumnHeader LocaId;
        private System.Windows.Forms.ColumnHeader LocaName;
    }
}