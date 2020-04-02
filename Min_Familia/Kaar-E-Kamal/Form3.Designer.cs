namespace Kaar_E_Kamal
{
    partial class MembersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.HeadingLable = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HidenPanel = new System.Windows.Forms.Panel();
            this.AddIconButton = new FontAwesome.Sharp.IconButton();
            this.UpdateIconButton = new FontAwesome.Sharp.IconButton();
            this.DeleteIconButton = new FontAwesome.Sharp.IconButton();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.MemberGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.HidenPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.SearchBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Gray;
            this.SearchBox.Location = new System.Drawing.Point(12, 5);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(235, 25);
            this.SearchBox.TabIndex = 9;
            this.SearchBox.Text = "Search";
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // Top
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.TopPanel.Controls.Add(this.SearchPanel);
            this.TopPanel.Controls.Add(this.HeadingLable);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "Top";
            this.TopPanel.Size = new System.Drawing.Size(929, 33);
            this.TopPanel.TabIndex = 10;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchBox);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchPanel.Location = new System.Drawing.Point(564, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(365, 33);
            this.SearchPanel.TabIndex = 10;
            // 
            // HeadingLable
            // 
            this.HeadingLable.AutoSize = true;
            this.HeadingLable.Font = new System.Drawing.Font("Lovelo Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.HeadingLable.Location = new System.Drawing.Point(26, 6);
            this.HeadingLable.Name = "HeadingLable";
            this.HeadingLable.Size = new System.Drawing.Size(227, 24);
            this.HeadingLable.TabIndex = 0;
            this.HeadingLable.Text = "List Of All Memembers";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 33);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(17, 451);
            this.LeftPanel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(17, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 24);
            this.panel1.TabIndex = 15;
            // 
            // HidenPanel
            // 
            this.HidenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.HidenPanel.Controls.Add(this.RightPanel);
            this.HidenPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HidenPanel.Location = new System.Drawing.Point(811, 33);
            this.HidenPanel.Name = "HidenPanel";
            this.HidenPanel.Size = new System.Drawing.Size(118, 427);
            this.HidenPanel.TabIndex = 55;
            // 
            // AddIconButton
            // 
            this.AddIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.AddIconButton.FlatAppearance.BorderSize = 0;
            this.AddIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddIconButton.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddIconButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddIconButton.IconColor = System.Drawing.Color.LightGray;
            this.AddIconButton.IconSize = 16;
            this.AddIconButton.Location = new System.Drawing.Point(11, 17);
            this.AddIconButton.Name = "AddIconButton";
            this.AddIconButton.Rotation = 0D;
            this.AddIconButton.Size = new System.Drawing.Size(89, 23);
            this.AddIconButton.TabIndex = 0;
            this.AddIconButton.Text = "Add";
            this.AddIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddIconButton.UseVisualStyleBackColor = false;
            this.AddIconButton.Click += new System.EventHandler(this.AddIconButton_Click);
            // 
            // UpdateIconButton
            // 
            this.UpdateIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.UpdateIconButton.FlatAppearance.BorderSize = 0;
            this.UpdateIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.UpdateIconButton.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.UpdateIconButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.UpdateIconButton.IconColor = System.Drawing.Color.Gainsboro;
            this.UpdateIconButton.IconSize = 16;
            this.UpdateIconButton.Location = new System.Drawing.Point(11, 60);
            this.UpdateIconButton.Name = "UpdateIconButton";
            this.UpdateIconButton.Rotation = 0D;
            this.UpdateIconButton.Size = new System.Drawing.Size(89, 23);
            this.UpdateIconButton.TabIndex = 1;
            this.UpdateIconButton.Text = "Update";
            this.UpdateIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UpdateIconButton.UseVisualStyleBackColor = false;
            this.UpdateIconButton.Click += new System.EventHandler(this.Update_Click);
            // 
            // DeleteIconButton
            // 
            this.DeleteIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.DeleteIconButton.FlatAppearance.BorderSize = 0;
            this.DeleteIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DeleteIconButton.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeleteIconButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteIconButton.IconColor = System.Drawing.Color.Gainsboro;
            this.DeleteIconButton.IconSize = 16;
            this.DeleteIconButton.Location = new System.Drawing.Point(11, 102);
            this.DeleteIconButton.Name = "DeleteIconButton";
            this.DeleteIconButton.Rotation = 0D;
            this.DeleteIconButton.Size = new System.Drawing.Size(89, 23);
            this.DeleteIconButton.TabIndex = 2;
            this.DeleteIconButton.Text = "Delete";
            this.DeleteIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DeleteIconButton.UseVisualStyleBackColor = false;
            this.DeleteIconButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.RightPanel.Controls.Add(this.DeleteIconButton);
            this.RightPanel.Controls.Add(this.UpdateIconButton);
            this.RightPanel.Controls.Add(this.AddIconButton);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(0, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(118, 427);
            this.RightPanel.TabIndex = 14;
            // 
            // MemberGrid
            // 
            this.MemberGrid.AllowUserToAddRows = false;
            this.MemberGrid.AllowUserToDeleteRows = false;
            this.MemberGrid.AllowUserToOrderColumns = true;
            this.MemberGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MemberGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MemberGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.MemberGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemberGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MemberGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.MemberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberGrid.DefaultCellStyle = dataGridViewCellStyle21;
            this.MemberGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberGrid.EnableHeadersVisualStyles = false;
            this.MemberGrid.Location = new System.Drawing.Point(17, 33);
            this.MemberGrid.Name = "MemberGrid";
            this.MemberGrid.ReadOnly = true;
            this.MemberGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.MemberGrid.Size = new System.Drawing.Size(794, 427);
            this.MemberGrid.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn9.HeaderText = "No.";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 27670;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.Width = 47;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn10.HeaderText = "Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 58;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn11.HeaderText = "CNIC";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 55;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn12.HeaderText = "Email";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.Width = 55;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn13.HeaderText = "Ph. No.";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.Width = 66;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn14.HeaderText = "Address";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 68;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn15.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn15.Width = 65;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn16.HeaderText = "Team ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.Width = 71;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(929, 484);
            this.Controls.Add(this.MemberGrid);
            this.Controls.Add(this.HidenPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "MembersForm";
            this.Tag = "Members";
            this.Activated += new System.EventHandler(this.MembersForm_Activated);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.HidenPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label HeadingLable;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel HidenPanel;
        private System.Windows.Forms.Panel RightPanel;
        private FontAwesome.Sharp.IconButton DeleteIconButton;
        private FontAwesome.Sharp.IconButton UpdateIconButton;
        private FontAwesome.Sharp.IconButton AddIconButton;
        private System.Windows.Forms.DataGridView MemberGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}