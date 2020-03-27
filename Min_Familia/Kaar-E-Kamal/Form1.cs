using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
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
        SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Min_Familia;Integrated Security=True");
        public int UserSelection { get; set; }  // 1 for Admin, 0 For Member
        #endregion

        #region Enter Or Leave Box
        public void EnterBox(TextBox Box, string Text, PictureBox PicBox, Bitmap Pic, Label WarningLabel)
        {
            if ((Box.Text == Text) && (Box.TextAlign == HorizontalAlignment.Center))
            {
                Box.Clear();
                WarningLabel.ForeColor = Color.FromArgb(34, 36, 49);
                Box.TextAlign = HorizontalAlignment.Left;

                if (Box == PasswordBox)
                    Box.UseSystemPasswordChar = true;
            }
            PicBox.BackgroundImage = Pic;
            Box.ForeColor = Color.FromArgb(78, 184, 206);
        }

        public void LeaveBox(TextBox Box, string Text, PictureBox PicBox, Bitmap Pic, Label WarningLabel)
        {
            if (Box.Text == "")
            {
                if (Box == PasswordBox)
                    Box.UseSystemPasswordChar = false;

                WarningLabel.ForeColor = Color.Red;
                Box.Text = Text;
                Box.TextAlign = HorizontalAlignment.Center;
                Box.ForeColor = Color.Gray;
            }
            else
                Box.ForeColor = Color.White;
            PicBox.BackgroundImage = Pic;
        }
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
            EnterBox(NameBox, "Username", NamePic, Properties.Resources.login1, NameWarningLabel);
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            EnterBox(PasswordBox, "Password", PasswordPic, Properties.Resources.password__2_, PasswordWarningLabel);
        }

        private void EmailBox_Enter(object sender, EventArgs e)
        {
            EnterBox(EmailBox, "Someone@something.com", EmailPic, Properties.Resources.mail1, EmailWarningLabel);
        }
        #endregion

        #region LeaveBox
        private void NameBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(NameBox, "Username", NamePic, Properties.Resources.login0, NameWarningLabel);
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(PasswordBox, "Password", PasswordPic, Properties.Resources.password, PasswordWarningLabel);
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            LeaveBox(EmailBox, "Someone@something.com", EmailPic, Properties.Resources.mail, EmailWarningLabel);
        }
        #endregion

        #region Pics
        private void MemberPic_Click(object sender, EventArgs e)
        {
            AdminPic.BackgroundImage = Properties.Resources.admin0;
            MemberPic.BackgroundImage = Properties.Resources.Member1;
            UserSelection = 0;
            SignInWarningLabel.ForeColor = Color.FromArgb(34, 36, 49);
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
            MemberPic.BackgroundImage = Properties.Resources.Member0;
            AdminPic.BackgroundImage = Properties.Resources.admin1;
            UserSelection = 1;
            SignInWarningLabel.ForeColor = Color.FromArgb(34, 36, 49);
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
            if (WarningsActivated())
                new ConfirmationForm("Please Fill All the Fields...").Show();
            else if (!UserValidated())
            {
                if (!ConfirmationFormActivated())  // Form has been activated if There was any con Problem
                    new ConfirmationForm("Some Fields are Incorrect...").Show();
            }
            else
            {
                this.Hide();

                if (UserSelection == 1)
                    new MainMenuFormAD().Show();
                else
                    new MainMenuFormMember(EmailBox.Text).Show();
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            ConfirmationFormActivated();
        }
        #endregion

        #region Extra Functions
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

        private bool WarningsActivated()
        {
            bool AnyWarningActivated = false;

            if (UserSelection == -1)
            {
                AnyWarningActivated = true;
                SignInWarningLabel.ForeColor = Color.Red;
            }

            if (NameBox.TextAlign == HorizontalAlignment.Center)
            {
                AnyWarningActivated = true;
                NameWarningLabel.ForeColor = Color.Red;
            }

            if (PasswordBox.TextAlign == HorizontalAlignment.Center)
            {
                AnyWarningActivated = true;
                PasswordWarningLabel.ForeColor = Color.Red;
            }

            if (EmailBox.TextAlign == HorizontalAlignment.Center)
            {
                AnyWarningActivated = true;
                EmailWarningLabel.ForeColor = Color.Red;
            }

            return AnyWarningActivated;
        }

        private void BoxDeactivation()
        {
            
        }

        private bool UserValidated()
        {
            String Query;

            if (UserSelection == 1)
                Query = "SELECT Name, Password FROM Familia_AdminData WHERE Email = '" + EmailBox.Text + "'";
            else
                Query = "SELECT Name, Password FROM Familia_AdminData WHERE Email = '" + EmailBox.Text + "'";

            try
            {
                SqlCommand Command = new SqlCommand(Query, MinFamiliaCon);
                MinFamiliaCon.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                
                try
                {
                    if (DataReader.Read())      // Reading Data From Con.
                    {
                        if ((NameBox.Text == Convert.ToString(DataReader["Name"]) & (PasswordBox.Text == Convert.ToString(DataReader["Password"]))))
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
