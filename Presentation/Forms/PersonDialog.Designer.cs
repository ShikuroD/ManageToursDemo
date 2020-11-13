
namespace Presentation.Forms
{
    partial class PersonDialog<T>
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtIdentityCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.lblIdentityCodeError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "CMND:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 148);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(409, 23);
            this.txtAddress.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(344, 115);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(146, 23);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtIdentityCode
            // 
            this.txtIdentityCode.Location = new System.Drawing.Point(81, 112);
            this.txtIdentityCode.Name = "txtIdentityCode";
            this.txtIdentityCode.Size = new System.Drawing.Size(146, 23);
            this.txtIdentityCode.TabIndex = 8;
            this.txtIdentityCode.TextChanged += new System.EventHandler(this.txtIdentityCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(461, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 53);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(334, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 53);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 23);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(63, 16);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(121, 23);
            this.txtId.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên:";
            // 
            // comboSex
            // 
            this.comboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Location = new System.Drawing.Point(434, 55);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(121, 23);
            this.comboSex.TabIndex = 7;
            // 
            // lblIdentityCodeError
            // 
            this.lblIdentityCodeError.AutoSize = true;
            this.lblIdentityCodeError.ForeColor = System.Drawing.Color.Red;
            this.lblIdentityCodeError.Location = new System.Drawing.Point(86, 92);
            this.lblIdentityCodeError.Name = "lblIdentityCodeError";
            this.lblIdentityCodeError.Size = new System.Drawing.Size(142, 15);
            this.lblIdentityCodeError.TabIndex = 14;
            this.lblIdentityCodeError.Text = "* CMND phải là 10 chữ số";
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(353, 93);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(126, 15);
            this.lblPhoneError.TabIndex = 15;
            this.lblPhoneError.Text = "* SĐT phải là 10 chữ số";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(216, 37);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(148, 15);
            this.lblNameError.TabIndex = 16;
            this.lblNameError.Text = "* Tên không được để trống";
            // 
            // PersonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 264);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.lblIdentityCodeError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIdentityCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "PersonDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtIdentityCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.Label lblIdentityCodeError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblNameError;
    }
}