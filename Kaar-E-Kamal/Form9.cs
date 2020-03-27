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
			//FormBorderStyle.Format();
        }

		private void InitializeVerticalScrollBar()
		{
			//// The Minimum of the Vertical scrollbar will be 0.
			//int minVertical = 0;
			//// Determine the Maximum of the Vertical scrollbar.
			//// Start with the height of pnlInner.
			//// Subtract the height of pnlOuter.
			//int maxVertical = this.pnlInner.Height - this.pnlOuter.Height;
			//// SmallChange it typically 1%.
			//int smallChangeVertical = Math.Max((int)(maxVertical / 100), 1);
			//// LargeChange is typically one page.
			//int largeChangeVertical = this.pnlOuter.Height;
			//// Initialize the Vertical scrollbar
			//this.usbVertical.Initialize(minVertical, maxVertical,
			//  smallChangeVertical, largeChangeVertical);
		}

		private void Adding_Vertical_and_Horizontal_Scrollbars_Load(object sender, EventArgs e)
		{
			this.InitializeVerticalScrollBar();
		}

		private void VerticalScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			//UltraScrollBar scrollBar = sender as UltraScrollBar;
			//this.pnlInner.Top = -scrollBar.Value;
			int Change = BackPanel.VerticalScroll.Value + BackPanel.VerticalScroll.SmallChange * 30;
			BackPanel.AutoScrollPosition = new Point(0, Change);
		}
	}
}
