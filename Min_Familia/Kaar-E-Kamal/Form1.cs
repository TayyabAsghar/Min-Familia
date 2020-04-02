using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UserSelection = -1;
        }

        #region Fields
        private readonly SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True");
        private int UserSelection { get; set; }  // 1 for Admin, 0 For Member
        #endregion

        #region Events
        #region CloseLable
        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseLabel_MouseHover(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.FromArgb(34, 36, 49);
        }
        #endregion

        #region EnterBox
        private void NameBox_Enter(object sender, EventArgs e)
        {
            EnterBox(NameBox, NamePic, Properties.Resources.login1, NameWarningLabel);
        }

        private void PassBox_Enter(object sender, EventArgs e)
        {
            // Changing UseSystemPasswordChar will trigger Box.Leave() event. So we will place it Outside.
            if (PassBox.TextAlign == HorizontalAlignment.Center)
                PassBox.UseSystemPasswordChar = true;
            EnterBox(PassBox, PasswordPic, Properties.Resources.password__2_, PasswordWarningLabel);
        }

        private void EmailBox_Enter(object sender, EventArgs e)
        {
            EnterBox(EmailBox, EmailPic, Properties.Resources.mail1, EmailWarningLabel);
        }
        #endregion

        #region LeaveBox
        private void NameBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(NameBox, "Username", NamePic, Properties.Resources.login0, NameWarningLabel);
        }

        private void PassBox_Leave(object sender, EventArgs e)
        {
            if (PassBox.Text == "")  // Set the Property to false.
                PassBox.UseSystemPasswordChar = false;
            LeaveBox(PassBox, "Password", PasswordPic, Properties.Resources.password, PasswordWarningLabel);
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(EmailBox, "Someone@something.com", EmailPic, Properties.Resources.mail, EmailWarningLabel);
        }
        #endregion

        #region Pics
        private void MemberPic_Click(object sender, EventArgs e)
        {
            UserSelection = 0;
            AdminPic.BackgroundImage = Properties.Resources.admin0;
            MemberPic.BackgroundImage = Properties.Resources.Member1;
            SignInWarningLabel.ForeColor = Color.FromArgb(34, 36, 49);
            MemberPic.Focus(); // Set Focus on Member Pic.
        }

        private void MemberPic_MouseHover(object sender, EventArgs e)
        {
            MemberPic.BackgroundImage = Properties.Resources.Member1;
        }

        private void MemberPic_MouseLeave(object sender, EventArgs e)
        {
            if (UserSelection != 0)
                MemberPic.BackgroundImage = Properties.Resources.Member0;
        }

        private void AdminPic_Click(object sender, EventArgs e)
        {
            UserSelection = 1;
            MemberPic.BackgroundImage = Properties.Resources.Member0;
            AdminPic.BackgroundImage = Properties.Resources.admin1;
            SignInWarningLabel.ForeColor = Color.FromArgb(34, 36, 49);
            AdminPic.Focus();
        }

        private void AdminPic_MouseHover(object sender, EventArgs e)
        {
            AdminPic.BackgroundImage = Properties.Resources.admin1;
        }

        private void AdminPic_MouseLeave(object sender, EventArgs e)
        {
            if (UserSelection != 1)
                AdminPic.BackgroundImage = Properties.Resources.admin0;
        }
        #endregion
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!WarningsActivation())
            {
                if (!UserValidated())
                    new ConfirmationForm("Some Fields are Incorrect...").Show();
                else
                {
                    this.Hide();

                    if (UserSelection == 1)
                        new MainMenuFormAD().Show();
                    else
                        new MainMenuFormMember(EmailBox.Text).Show();
                } 
            }
        }

        private void FormPanel_Click(object sender, EventArgs e)
        {
            FormPanel.Focus();  // To remove the from TextBox on clicking the Panel
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            ConfirmationFormActivated();
        }
        #endregion

        #region Extra Functions
        #region Enter Or Leave Box
        private void EnterBox(TextBox Box, PictureBox PicBox, Bitmap Pic, Label WarningLabel)
        {
            if ((Box.TextAlign == HorizontalAlignment.Center)) // Only true if User had Left the Box Empty
            {
                Box.Clear();
                Box.TextAlign = HorizontalAlignment.Left;
            }
            PicBox.BackgroundImage = Pic;
            WarningLabel.ForeColor = Color.FromArgb(34, 36, 49);
            Box.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void LeaveBox(TextBox Box, string Text, PictureBox PicBox, Bitmap Pic, Label WarningLabel)
        {
            if (Box.Text == "")
            {
                WarningLabel.ForeColor = Color.Red;
                Box.Text = Text;
                Box.TextAlign = HorizontalAlignment.Center;
                Box.ForeColor = Color.Gray;
            }
            else     // To check the Text Regex.
            {
                if (!Regex.IsMatch(Box.Text, (string)Box.Tag))
                    WarningLabel.ForeColor = Color.Red;
                Box.ForeColor = Color.White;
            }
            PicBox.BackgroundImage = Pic;
            Box.Select(0, 0);                     // Move the Cursor to Start.
        }
        #endregion

        private bool ConfirmationFormActivated()   // Return bool if Form activated and BringToFront it.
        {
            foreach (Form Child in Application.OpenForms)
                if ((string)Child.Tag == "Confirmation")
                {
                    Child.BringToFront();
                    return true;
                }
            return false;
        }

        private bool WarningsActivation()
        {
            if (UserSelection == -1)
                SignInWarningLabel.ForeColor = Color.Red;

            if ((NameBox.TextAlign == HorizontalAlignment.Center))
                NameWarningLabel.ForeColor = Color.Red;

            if (PassBox.TextAlign == HorizontalAlignment.Center)
                PasswordWarningLabel.ForeColor = Color.Red;

            if (EmailBox.TextAlign == HorizontalAlignment.Center)
                EmailWarningLabel.ForeColor = Color.Red;

            if ((SignInWarningLabel.ForeColor == Color.Red) || (NameWarningLabel.ForeColor == Color.Red) || (PasswordWarningLabel.ForeColor == Color.Red) || (EmailWarningLabel.ForeColor == Color.Red))
                return true;
            return false;
        }

        private bool UserValidated()
        {
            String Query;

            if (UserSelection == 1)
                Query = "SELECT Familia_Admin_Name, Familia_Admin_Password FROM Familia_AdminData WHERE Familia_Admin_Email = '" + EmailBox.Text + "'";
            else
                Query = "SELECT Familia_Admin_Name, Familia_Admin_Password FROM Familia_AdminData WHERE Familia_Admin_Email = '" + EmailBox.Text + "'";
            // Just to Learn try/catch and finally block.
            try
            {
                SqlCommand Command = new SqlCommand(Query, MinFamiliaCon);
                MinFamiliaCon.Open();
                SqlDataReader DataReader = Command.ExecuteReader();

                try
                {
                    if (DataReader.Read())      // Reading Data From Con.
                    {
                        if ((NameBox.Text == Convert.ToString(DataReader["Familia_Admin_Name"]) & (PassBox.Text == Convert.ToString(DataReader["Familia_Admin_Password"]))))
                            return true;
                        return false;
                    }
                    return false;
                }
                finally          // Use to hold Close resources statements
                {
                    DataReader.Close();
                    MinFamiliaCon.Close();
                }
            }
            catch      // To catch any Error Occurred due to Data Connection;
            {
                new ConfirmationForm("Unexpected Error Occurred.").Show();
                return false;
            }
        }
        #endregion

        #region Form Movement
            // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
