
namespace Presentation.Forms
{
    partial class CostDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.comboCostType = new System.Windows.Forms.ComboBox();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblValueError = new System.Windows.Forms.Label();
            this.lblCostTYpeError = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại chi phí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chi phí:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 23);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(121, 142);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(191, 23);
            this.txtValue.TabIndex = 5;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(121, 192);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 119);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "";
            // 
            // comboCostType
            // 
            this.comboCostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCostType.FormattingEnabled = true;
            this.comboCostType.Location = new System.Drawing.Point(121, 39);
            this.comboCostType.Name = "comboCostType";
            this.comboCostType.Size = new System.Drawing.Size(191, 23);
            this.comboCostType.TabIndex = 7;
            this.comboCostType.SelectedIndexChanged += new System.EventHandler(this.comboCostType_SelectedIndexChanged);
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(144, 72);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(148, 15);
            this.lblNameError.TabIndex = 8;
            this.lblNameError.Text = "* Tên không được để trống";
            this.lblNameError.Visible = false;
            // 
            // lblValueError
            // 
            this.lblValueError.AutoSize = true;
            this.lblValueError.ForeColor = System.Drawing.Color.Red;
            this.lblValueError.Location = new System.Drawing.Point(144, 124);
            this.lblValueError.Name = "lblValueError";
            this.lblValueError.Size = new System.Drawing.Size(99, 15);
            this.lblValueError.TabIndex = 9;
            this.lblValueError.Text = "* Giá trị phải là số";
            this.lblValueError.Visible = false;
            // 
            // lblCostTYpeError
            // 
            this.lblCostTYpeError.AutoSize = true;
            this.lblCostTYpeError.ForeColor = System.Drawing.Color.Red;
            this.lblCostTYpeError.Location = new System.Drawing.Point(144, 21);
            this.lblCostTYpeError.Name = "lblCostTYpeError";
            this.lblCostTYpeError.Size = new System.Drawing.Size(129, 15);
            this.lblCostTYpeError.TabIndex = 10;
            this.lblCostTYpeError.Text = "* Loại chi phí đã tồn tại";
            this.lblCostTYpeError.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(42, 347);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(123, 41);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 41);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CostDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 400);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCostTYpeError);
            this.Controls.Add(this.lblValueError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.comboCostType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CostDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi phí";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox comboCostType;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblValueError;
        private System.Windows.Forms.Label lblCostTYpeError;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}