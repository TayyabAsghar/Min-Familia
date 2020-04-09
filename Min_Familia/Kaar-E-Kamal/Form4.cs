using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class DetailsForm : Form
    {
        #region Constructor
        public DetailsForm(string Parent)  // Add Form
        {
            InitializeComponent();
            if (Parent == "MembersForm")
            {
                Query = "INSERT INTO Familia_MembersData VALUES(@CNIC, @Password, @Name, @Gender, @Email, @Phone, @Address, NULL);";
                HeadingLabel.Text = "Add Member"; 
            }
            else
            {
                HeadingLabel.Text = "Add Reference";
                Query = "";
                Passlabel.Hide();
                PasswordBox.Hide();
            }
        }

        public DetailsForm(string Parent, string CNIC)  // Update Form
        {
            InitializeComponent();
            LoadForm(Parent, CNIC);
        }
        #endregion

        #region Fields
        private string Query { set; get; }
        #endregion

        #region Events
        public void LoadForm(string Parent, string CNIC)
        {
            Passlabel.Hide();
            PasswordBox.Hide();
            IconButton.Text = "Update";
            CNICMaskedBox.Text = CNIC;
            CNICMaskedBox.ReadOnly = true;

            if (Parent == "MembersForm")
            {
                HeadingLabel.Text = "Update Member";
                Query = "UPDATE Familia_MembersData SET Familia_Member_Name = @Name, Familia_Member_Gender = @Gender, Familia_Member_Email = @Email, Familia_Member_Phone = @Phone, Familia_Member_Address = @Address WHERE Familia_Member_CNIC = @CNIC;";
                PopulateBoxes("SELECT Familia_Member_Name Name, Familia_Member_Email Email, Familia_Member_Phone Number, Familia_Member_Address Address, Familia_Member_Gender Gender FROM Familia_MembersData WHERE Familia_Member_CNIC = @CNIC;");
            }
            else
            {
                HeadingLabel.Text = "Update Reference";
                Query = "";
                PopulateBoxes("");
            }
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

        private void CNICMaskedBox_Enter(object sender, EventArgs e)
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

        private void CNICMaskedBox_Leave(object sender, EventArgs e)
        {
            if (!CNICMaskedBox.ReadOnly)  // Only Check If Read only False.
                if (!CNICMaskedBox.MaskCompleted || AlreadyAdded())  // AlredyAdded() will only run on MaskCompleted. 
                    CNICWarningLabel.ForeColor = Color.Red;
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            EmailBox.Text = EmailBox.Text.TrimEnd(' ');
            LeaveBox(EmailBox, EmailWarningLabel);
        }

        private void NumberBox_Leave(object sender, EventArgs e)
        {
            NumberBox.Text = NumberBox.Text.TrimEnd(' ');
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
            if (AddressRichBox.Text == "" || AddressRichBox.Text.Contains("="))
                AddressWarningLabel.ForeColor = Color.Red;
            else
            {
                AddressRichBox.Text = AddressRichBox.Text.TrimEnd(' ');
                AddressRichBox.Select(0, 0);            // Move the Cursor to Start.
            }
        }
        #endregion

        #region Click Events
        private void IconButton_Click(object sender, EventArgs e)
        {
            if (!WarningsActivated())
                using (SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True"))
                    using (SqlCommand Command = new SqlCommand(Query, MinFamiliaCon))
                    {
                        Command.Parameters.AddWithValue("@CNIC", CNICMaskedBox.Text);
                        Command.Parameters.AddWithValue("@Password", PasswordBox.Text);
                        Command.Parameters.AddWithValue("@Name", NameBox.Text);
                        Command.Parameters.AddWithValue("@Gender", GenderBox.Text);
                        Command.Parameters.AddWithValue("@Email", EmailBox.Text);
                        Command.Parameters.AddWithValue("@Phone", NumberBox.Text);
                        Command.Parameters.AddWithValue("@Address", AddressRichBox.Text);

                        MinFamiliaCon.Open();
                        Command.ExecuteNonQuery();
                        this.DialogResult = DialogResult.Yes;   // To show Changes are made in DataBase;
                        this.Close();
                    }
        }

        private void CancelIconButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void FormPanel_Click(object sender, EventArgs e)
        {
            FormPanel.Focus();
        }
        #endregion


        private void GenderBox_TextChanged(object sender, EventArgs e)
        {
            if (!GenderBox.Items.Contains(GenderBox.Text))      // So user can only select from List.
                GenderBox.Text = "";
        }
        #endregion

        #region Extra Functions
        private void PopulateBoxes(string Query)
        {
            try
            {
                using (SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True"))
                    using (SqlCommand Command = new SqlCommand(Query, MinFamiliaCon))
                    {
                        Command.Parameters.AddWithValue("@CNIC", CNICMaskedBox.Text);   // CNIC is Set in constructor;

                        MinFamiliaCon.Open();

                        using (SqlDataReader DataReader = Command.ExecuteReader())
                            if (DataReader.Read())
                            {
                                NameBox.Text        = Convert.ToString(DataReader["Name"]);
                                EmailBox.Text       = Convert.ToString(DataReader["Email"]);
                                NumberBox.Text      = Convert.ToString(DataReader["Number"]);
                                AddressRichBox.Text = Convert.ToString(DataReader["Address"]);
                                GenderBox.Text      = Convert.ToString(DataReader["Gender"]);
                            }
                    }
            }
            catch
            {
                _ = MessageBox.Show("Unexpected Connection Error Occurred.", "DataBase Error"); // Discards are write-only variables.
                Application.Exit();
            }
        }

        private bool AlreadyAdded()
        {
            try
            {
                string Query = "SELECT CASE WHEN EXISTS (SELECT 1 FROM Familia_AdminData WHERE Familia_Admin_CNIC = @CNIC) OR EXISTS (SELECT 1 FROM Familia_MembersData WHERE Familia_Member_CNIC = @CNIC) THEN 1 ELSE 0 END Present OPTION (OPTIMIZE FOR UNKNOWN);";
                using (SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True"))
                    using (SqlCommand Command = new SqlCommand(Query, MinFamiliaCon))
                    {
                        Command.Parameters.AddWithValue("@CNIC", CNICMaskedBox.Text);
                        MinFamiliaCon.Open();

                        using (SqlDataReader DataReader = Command.ExecuteReader())
                        {
                            if (DataReader.Read())
                                return Convert.ToBoolean(DataReader["Present"]);
                            return false;                 // Maybe it will never executed.
                        }
                    }
            }
            catch
            {
                _ = MessageBox.Show("Unexpected Connection Error Occurred.", "DataBase Error"); // Discards are write-only variables.
                Application.Exit();
                return true;                 // Maybe it will never executed.
            }
        }

        private bool WarningsActivated()
        {
            if (NameBox.Text == "")
                NameWarningLabel.ForeColor = Color.Red;

            if (EmailBox.Text == "")
                EmailWarningLabel.ForeColor = Color.Red;

            if (GenderBox.Text == "")
                GenderWarningLabel.ForeColor = Color.Red;

            if (PasswordBox.Text == "" && PasswordBox.Visible)  // Your not in Update Mode.
                PasswordWarningLabel.ForeColor = Color.Red;

            if (!CNICMaskedBox.MaskCompleted)
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

        private void BorderPanel_MouseDown(object sender, MouseEventArgs e)
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
