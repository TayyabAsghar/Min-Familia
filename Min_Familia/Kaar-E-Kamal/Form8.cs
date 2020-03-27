using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kaar_E_Kamal
{
    public partial class CasesForm : Form
    {
        private string Query { get; set; }
        private string Identity { get; set; }

        public CasesForm(string identity, string SubButton)
        {
            InitializeComponent();
            Selection(SubButton);
            PopulateGrid();
            Identity = identity;
        }

        #region Selection
        private void Selection(string SubButton)
        {
            if (SubButton == "Show")
            {
                HeadingLable.Text = "List Of All Cases";
                HidenPanel.Size = new Size(17, 0);
                RightPanel.Hide();

                if (Identity == "Admin")
                    Query = "";
                else if (Identity != "")
                    Query = "";
            }
            else if(SubButton == "Approve")
            {
                HeadingLable.Text = "List Of Approved Cases";
                CasesGrid.Columns[7].HeaderText = "Approval Date";

                if (Identity == "Admin")
                {
                    ApproveIconButton.Hide();
                    AddIconButton.Hide();
                    RejectIconButton.Location = new Point(6, 18);
                    PendingIconButton.Location = new Point(6, 68);
                    CompletedIconButton.Location = new Point(6, 118);
                    DeleteIconButton.Location = new Point(6, 168);
                    Query = "";
                }
                else if (Identity != "")
                {
                    HidenPanel.Size = new Size(17, 0);
                    RightPanel.Hide();
                    Query = "";
                }
                else        // If no Team is Joined
                {
                    HidenPanel.Size = new Size(17, 0);
                    RightPanel.Hide();
                }
            }
            else if (SubButton == "Rejected")
            {
                HeadingLable.Text = "List Of Rejected Cases";
                CasesGrid.Columns[7].HeaderText = "Rejection Date";

                if (Identity == "Admin")
                {
                    RejectIconButton.Hide();
                    AddIconButton.Hide();
                    PendingIconButton.Location = new Point(6, 68);
                    CompletedIconButton.Location = new Point(6, 118);
                    DeleteIconButton.Location = new Point(6, 168);
                    Query = "";
                }
                else if (Identity != "")
                {
                    HidenPanel.Size = new Size(17, 0);
                    RightPanel.Hide();
                    Query = "";
                }
                else
                {
                    HidenPanel.Size = new Size(17, 0);
                    RightPanel.Hide();
                }
            }
            else if (SubButton == "Pending")
            {
                HeadingLable.Text = "List Of Pending Cases";
                CasesGrid.Columns[7].HeaderText = "Pending Date";

                PendingIconButton.Hide();
                CompletedIconButton.Hide();
                    
                if (Identity == "Admin")
                {
                    AddIconButton.Hide();
                    DeleteIconButton.Location = new Point(6, 118);
                    Query = "";
                }
                else if (Identity != "")
                {
                    ApproveIconButton.Hide();
                    RejectIconButton.Hide();
                        // Relocating Buttons
                    AddIconButton.Location = new Point(6, 18);
                    DeleteIconButton.Location = new Point(6, 68);
                    Query = "";
                }
                else
                {
                    HidenPanel.Size = new Size(17, 0);
                    RightPanel.Hide();
                }
            }
            else
            {
                HeadingLable.Text = "List Of Completed Cases";
                CasesGrid.Columns[7].HeaderText = "Approval Date";

                if (Identity == "Admin")
                {
                    ApproveIconButton.Hide();
                    RejectIconButton.Hide();
                    PendingIconButton.Hide();
                    CompletedIconButton.Hide();
                    AddIconButton.Hide();
                    DeleteIconButton.Location = new Point(6, 18);
                    Query = "";
                }
                else if (Identity != "")
                {
                    HidenPanel.Size = new Size(17, 0);
                    RightPanel.Hide();
                    Query = "";
                }
                else
                {
                    HidenPanel.Size = new Size(17, 0);
                    RightPanel.Hide();
                }
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

        #region Grid
        private void PopulateGrid()
        {

        }

        private void MemberGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new CasesInformationForm("").Show();
        }
        #endregion

        #region Events
        private void ApproveIconButton_Click(object sender, EventArgs e)
        {

        }

        private void RejectIconButton_Click(object sender, EventArgs e)
        {

        }

        private void PendingIconButton_Click(object sender, EventArgs e)
        {

        }

        private void CompletedIconButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteIconButton_Click(object sender, EventArgs e)
        {

        }

        private void AddIconButton_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
