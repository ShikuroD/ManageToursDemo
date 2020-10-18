using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog()
        {
            InitializeComponent();
        }

        public bool Show(string message)
        {
            this.lbQuestion.Text = message;
            var res = this.ShowDialog();

            if (res.Equals(DialogResult.OK)) return true;
            else return false;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
