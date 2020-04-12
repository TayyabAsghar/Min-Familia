using System;
using System.Data.SqlClient;
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

        #region Grid
        private void PopulateTeamGrid()
        {
            try
            {
                using (SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True"))
                    using (SqlCommand Command = new SqlCommand("SELECT * FROM Familia_TeamsData", MinFamiliaCon))
                    {
                        MinFamiliaCon.Open();
                        using (SqlDataReader DataReader = Command.ExecuteReader())
                        {
                            int Count = 1;

                            TeamGrid.Rows.Clear();                // Clearing the Rows.

                            while (DataReader.Read())
                            {
                                DataGridViewRow Rows = new DataGridViewRow();  // Each time provide new Row.

                                Rows.CreateCells(TeamGrid);       // Create cells in DataGridViewRows Same as MemberGrid

                                Rows.Cells[0].Value = Count++;
                                Rows.Cells[1].Value = Convert.ToString(DataReader["Familia_Team_ID"]);
                                Rows.Cells[2].Value = Convert.ToString(DataReader["Familia_Team_Name"]);
                                Rows.Cells[3].Value = Convert.ToString(DataReader["Familia_Team_Head_Name"]);
                                Rows.Cells[4].Value = Convert.ToString(DataReader["Familia_Team_Head_CNIC"]);
                                Rows.Cells[5].Value = Convert.ToString(DataReader["Familia_Team_Creation_Date"]);
                                
                                TeamGrid.Rows.Add(Rows);          // Add DataGridViewRows in MemberGrid
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

        private void PopulateMemberGrid()
        {
            try
            {
                using (SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True"))
                using (SqlCommand Command = new SqlCommand("SELECT Familia_Member_Name, Familia_Member_CNIC, Familia_Member_Phone, Familia_Member_Gender, Familia_Member_Team_Joining_Date FROM Familia_MembersData WHERE Familia_Member_Team_ID = @ID;", MinFamiliaCon))
                {
                    Command.Parameters.AddWithValue("@ID", TeamGrid.CurrentRow.Cells[1].Value);
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
                            Rows.Cells[3].Value = Convert.ToString(DataReader["Familia_Member_Gender"]);
                            Rows.Cells[4].Value = Convert.ToString(DataReader["Familia_Member_Phone"]);
                            Rows.Cells[5].Value = Convert.ToString(DataReader["Familia_Member_Team_Joining_Date"]);

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

        private void TeamGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (MemberGrid.Visible)    // Small check to protect from fetching Data.
                PopulateMemberGrid();
        }

        #endregion

        #region Events
        #region Click
        private void AddIconButton_Click(object sender, EventArgs e)
        {
            DialogResult Executed;

            if (PartionPanel.Visible)
                Executed = new TeamMemberDetailsForm().ShowDialog();
            else
                Executed = new TeamDetailsForm().ShowDialog();
            
            if (DialogResult.Yes == Executed)        // To see if changes are made.
                PopulateTeamGrid();
        }

        private void AddTeamIconButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == new TeamDetailsForm().ShowDialog())        // To see if changes are made.
                PopulateTeamGrid();
        }

        private void UpdateIconButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == new TeamDetailsForm(TeamGrid.CurrentRow).ShowDialog())        // To see if changes are made.
                PopulateTeamGrid();
        }

        private void DeleteIconButton_Click(object sender, EventArgs e)
        {
            if (PartionPanel.Visible)
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
            PopulateMemberGrid();
        }

        private void TeamSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateTeamGrid();
        }
        #endregion

        #region SizeChange
        private void TeamsForm_SizeChanged(object sender, EventArgs e)
        {
            if ((this.Height > 640))        // Maximized
            {
                        // Panels
                RightBackPanel.Size = new Size(118, 0);
                SearchPanel.Show();
                PartionPanel.Hide();
                MemberGrid.Show();

                if (Person == "Admin")
                {
                    TeamGrid.Dock = DockStyle.Left;  // Make TeamGrid Dock Left
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
                PartionPanel.Hide();
                SearchPanel.Hide();
                MemberGrid.Hide();
                TeamGrid.Dock = DockStyle.Fill;   // Make TeamGrid Dock Fill so it occupy all remaining form

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
