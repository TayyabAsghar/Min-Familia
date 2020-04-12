namespace Kaar_E_Kamal
{
    partial class CasesInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.CloseIconButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.NextIconButton = new FontAwesome.Sharp.IconButton();
            this.BackIconButton = new FontAwesome.Sharp.IconButton();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.BorderPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderPanel
            // 
            this.BorderPanel.BackColor = System.Drawing.Color.Black;
            this.BorderPanel.Controls.Add(this.CloseIconButton);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderPanel.Location = new System.Drawing.Point(0, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(1370, 28);
            this.BorderPanel.TabIndex = 51;
            // 
            // CloseIconButton
            // 
            this.CloseIconButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseIconButton.FlatAppearance.BorderSize = 0;
            this.CloseIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.CloseIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloseIconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseIconButton.IconColor = System.Drawing.Color.Gainsboro;
            this.CloseIconButton.IconSize = 22;
            this.CloseIconButton.Location = new System.Drawing.Point(1333, 0);
            this.CloseIconButton.Name = "CloseIconButton";
            this.CloseIconButton.Rotation = 0D;
            this.CloseIconButton.Size = new System.Drawing.Size(37, 28);
            this.CloseIconButton.TabIndex = 0;
            this.CloseIconButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 713);
            this.panel3.TabIndex = 95;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1362, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 713);
            this.panel2.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 741);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 8);
            this.panel1.TabIndex = 93;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BottomPanel.Controls.Add(this.NextIconButton);
            this.BottomPanel.Controls.Add(this.BackIconButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(8, 697);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1354, 44);
            this.BottomPanel.TabIndex = 96;
            // 
            // NextIconButton
            // 
            this.NextIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.NextIconButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextIconButton.FlatAppearance.BorderSize = 0;
            this.NextIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.NextIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.NextIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NextIconButton.Font = new System.Drawing.Font("Lovelo Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.NextIconButton.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.NextIconButton.IconColor = System.Drawing.Color.Gainsboro;
            this.NextIconButton.IconSize = 28;
            this.NextIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextIconButton.Location = new System.Drawing.Point(1177, 0);
            this.NextIconButton.Name = "NextIconButton";
            this.NextIconButton.Rotation = 0D;
            this.NextIconButton.Size = new System.Drawing.Size(177, 44);
            this.NextIconButton.TabIndex = 28;
            this.NextIconButton.Text = "Next";
            this.NextIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NextIconButton.UseVisualStyleBackColor = false;
            this.NextIconButton.Click += new System.EventHandler(this.NextIconButton_Click);
            // 
            // BackIconButton
            // 
            this.BackIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BackIconButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackIconButton.FlatAppearance.BorderSize = 0;
            this.BackIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BackIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.BackIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BackIconButton.Font = new System.Drawing.Font("Lovelo Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.BackIconButton.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.BackIconButton.IconColor = System.Drawing.Color.Gainsboro;
            this.BackIconButton.IconSize = 28;
            this.BackIconButton.Location = new System.Drawing.Point(0, 0);
            this.BackIconButton.Name = "BackIconButton";
            this.BackIconButton.Rotation = 0D;
            this.BackIconButton.Size = new System.Drawing.Size(177, 44);
            this.BackIconButton.TabIndex = 27;
            this.BackIconButton.Text = "   Back";
            this.BackIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackIconButton.UseVisualStyleBackColor = false;
            this.BackIconButton.Click += new System.EventHandler(this.BackIconButton_Click);
            // 
            // FormPanel
            // 
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(8, 28);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1354, 669);
            this.FormPanel.TabIndex = 97;
            // 
            // CasesInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CasesInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BorderPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BorderPanel;
        private FontAwesome.Sharp.IconButton CloseIconButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel FormPanel;
        private FontAwesome.Sharp.IconButton BackIconButton;
        private FontAwesome.Sharp.IconButton NextIconButton;
    }
}