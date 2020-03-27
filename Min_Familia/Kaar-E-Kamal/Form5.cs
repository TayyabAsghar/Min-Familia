using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class TeamsForm : Form
    {
        private string Person { get; set; }   // To store Person Identity
        private int ButtonPressed { get; set; } // To store which Sub-Button Pressed 
        
        #region Constructor
        public TeamsForm()
        {
            InitializeComponent();
            PopulateTeamGrid();
            Person = "Admin";
        }

        // Person 'H' for Team Head and 'N' for Normal Member
        public TeamsForm(string person, int buttonPressed) 
        {
            InitializeComponent();
            PopulateTeamGrid();
            Person = person;
            ButtonPressed = buttonPressed;
        }
        #endregion

        #region ChildOpenTest
        private bool FormOpen(string FormTag)
        {
            foreach (Form Child in Application.OpenForms)
                if ((string)Child.Tag == FormTag)
                {
                    Child.BringToFront();
                    return true;
                }
            return false;
        }
        #endregion

        #region Grid
        private void PopulateTeamGrid()
        {//Test
            TeamGrid.Rows.Add('1', "Drive-1", "Survey Drive #1", "Tayyab Asghar", "33303-7405121-9");
            TeamGrid.Rows.Add('2', "Drive-2", "Survey Drive #2", "Komal Asghar", "33303-7445151-9");
            TeamGrid.Rows.Add('3', "Drive-3", "Survey Drive #3", "Zareen Asghar", "33303-7426151-4");
        }

        private void PopulateMemberGrid()
        {
        }

        private void TeamGrid_SelectionChanged(object sender, EventArgs e)
        {
            PopulateMemberGrid();
        }

        #endregion

        #region Events
        #region Click
        private void AddIconButton_Click(object sender, EventArgs e)
        {
            string Tag;
            Form NewForm;

            if (SearchPanel.Visible)
            {
                Tag = "Team";
                NewForm = new TeamDetailsForm();
            }
            else
            {
                Tag = "Members";
                NewForm = new TeamMemberDetailsForm();
            }

            if (!FormOpen(Tag))
            {
                NewForm.Show();
                PopulateTeamGrid();
            }
        }


        private void UpdateIconButton_Click(object sender, EventArgs e)
        {
                //GridView.CurrentCell.RowIndex;
            if (!FormOpen("Team"))
            {
                new TeamDetailsForm("Here will Go TeamID").Show();
                PopulateTeamGrid();
            }
        }

        private void DeleteIconButton_Click(object sender, EventArgs e)
        {
            if (!(FormOpen("Members") || FormOpen("Team")))
                if (SearchPanel.Visible)
                {
                    PopulateMemberGrid();
                }
                else
                {
                    PopulateTeamGrid();
                }
        }
        #endregion

        #region SearchBoxEnter/Leave
        private void MemberSearchBox_Enter(object sender, EventArgs e)
        {
            if ((MemberSearchBox.Text == "Search") && (MemberSearchBox.TextAlign == HorizontalAlignment.Center))
            {
                MemberSearchBox.TextAlign = HorizontalAlignment.Left;
                MemberSearchBox.Clear();
            }
            MemberSearchBox.ForeColor = Color.Gainsboro;
        }

        private void MemberSearchBox_Leave(object sender, EventArgs e)
        {
            if (MemberSearchBox.Text == "")
            {
                MemberSearchBox.Text = "Search";
                MemberSearchBox.TextAlign = HorizontalAlignment.Center;
                MemberSearchBox.ForeColor = Color.Gray;
            }
            else
                MemberSearchBox.ForeColor = Color.White;
        }

        private void TeamSearchBox_Enter(object sender, EventArgs e)
        {
            if ((TeamSearchBox.Text == "Search") && (TeamSearchBox.TextAlign == HorizontalAlignment.Center))
            {
                TeamSearchBox.TextAlign = HorizontalAlignment.Left;
                TeamSearchBox.Clear();
            }
            TeamSearchBox.ForeColor = Color.Gainsboro;
        }

        private void TeamSearchBox_Leave(object sender, EventArgs e)
        {
            if (TeamSearchBox.Text == "")
            {
                TeamSearchBox.Text = "Search";
                TeamSearchBox.TextAlign = HorizontalAlignment.Center;
                TeamSearchBox.ForeColor = Color.Gray;
            }
            else
                TeamSearchBox.ForeColor = Color.White;
        }
        #endregion

        #region TextChange
        private void MemberSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region SizeChange
        private void TeamsForm_SizeChanged(object sender, EventArgs e)
        {
            if ((TeamsForm.ActiveForm.Size.Height > 640))        // Maximized
            {
                        // Panels
                RightBackPanel.Size = new Size(118, 0);
                BackPartionPanel.Size = new Size(118, 0);
                BackPartionPanel.BackColor = Color.FromArgb(40, 57, 80);
                SearchPanel.Show();
                PartionPanel.Hide();

                if (Person == "Admin")
                {
                    PartionPanel.Show();
                    UpdateIconButton.Hide();
                    DeleteIconButton.Location = new Point(11, 62);
                }
                else if (ButtonPressed == 0) // Show all Teams Head/Non-Head Member
                    RightPanel.Hide();
                else if (ButtonPressed == 1)
                    if (Person == "Head")  // Show My Team of Head-Member
                    {
                        RightPanel.Show();
                        UpdateIconButton.Hide();
                        DeleteIconButton.Location = new Point(11, 62);
                    }
                    else  // Show My Team of Non-Head-Member
                        RightPanel.Hide();
            }
            else        // Restored
            {
                    // Panels
                RightBackPanel.Size = new Size(136, 0);
                BackPartionPanel.Size = new Size(136, 0);
                BackPartionPanel.BackColor = Color.FromArgb(48, 69, 99);
                PartionPanel.Hide();
                SearchPanel.Hide();

                if (Person == "Admin")  // Admin Case
                {
                    UpdateIconButton.Show();
                    DeleteIconButton.Location = new Point(11, 104);
                }
                else                    // All other Possible Cases
                    RightPanel.Hide();
            }
        }
        #endregion
        #endregion
    }
}
