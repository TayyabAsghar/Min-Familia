namespace Kaar_E_Kamal
{
    partial class ConfirmationForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.CloseIconButton = new FontAwesome.Sharp.IconButton();
            this.YesIconButton = new FontAwesome.Sharp.IconButton();
            this.NoIconButton = new FontAwesome.Sharp.IconButton();
            this.ContantLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.BorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 178);
            this.panel3.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(221, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 178);
            this.panel2.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 8);
            this.panel1.TabIndex = 90;
            // 
            // BorderPanel
            // 
            this.BorderPanel.BackColor = System.Drawing.Color.Black;
            this.BorderPanel.Controls.Add(this.HeadingLabel);
            this.BorderPanel.Controls.Add(this.CloseIconButton);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderPanel.Location = new System.Drawing.Point(0, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(229, 28);
            this.BorderPanel.TabIndex = 89;
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
            this.CloseIconButton.Location = new System.Drawing.Point(192, 0);
            this.CloseIconButton.Name = "CloseIconButton";
            this.CloseIconButton.Rotation = 0D;
            this.CloseIconButton.Size = new System.Drawing.Size(37, 28);
            this.CloseIconButton.TabIndex = 0;
            this.CloseIconButton.UseVisualStyleBackColor = true;
            // 
            // YesIconButton
            // 
            this.YesIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.YesIconButton.FlatAppearance.BorderSize = 0;
            this.YesIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.YesIconButton.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.YesIconButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.YesIconButton.IconColor = System.Drawing.Color.LightGray;
            this.YesIconButton.IconSize = 16;
            this.YesIconButton.Location = new System.Drawing.Point(37, 146);
            this.YesIconButton.Name = "YesIconButton";
            this.YesIconButton.Rotation = 0D;
            this.YesIconButton.Size = new System.Drawing.Size(62, 33);
            this.YesIconButton.TabIndex = 95;
            this.YesIconButton.Text = "Yes";
            this.YesIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.YesIconButton.UseVisualStyleBackColor = false;
            // 
            // NoIconButton
            // 
            this.NoIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.NoIconButton.FlatAppearance.BorderSize = 0;
            this.NoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NoIconButton.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.NoIconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.NoIconButton.IconColor = System.Drawing.Color.LightGray;
            this.NoIconButton.IconSize = 16;
            this.NoIconButton.Location = new System.Drawing.Point(137, 146);
            this.NoIconButton.Name = "NoIconButton";
            this.NoIconButton.Rotation = 0D;
            this.NoIconButton.Size = new System.Drawing.Size(62, 33);
            this.NoIconButton.TabIndex = 94;
            this.NoIconButton.Text = "No";
            this.NoIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NoIconButton.UseVisualStyleBackColor = false;
            // 
            // ContantLabel
            // 
            this.ContantLabel.AutoSize = true;
            this.ContantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContantLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ContantLabel.Location = new System.Drawing.Point(33, 66);
            this.ContantLabel.Name = "ContantLabel";
            this.ContantLabel.Size = new System.Drawing.Size(74, 20);
            this.ContantLabel.TabIndex = 93;
            this.ContantLabel.Text = "Message";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.HeadingLabel.Location = new System.Drawing.Point(3, 5);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(74, 20);
            this.HeadingLabel.TabIndex = 94;
            this.HeadingLabel.Text = "Message";
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(229, 214);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.YesIconButton);
            this.Controls.Add(this.NoIconButton);
            this.Controls.Add(this.ContantLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationForm";
            this.Tag = "Confirmation";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReferencesDetails_MouseDown);
            this.BorderPanel.ResumeLayout(false);
            this.BorderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Label HeadingLabel;
        private FontAwesome.Sharp.IconButton CloseIconButton;
        private FontAwesome.Sharp.IconButton YesIconButton;
        private FontAwesome.Sharp.IconButton NoIconButton;
        private System.Windows.Forms.Label ContantLabel;
    }
}