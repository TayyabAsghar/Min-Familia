using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class MembersForm : Form
    {
       public MembersForm(char Person)
        {
            InitializeComponent();
            PopulateGrid("SELECT * FROM Familia_MembersData");
            
            if (Person == 'M')
            {
                RightPanel.Hide();
                HidenPanel.Size = new Size(17, 0);
            }
        }

        #region Fields
        private readonly SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True");
        #endregion

        #region Grid
        private void PopulateGrid(string Query)
        {
            try
            {
                using (SqlCommand Command = new SqlCommand(Query, MinFamiliaCon))
                {
                    MinFamiliaCon.Open();
                    using (SqlDataReader DataReader = Command.ExecuteReader())
                    {
                        DataGridViewRow Rows = new DataGridViewRow();
                        int Count = 1;

                        MemberGrid.Rows.Clear();                // Clearing the Rows.

                        while (DataReader.Read())
                        {
                            Rows.CreateCells(MemberGrid);       // Create cells in DataGridViewRows Same as MemberGrid

                            Rows.Cells[0].Value = Count++;
                            Rows.Cells[1].Value = Convert.ToString(DataReader["Familia_MembersData_Name"]);
                            Rows.Cells[2].Value = Convert.ToString(DataReader["Familia_MembersData_CNIC"]);
                            Rows.Cells[3].Value = Convert.ToString(DataReader["Familia_MembersData_Email"]);
                            Rows.Cells[4].Value = Convert.ToString(DataReader["Familia_MembersData_Phone"]);
                            Rows.Cells[5].Value = Convert.ToString(DataReader["Familia_MembersData_Address"]);
                            Rows.Cells[6].Value = Convert.ToString(DataReader["Familia_MembersData_Gender"]);
                            Rows.Cells[7].Value = Convert.ToString(DataReader["Familia_MembersData_Team_ID"]);

                            MemberGrid.Rows.Add(Rows);          // Add DataGridViewRows in MemberGrid
                        }
                    }
                }
            }
            catch
            {
                Application.Exit();
            }
        }
        #endregion

        #region SearchBox
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if ((SearchBox.Text == "Search") && (SearchBox.TextAlign == HorizontalAlignment.Center))
            {
                SearchBox.TextAlign = HorizontalAlignment.Left;
                SearchBox.Clear();
            }
            SearchBox.ForeColor = Color.Gainsboro;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateGrid("Select * From Familia_MembersData WHERE ");
        }
        
        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = "Search";
                SearchBox.TextAlign = HorizontalAlignment.Center;
                SearchBox.ForeColor = Color.Gray;
            }
            else
                SearchBox.ForeColor = Color.White;
        }
        #endregion

        #region Events
        private void AddIconButton_Click(object sender, EventArgs e)
        {
            new MemberDetailsForm().Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            new MemberDetailsForm("Here will Go CNic").Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            PopulateGrid("SELECT * FROM Familia_MembersData");
        }
        #endregion

        #region Extra Functions
        private bool SubFormActivated()   // Return bool if Form activated and BringToFront it.
        {
            foreach (Form Child in Application.OpenForms)
                if (((string)Child.Tag == "Confirmation") || ((string)Child.Tag == "MembersDetails"))
                {
                    Child.BringToFront();
                    return true;
                }
            return false;
        }
        #endregion

        private void MembersForm_Activated(object sender, EventArgs e)
        {
            if (!SubFormActivated())
                PopulateGrid("SELECT * FROM Familia_MembersData");
        }
    }
}
