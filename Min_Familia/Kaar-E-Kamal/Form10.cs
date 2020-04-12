using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class ReferencesForm : Form
    {
        public ReferencesForm()
        {
            InitializeComponent();
            PopulateGrid();
                    // Member Can't access Add/Update/Delete Button
            AddIconButton.Hide();
            UpdateIconButton.Hide();
            DeleteIconButton.Hide();
            RightPanel.Size = new Size(17, 0);
        }

        public ReferencesForm(string Identity)
        {
            InitializeComponent();
            PopulateGrid();

            if (Identity != "Admin")    // Team Head can't Access Delete Button
                DeleteIconButton.Hide();
        }

        #region Grid
        private void PopulateGrid()
        {
            try
            {
                using (SqlConnection MinFamiliaCon = new SqlConnection("Data Source=DESKTOP-7F1UCLP\\MSSQLSERVER_2019;Initial Catalog=Non_Profit_Min_Familia;Integrated Security=True"))
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Familia_ReferencesData", MinFamiliaCon))
                {
                    MinFamiliaCon.Open();
                    using (SqlDataReader DataReader = Command.ExecuteReader())
                    {
                        int Count = 1;

                        ReferencesGrid.Rows.Clear();                // Clearing the Rows.

                        while (DataReader.Read())
                        {
                            DataGridViewRow Rows = new DataGridViewRow();  // Each time provide new Row.

                            Rows.CreateCells(ReferencesGrid);       // Create cells in DataGridViewRows Same as MemberGrid

                            Rows.Cells[0].Value = Count++;
                            Rows.Cells[1].Value = Convert.ToString(DataReader["Familia_Reference_Name"]);
                            Rows.Cells[2].Value = Convert.ToString(DataReader["Familia_Reference_CNIC"]);
                            Rows.Cells[3].Value = Convert.ToString(DataReader["Familia_Reference_Email"]);
                            Rows.Cells[4].Value = Convert.ToString(DataReader["Familia_Reference_Phone"]);
                            Rows.Cells[5].Value = Convert.ToString(DataReader["Familia_Reference_Address"]);
                            Rows.Cells[6].Value = Convert.ToString(DataReader["Familia_Reference_Gender"]);
                            Rows.Cells[7].Value = Convert.ToString(DataReader["Familia_Reference_Date"]);
                            Rows.Cells[8].Value = Convert.ToString(DataReader["Familia_Reference_Cases"]);

                            ReferencesGrid.Rows.Add(Rows);          // Add DataGridViewRows in MemberGrid
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
            // Select Query
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
            if (DialogResult.Yes == new DetailsForm("ReferencesForm").ShowDialog())
                PopulateGrid();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == new DetailsForm("ReferencesForm", ReferencesGrid.CurrentRow).ShowDialog())
                PopulateGrid();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        #endregion
    }
}
