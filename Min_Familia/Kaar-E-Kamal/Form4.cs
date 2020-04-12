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
                Query = "INSERT INTO Familia_MembersData VALUES(@CNIC, @Password, @Name, @Gender, @Email, @Phone, @Address, CURRENT_TIMESTAMP, NULL, NULL);";
                HeadingLabel.Text = "Add Member"; 
            }
            else
            {
                HeadingLabel.Text = "Add Reference";
                Query = "INSERT INTO Familia_MembersData VALUES(@CNIC, @Name, @Email, @Phone, @Address, @Gender, CURRENT_TIMESTAMP, NULL);";
                Passlabel.Hide();
                PasswordBox.Hide();
            }
        }

        public DetailsForm(string Parent, DataGridViewRow SelectedRow)  // Update Form
        {
            InitializeComponent();
            LoadForm(Parent, SelectedRow);
        }
        #endregion

        #region Fields
        private string Query { set; get; }
        #endregion

        #region Events
        public void LoadForm(string Parent, DataGridViewRow SelectedRow)
        {
            Passlabel.Hide();
            PasswordBox.Hide();
            IconButton.Text = "Update";
            PopulateBoxes(SelectedRow);    // Populate Text Boxes

            if (Parent == "MembersForm")
            {
                HeadingLabel.Text = "Update Member";
                Query = "UPDATE Familia_MembersData SET Familia_Member_Name = @Name, Familia_Member_Gender = @Gender, Familia_Member_Email = @Email, Familia_Member_Phone = @Phone, Familia_Member_Address = @Address, Familia_Member_CNIC = @CNIC WHERE Familia_Member_CNIC = @CNIC;";
            }
            else
            {
                HeadingLabel.Text = "Update Reference";
                Query = "UPDATE Familia_ReferencesData SET Familia_Reference_Name = @Name, Familia_Reference_Gender = @Gender, Familia_Reference_Email = @Email, Familia_Reference_Phone = @Phone, Familia_Reference_Address = @Address, Familia_Reference_CNIC = @CNIC WHERE Familia_Reference_CNIC = @CNIC;";
            }
        }

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
            if ((NameBox.Text == "") || (!Regex.IsMatch(NameBox.Text, "^[a-zA-Z]+([ -]?[a-zA-Z])*$")))
                NameWarningLabel.ForeColor = Color.Red;
            NameBox.Select(0, 0);
        }

        private void CNICMaskedBox_Leave(object sender, EventArgs e)
        {
            if (!CNICMaskedBox.MaskCompleted || AlreadyAdded())  // AlredyAdded() will only run on MaskCompleted. 
                CNICWarningLabel.ForeColor = Color.Red;
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            EmailBox.Text = EmailBox.Text.TrimEnd(' ');

            if ((EmailBox.Text == "") || (!Regex.IsMatch(EmailBox.Text, "[a-z0-9!#$%&'*+/?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")))
                EmailWarningLabel.ForeColor = Color.Red;
            EmailBox.Select(0, 0);
        }

        private void NumberBox_Leave(object sender, EventArgs e)
        {
            NumberBox.Text = NumberBox.Text.TrimEnd(' ');

            if ((NumberBox.Text == "") || (!Regex.IsMatch(NumberBox.Text, "^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$")))
                NumberWarningLabel.ForeColor = Color.Red;
            NumberBox.Select(0, 0);
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
            if ((PasswordBox.Text == "") || (!Regex.IsMatch(PasswordBox.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[_\\-@#$%&!<>^*`~?+:,.|])(?!.*[,=;])(?=.{8,})")))
                PasswordWarningLabel.ForeColor = Color.Red;
            PasswordBox.Select(0, 0);
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
                        Command.Parameters.AddWithValue("@Name", NameBox.Text);
                        Command.Parameters.AddWithValue("@Gender", GenderBox.Text);
                        Command.Parameters.AddWithValue("@Email", EmailBox.Text);
                        Command.Parameters.AddWithValue("@Phone", NumberBox.Text);
                        Command.Parameters.AddWithValue("@Address", AddressRichBox.Text);
                        Command.Parameters.AddWithValue("@Password", PasswordBox.Text);

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
        private void PopulateBoxes(DataGridViewRow SelectedRow)
        {
            NameBox.Text        = Convert.ToString(SelectedRow.Cells[1].Value);
            CNICMaskedBox.Text  = Convert.ToString(SelectedRow.Cells[2].Value);
            EmailBox.Text       = Convert.ToString(SelectedRow.Cells[3].Value);
            NumberBox.Text      = Convert.ToString(SelectedRow.Cells[4].Value);
            AddressRichBox.Text = Convert.ToString(SelectedRow.Cells[5].Value);
            GenderBox.Text      = Convert.ToString(SelectedRow.Cells[6].Value);
        }

        private bool AlreadyAdded()
        {
            try
            {
                string Query = "SELECT CASE WHEN EXISTS (SELECT 1 FROM Familia_AdminData WHERE Familia_Admin_CNIC = @CNIC) OR EXISTS (SELECT 1 FROM Familia_MembersData WHERE Familia_Member_CNIC = @CNIC) THEN 1 ELSE 0 END Present;";
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
