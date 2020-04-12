using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
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

        public TeamDetailsForm(DataGridViewRow SelectedRow)
        {
            InitializeComponent();
            LoadForm(SelectedRow);
        }
        #endregion

        #region Grid
        private void PopulateGrid()
        {
            try
            {
                using (SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True"))
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Familia_MembersData WHERE Familia_Member_Team_ID = NULL;", MinFamiliaCon))
                {
                    MinFamiliaCon.Open();
                    using (SqlDataReader DataReader = Command.ExecuteReader())
                    {
                        int Count = 1;

                        MemberGrid.Rows.Clear();                // Clearing the Rows.

                        while (DataReader.Read())
                        {
                            DataGridViewRow Rows = new DataGridViewRow();  // Each time provide new Row.

                            Rows.CreateCells(MemberGrid);       // Create cells in DataGridViewRows Same as MemberGrid

                            Rows.Cells[0].Value = Count++;
                            Rows.Cells[1].Value = Convert.ToString(DataReader["Familia_Member_Name"]);
                            Rows.Cells[2].Value = Convert.ToString(DataReader["Familia_Member_CNIC"]);
                            Rows.Cells[3].Value = Convert.ToString(DataReader["Familia_Member_Email"]);
                            Rows.Cells[4].Value = Convert.ToString(DataReader["Familia_Member_Gender"]);
                            Rows.Cells[5].Value = Convert.ToString(DataReader["Familia_Member_Address"]);

                            MemberGrid.Rows.Add(Rows);          // Add DataGridViewRows in MemberGrid
                        }
                    }
                }
            }
            catch
            {
                _ = MessageBox.Show("Unexpected Connection Error Occurred.", "DataBase Error"); // Discards are write-only variables.
                Application.Exit();
            }
        }
        #endregion

        #region Events
        public void LoadForm(DataGridViewRow SelectedRow)
        {
            HeadingLabel.Text = "Update Team";
            TeamIDBox.ReadOnly = true;

            TeamIDBox.Text     = Convert.ToString(SelectedRow.Cells[1].Value);
            TeamNameBox.Text   = Convert.ToString(SelectedRow.Cells[2].Value);
            HeadNameBox.Text   = Convert.ToString(SelectedRow.Cells[3].Value);
            CNICMaskedBox.Text = Convert.ToString(SelectedRow.Cells[4].Value);
        }

        #region Enter Box
        private void TeamNameBox_Enter(object sender, EventArgs e)
        {
            TeamNameWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }

        private void TeamIDBox_Enter(object sender, EventArgs e)
        {
            TeamIDWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }

        private void HeadNameBox_Enter(object sender, EventArgs e)
        {
            HeadNameWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }

        private void CNICMaskedBox_Enter(object sender, EventArgs e)
        {
            CNICWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }
        #endregion

        #region Leave Box
        private void TeamNameBox_Leave(object sender, EventArgs e)
        {
            if ((TeamNameBox.Text == "") || (!Regex.IsMatch(TeamNameBox.Text, "^[a-zA-Z0-9]+([ -]?[a-zA-Z0-9])*$")))
                TeamNameWarningLabel.ForeColor = Color.Red;
            TeamNameBox.Select(0, 0);
        }

        private void TeamIDBox_Leave(object sender, EventArgs e)
        {
            if ((HeadNameBox.Text == "")/* || (!Regex.IsMatch(HeadNameBox.Text, ""))*/)
                HeadNameWarningLabel.ForeColor = Color.Red;
        }

        private void HeadNameBox_Leave(object sender, EventArgs e)
        {
            if ((HeadNameBox.Text == "") || (!Regex.IsMatch(HeadNameBox.Text, "^[a-zA-Z]+([ -]?[a-zA-Z])*$")))
                HeadNameWarningLabel.ForeColor = Color.Red;
            HeadNameBox.Select(0, 0);
        }

        private void CNICMaskedBox_Leave(object sender, EventArgs e)
        {
            if (!CNICMaskedBox.MaskCompleted)
                HeadNameWarningLabel.ForeColor = Color.Red;
        }
        #endregion

        #region Click / Double Click
        private void AddIconButton_Click(object sender, EventArgs e)
        {
            if (!WarningsActivated())
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void CancelIconButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void HeadBox_TextChanged(object sender, EventArgs e)
        {
           PopulateGrid();
        }

        private void FormPanel_Click(object sender, EventArgs e)
        {
            FormPanel.Focus();
        }

        private void MemberGrid_DoubleClick(object sender, EventArgs e)
        {
           HeadNameBox.Text = (string)MemberGrid.Rows[MemberGrid.CurrentCell.RowIndex].Cells[1].Value;
           CNICMaskedBox.Text = (string)MemberGrid.Rows[MemberGrid.CurrentCell.RowIndex].Cells[2].Value;
        }
        #endregion
        #endregion

        #region Extra Functions
        private bool WarningsActivated()
        {
            if (TeamNameBox.Text == "")
                TeamNameWarningLabel.ForeColor = Color.Red;

            if (TeamIDBox.Text == "")
                TeamIDWarningLabel.ForeColor = Color.Red;

            if (HeadNameBox.Text == "")
                HeadNameWarningLabel.ForeColor = Color.Red;

            if (!CNICMaskedBox.MaskCompleted)
                CNICWarningLabel.ForeColor = Color.Red;

            if ((TeamNameWarningLabel.ForeColor == Color.Red) || (TeamIDWarningLabel.ForeColor == Color.Red) || (HeadNameWarningLabel.ForeColor == Color.Red) || (CNICWarningLabel.ForeColor == Color.Red))
                return true;
            return false;
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
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
        #endregion
    }
}
