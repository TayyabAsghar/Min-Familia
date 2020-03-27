using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class ReferencesDetails : Form
    {
        #region Constructor
        public ReferencesDetails()
        {
            InitializeComponent();
            HeadingLabel.Text = "Add Reference";
        }

        public ReferencesDetails(string ReferenceCNIC)
        {
            InitializeComponent();
            LoadForm(ReferenceCNIC);
        }
        #endregion

        #region Events
        public void LoadForm(string ReferenceCNIC)
        {
            HeadingLabel.Text = "Update Reference";
            // put Query Here

            CNICBox.ReadOnly = true;
        }

        private void AddIconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelIconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenderBox_TextChanged(object sender, EventArgs e)
        {
            if (!GenderBox.Items.Contains(GenderBox.Text))
                GenderBox.Text = "";
        }
        #endregion

        #region FormMovement
        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ReferencesDetails_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Close
        private void CloseIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
