using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class TeamDetailsForm : Form
    {
        #region Constructor
        public TeamDetailsForm()
        {
            InitializeComponent();
            HeadingLabel.Text = "Add Team";
        }

        public TeamDetailsForm(string TeamID)
        {
            InitializeComponent();
            LoadForm(TeamID);
        }
        #endregion

        #region Grid
        private void PopulateGrid()
        {
            MemberGrid.Rows.Add('1', "Drive-1", "33303-7405121-9", "Survey Drive #1", "Tayyab Asghar", "33303-7405121-9");
        }
        #endregion

        #region Events
        public void LoadForm(string MemberCNIC)
        {
            HeadingLabel.Text = "Update Team";
            // put Query Here
        }

        private void AddIconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelIconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HeadCNICBox_TextChanged(object sender, EventArgs e)
        {
           PopulateGrid();
        }

        private void MemberGrid_DoubleClick(object sender, EventArgs e)
        {
           HeadNameBox.Text = (string)MemberGrid.Rows[MemberGrid.CurrentCell.RowIndex].Cells[1].Value;
           HeadCNICBox.Text = (string)MemberGrid.Rows[MemberGrid.CurrentCell.RowIndex].Cells[2].Value;
        }
        #endregion

        #region FormMovement
        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TeamDetailsForm_MouseDown(object sender, MouseEventArgs e)
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
