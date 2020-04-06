using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class ReferencesForm : Form
    {
        public ReferencesForm(string Identity)
        {
            InitializeComponent();
            PopulateGrid();

            if (Identity == "")
            {
                AddIconButton.Hide();
                UpdateIconButton.Hide();
                DeleteIconButton.Hide();
                RightPanel.Size = new Size(17, 0);
            }
        }

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
        private void PopulateGrid()
        {//Test
            ReferencesGrid.Rows.Add('1', "Tayyab Asghar", "33303-7405121-9", "muhammadtayyabasghar@gmail.com", "+92 314 3240296", "Home", "Unspecified", "Survey Drive Team #1");
            ReferencesGrid.Rows.Add('2', "Komal Asghar", "33303-7445151-9", "komalasghar@gmail.com", "+92 314 6108486", "Home", "Female", "Survey Drive Team #2");
            ReferencesGrid.Rows.Add('3', "Zareen Asghar", "33303-7426151-4", "Zareenasghar@gmail.com", "+92 314 7292232", "Home", "male", "Survey Drive Team #3");
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
            if (!FormOpen("ReferencesDetails"))
            {
                new DetailsForm("ReferencesForm").Show();
                PopulateGrid();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (!FormOpen("ReferencesDetails"))
            {
                new DetailsForm("ReferencesForm", "").Show();
                PopulateGrid();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!FormOpen(""))
            {
                PopulateGrid();
            }
        }
        #endregion
    }
}
