using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm(string Message1)
        {
            InitializeComponent();
            LoadForm(Message1);
        }

        #region Events
        public void LoadForm(string Message1)
        {
            HeadingLabel1.Text = Message1;
            HeadingLabel2.Text = "";
            YesIconButton.Text = "OK";
            YesIconButton.Location = new Point(86, 181);
            NoIconButton.Hide();
        }

        private void YesIconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NoIconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseIconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
