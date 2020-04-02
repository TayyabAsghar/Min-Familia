using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class MemberDetailsForm : Form
    {
        #region Constructor
        public MemberDetailsForm()
        {
            InitializeComponent();
            HeadingLabel.Text = "Add Member";
        }

        public MemberDetailsForm(string MemberCNIC)
        {
            InitializeComponent();
            LoadForm(MemberCNIC);
        }
        #endregion

        #region Fields
        private SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True");
        #endregion

        #region Events
        public void LoadForm(string MemberCNIC)
        {
            HeadingLabel.Text = "Update Member";
            AddIconButton.Text = "Update";
            // put Query Here

            CNICBox.ReadOnly = true;
        }

        #region Leave Box
        private void LeaveBox(TextBox Box, Label WarningLabel)
        {
            if (Box.Text == "")
                WarningLabel.ForeColor = Color.Red;
            else if (!Regex.IsMatch(Box.Text, (string)Box.Tag))
                    WarningLabel.ForeColor = Color.Red;
            Box.Select(0, 0);                     // Move the Cursor to Start.
        }
        #endregion

        #region Enter

        private void NameBox_Enter(object sender, EventArgs e)
        {
            NameWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }

        private void CNICBox_Enter(object sender, EventArgs e)
        {
            CNICWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }

        private void EmailBox_Enter(object sender, EventArgs e)
        {
            EmailWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }

        private void NumberBox_Enter(object sender, EventArgs e)
        {
            NumberWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }

        private void GenderBox_Enter(object sender, EventArgs e)
        {
            GenderWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            PasswordWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }

        private void AddressRichBox_Enter(object sender, EventArgs e)
        {
            AddressWarningLabel.ForeColor = Color.FromArgb(48, 69, 99);
        }
        #endregion

        #region Leave
        private void NameBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(NameBox, NameWarningLabel);
        }

        private void CNICBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(CNICBox, CNICWarningLabel);
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(EmailBox, EmailWarningLabel);
        }

        private void NumberBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(NumberBox, NumberWarningLabel);
        }

        private void GenderBox_Leave(object sender, EventArgs e)
        {
            if (GenderBox.Text == "")
                GenderWarningLabel.ForeColor = Color.Red;
            else
                GenderBox.Select(0, 0);
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(PasswordBox, PasswordWarningLabel);
        }

        private void AddressRichBox_Leave(object sender, EventArgs e)
        {
            if (AddressRichBox.Text == "")
                AddressWarningLabel.ForeColor = Color.Red;
            else
                AddressRichBox.Select(0, 0);                     // Move the Cursor to Start.
        }
        #endregion

        private void AddIconButton_Click(object sender, EventArgs e)
        {
            if (!WarningsActivated())
            {
                using (SqlCommand Command = new SqlCommand(""))
                {
                    //Add
                    //MinFamiliaCon.Open();
                    
                    this.Close(); 
                }
            }
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

        #region Extra Functions
        private bool WarningsActivated()
        {
            if (NameBox.Text == "")
                NameWarningLabel.ForeColor = Color.Red;

            if (EmailBox.Text == "")
                EmailWarningLabel.ForeColor = Color.Red;

            if (GenderBox.Text == "")
                GenderWarningLabel.ForeColor = Color.Red;

            if (PasswordBox.Text == "")
                PasswordWarningLabel.ForeColor = Color.Red;

            if (CNICBox.Text == "")
                CNICWarningLabel.ForeColor = Color.Red;

            if (NumberBox.Text == "")
                NumberWarningLabel.ForeColor = Color.Red;

            if (AddressRichBox.Text == "")
                AddressWarningLabel.ForeColor = Color.Red;

            if ((NameWarningLabel.ForeColor == Color.Red) || (EmailWarningLabel.ForeColor == Color.Red) || (GenderWarningLabel.ForeColor == Color.Red) || (PasswordWarningLabel.ForeColor == Color.Red) || (CNICWarningLabel.ForeColor == Color.Red) || (NumberWarningLabel.ForeColor == Color.Red) || (AddressWarningLabel.ForeColor == Color.Red))
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

        private void MemberDetailsForm_MouseDown(object sender, MouseEventArgs e)
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
