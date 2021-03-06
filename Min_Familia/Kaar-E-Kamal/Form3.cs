﻿using System;
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
                MemberGrid.Columns[7].Visible = false;  // Members Password Restrictions.
                HidenPanel.Size = new Size(17, 0);
            }
        }

        #region Grid
        private void PopulateGrid(string Query)
        {
            try
            {
                using (SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True"))
                    using (SqlCommand Command = new SqlCommand(Query, MinFamiliaCon))
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
                                Rows.Cells[4].Value = Convert.ToString(DataReader["Familia_Member_Phone"]);
                                Rows.Cells[5].Value = Convert.ToString(DataReader["Familia_Member_Address"]);
                                Rows.Cells[6].Value = Convert.ToString(DataReader["Familia_Member_Gender"]);
                                Rows.Cells[7].Value = Convert.ToString(DataReader["Familia_Member_Password"]);
                                Rows.Cells[8].Value = Convert.ToString(DataReader["Familia_Member_Team_ID"]);
                                Rows.Cells[9].Value = Convert.ToString(DataReader["Familia_Member_Joining_Date"]);

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
            //PopulateGrid("Select * From Familia_MembersData WHERE ");
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
        {           // Send the Parent Form Name.
            if (DialogResult.Yes == new DetailsForm("MembersForm").ShowDialog())
                PopulateGrid("SELECT * FROM Familia_MembersData");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MemberGrid.Rows.Count != 0)
                if (DialogResult.Yes == new DetailsForm("MembersForm", MemberGrid.CurrentRow).ShowDialog())
                    PopulateGrid("SELECT * FROM Familia_MembersData");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            PopulateGrid("SELECT * FROM Familia_MembersData");
        }
        #endregion
    }
}
