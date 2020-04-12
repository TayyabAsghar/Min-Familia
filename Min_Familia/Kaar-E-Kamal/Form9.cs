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
    public partial class CasesInformationForm : Form
    {
        public CasesInformationForm(string CaseID)
        {
            InitializeComponent();
            OpenChildForm(new CaseDetailsFirstForm());
        }

        #region Fields
        private int ChildFormCounts { get; set; }
        private Form CurrentChildForm { get; set; }
        #endregion

        #region Events
        private void BackIconButton_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new );
        }

        private void NextIconButton_Click(object sender, EventArgs e)
        {
          
        }
        #endregion

        #region Extra Functions
        private void OpenChildForm(Form ChildForm)
        {  
            if (CurrentChildForm == null)
            {
                // Open only form
                CurrentChildForm?.Close();
                CurrentChildForm = ChildForm;
                // End

                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                FormPanel.Controls.Add(ChildForm);
                FormPanel.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
        }
        #endregion
    }
}
