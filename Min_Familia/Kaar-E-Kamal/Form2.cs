using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Kaar_E_Kamal
{
    public partial class MainMenuFormAD : Form
    {
        public MainMenuFormAD()
        {
            InitializeComponent();
            CustomizedDesign();
        }

        #region Fields
        private IconButton CurrButton { get; set; }
        private Panel LeftBorderButton { get; set; }
        private Form CurrentChildForm { get; set; }
        #endregion

        #region Colors
        private struct RGBColors   // Colors to use at different places
        {
            public static Color TopButtonColor = Color.FromArgb(11, 7, 17);
            public static Color SubButtonColor = Color.FromArgb(35, 32, 39);
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        #endregion

        #region Extra Functions
        private void CustomizedDesign()
        {
            LeftBorderButton = new Panel{Size = new Size(7, 40)}; // Initializing With Desired Size
            PanelSideMenue.Controls.Add(LeftBorderButton);
            CasesSubMenuePanel.Visible = false;
            CasesPictureBox.Visible = false;
        }

        private void ActivateButton(object SenderButton, Color color)
        {
            if (SenderButton != null)
            {
                DisableButton();
                HideSubMenue();

                // Button
                CurrButton = (IconButton)SenderButton;
                CurrButton.BackColor = Color.FromArgb(111, 75, 165);
                CurrButton.ForeColor = color;
                CurrButton.TextAlign = ContentAlignment.MiddleCenter;
                CurrButton.IconColor = color;
                CurrButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrButton.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                LeftBorderButton.BackColor = color;
                LeftBorderButton.Location = new Point(0, CurrButton.Location.Y);
                LeftBorderButton.Visible = true;
                LeftBorderButton.BringToFront();

                // Current Child Form Icon
                TitleIconPictureBox.IconChar = CurrButton.IconChar;
                Titlelabel.Text = CurrButton.Text;
                TitleIconPictureBox.IconColor = color;
            }
        }

        private void ActivateSubButton(object SenderButton, Color color)
        {
            if (SenderButton != null)
            {
                DisableButton();

                // Button
                CurrButton = (IconButton)SenderButton;
                CurrButton.BackColor = Color.FromArgb(111, 75, 165);
                CurrButton.ForeColor = color;
                CurrButton.TextAlign = ContentAlignment.MiddleCenter;
                CurrButton.IconColor = color;
                CurrButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrButton.ImageAlign = ContentAlignment.MiddleRight;

                // Current Child Form Icon
                TitleIconPictureBox.IconChar = CurrButton.IconChar;
                TitleIconPictureBox.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (CurrButton != null)
            {
                if ((string)CurrButton.Tag == "Sub")
                {
                    CurrButton.BackColor = RGBColors.SubButtonColor;
                    CurrButton.TextAlign = ContentAlignment.MiddleCenter;
                    CurrButton.ImageAlign = ContentAlignment.MiddleCenter;
                }
                else
                { 
                    CurrButton.BackColor = RGBColors.TopButtonColor;
                    CurrButton.TextAlign = ContentAlignment.MiddleLeft;
                    CurrButton.ImageAlign = ContentAlignment.MiddleLeft;
                }
                CurrButton.ForeColor = Color.Gainsboro;
                CurrButton.IconColor = Color.Gainsboro;
                CurrButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                CasesPictureBox.Visible = false;
            }
        }

        private void OpenChildForm(Form ChildForm)
        {
            if ((CurrentChildForm == null) || (CurrentChildForm.Tag != ChildForm.Tag) || ((string)CurrentChildForm.Tag == "Cases"))
            {   
                // Open only form
                CurrentChildForm?.Close();
                CurrentChildForm = ChildForm;
                // End

                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                SubDeskTopPanel.Controls.Add(ChildForm);
                SubDeskTopPanel.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show(); 
            }
        }

        private void HideSubMenue()
        {
            if (CasesSubMenuePanel.Visible == true)
                CasesSubMenuePanel.Visible = false;
        }

        private void Reset()
        {
            DisableButton();
            LeftBorderButton.Visible = false;
            TitleIconPictureBox.IconChar = IconChar.Home;
            TitleIconPictureBox.IconColor = Color.MediumPurple;
            Titlelabel.Text = "Home";
            HideSubMenue();
        }
                    //To check Child forms of Child Forms.
        private bool GrandChildFormActived()
        {
            foreach (Form Child in Application.OpenForms)
                if (((string)Child.Tag == "TeamDetailsForm") || ((string)Child.Tag == "TeamMemberDetailsForm") || ((string)Child.Tag == "CasesInformationForm"))
                {
                    Child.BringToFront();
                    return true;
                }
            return false;
        }
        #endregion

        #region Events
        private void MembersButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new MembersForm('A')); // A shows Admin
        }

        private void TeamsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new TeamsForm());     // Empty shows Admin
        }

        #region Cases

        private void CasesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            CurrentChildForm?.Close();
            CasesSubMenuePanel.Visible = true;
            CasesPictureBox.Visible = true;
        }

        private void ShowCasesButton_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, RGBColors.color3);
            OpenChildForm(new CasesForm("Admin", "Show"));
        }

        private void ApprovedCasesButton_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, RGBColors.color3);
            OpenChildForm(new CasesForm("Admin", "Approve"));
        }

        private void RejectedCasesButton_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, RGBColors.color3);
            OpenChildForm(new CasesForm("Admin", "Rejected"));
        }

        private void PendingCasesButton_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, RGBColors.color3);
            OpenChildForm(new CasesForm("Admin", "Pending"));
        }

        private void CompletedCasesButton_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, RGBColors.color3);
            OpenChildForm(new CasesForm("Admin", "Completed"));
        }
        #endregion

        private void ReferenceButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new ReferencesForm("Admin"));
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            Reset();
            CurrentChildForm?.Hide();     // ? to check the null reference

        }

        private void MainMenuFormAD_Activated(object sender, EventArgs e)
        {
            GrandChildFormActived();
        }
        #endregion

        #region FormMovement
        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        // Close-Maximize-Minimize
        private void CloseIconButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeIconButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.Sizable; // Just to solve the Maximization issue
                FormBorderStyle = FormBorderStyle.None;
                MaximizeIconButton.IconChar = IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                MaximizeIconButton.IconChar = IconChar.Square;
            }
        }

        private void MinimizeIconButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Buffering
        //protected override CreateParams CreateParams  // Stop Stretching in-front of Me
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}

        private void MainMenuFormAD_SizeChanged(object sender, EventArgs e)
        {
            Application.DoEvents();    // Stop Losing Portions of Form 
        }
        #endregion
    }
}
