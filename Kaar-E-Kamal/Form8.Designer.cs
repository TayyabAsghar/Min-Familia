namespace Kaar_E_Kamal
{
    partial class CasesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Top = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.HeadingLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.HidenPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.DeleteIconButton = new FontAwesome.Sharp.IconButton();
            this.ApproveIconButton = new FontAwesome.Sharp.IconButton();
            this.CompletedIconButton = new FontAwesome.Sharp.IconButton();
            this.RejectIconButton = new FontAwesome.Sharp.IconButton();
            this.PendingIconButton = new FontAwesome.Sharp.IconButton();
            this.CasesGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddIconButton = new FontAwesome.Sharp.IconButton();
            this.Top.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.HidenPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CasesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Top.Controls.Add(this.SearchPanel);
            this.Top.Controls.Add(this.HeadingLable);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(17, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(912, 33);
            this.Top.TabIndex = 55;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchBox);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchPanel.Location = new System.Drawing.Point(547, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(365, 33);
            this.SearchPanel.TabIndex = 10;
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
            // HeadingLable
            // 
            this.HeadingLable.AutoSize = true;
            this.HeadingLable.Font = new System.Drawing.Font("Lovelo Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.HeadingLable.Location = new System.Drawing.Point(26, 6);
            this.HeadingLable.Name = "HeadingLable";
            this.HeadingLable.Size = new System.Drawing.Size(133, 24);
            this.HeadingLable.TabIndex = 0;
            this.HeadingLable.Text = "List Of Cases";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(17, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 24);
            this.panel1.TabIndex = 58;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(17, 484);
            this.LeftPanel.TabIndex = 56;
            // 
            // HidenPanel
            // 
            this.HidenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.HidenPanel.Controls.Add(this.RightPanel);
            this.HidenPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HidenPanel.Location = new System.Drawing.Point(811, 33);
            this.HidenPanel.Name = "HidenPanel";
            this.HidenPanel.Size = new System.Drawing.Size(118, 427);
            this.HidenPanel.TabIndex = 61;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.RightPanel.Controls.Add(this.AddIconButton);
            this.RightPanel.Controls.Add(this.DeleteIconButton);
            this.RightPanel.Controls.Add(this.ApproveIconButton);
            this.RightPanel.Controls.Add(this.CompletedIconButton);
            this.RightPanel.Controls.Add(this.RejectIconButton);
            this.RightPanel.Controls.Add(this.PendingIconButton);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(0, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(118, 427);
            this.RightPanel.TabIndex = 64;
            // 
            // DeleteIconButton
            // 
            this.DeleteIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.DeleteIconButton.FlatAppearance.BorderSize = 0;
            this.DeleteIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DeleteIconButton.Font = new System.Drawing.Font("Lovelo Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeleteIconButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteIconButton.IconColor = System.Drawing.Color.Gainsboro;
            this.DeleteIconButton.IconSize = 16;
            this.DeleteIconButton.Location = new System.Drawing.Point(6, 218);
            this.DeleteIconButton.Name = "DeleteIconButton";
            this.DeleteIconButton.Rotation = 0D;
            this.DeleteIconButton.Size = new System.Drawing.Size(103, 31);
            this.DeleteIconButton.TabIndex = 4;
            this.DeleteIconButton.Text = "Delete";
            this.DeleteIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DeleteIconButton.UseVisualStyleBackColor = false;
            this.DeleteIconButton.Click += new System.EventHandler(this.DeleteIconButton_Click);
            // 
            // ApproveIconButton
            // 
            this.ApproveIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.ApproveIconButton.FlatAppearance.BorderSize = 0;
            this.ApproveIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ApproveIconButton.Font = new System.Drawing.Font("Lovelo Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ApproveIconButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ApproveIconButton.IconColor = System.Drawing.Color.LightGray;
            this.ApproveIconButton.IconSize = 16;
            this.ApproveIconButton.Location = new System.Drawing.Point(6, 18);
            this.ApproveIconButton.Name = "ApproveIconButton";
            this.ApproveIconButton.Rotation = 0D;
            this.ApproveIconButton.Size = new System.Drawing.Size(103, 31);
            this.ApproveIconButton.TabIndex = 0;
            this.ApproveIconButton.Text = "Approve";
            this.ApproveIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ApproveIconButton.UseVisualStyleBackColor = false;
            this.ApproveIconButton.Click += new System.EventHandler(this.ApproveIconButton_Click);
            // 
            // CompletedIconButton
            // 
            this.CompletedIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.CompletedIconButton.FlatAppearance.BorderSize = 0;
            this.CompletedIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompletedIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CompletedIconButton.Font = new System.Drawing.Font("Lovelo Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CompletedIconButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.CompletedIconButton.IconColor = System.Drawing.Color.Gainsboro;
            this.CompletedIconButton.IconSize = 16;
            this.CompletedIconButton.Location = new System.Drawing.Point(6, 168);
            this.CompletedIconButton.Name = "CompletedIconButton";
            this.CompletedIconButton.Rotation = 0D;
            this.CompletedIconButton.Size = new System.Drawing.Size(103, 31);
            this.CompletedIconButton.TabIndex = 3;
            this.CompletedIconButton.Text = "Completed";
            this.CompletedIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CompletedIconButton.UseVisualStyleBackColor = false;
            this.CompletedIconButton.Click += new System.EventHandler(this.CompletedIconButton_Click);
            // 
            // RejectIconButton
            // 
            this.RejectIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.RejectIconButton.FlatAppearance.BorderSize = 0;
            this.RejectIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RejectIconButton.Font = new System.Drawing.Font("Lovelo Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.RejectIconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.RejectIconButton.IconColor = System.Drawing.Color.Gainsboro;
            this.RejectIconButton.IconSize = 16;
            this.RejectIconButton.Location = new System.Drawing.Point(6, 68);
            this.RejectIconButton.Name = "RejectIconButton";
            this.RejectIconButton.Rotation = 0D;
            this.RejectIconButton.Size = new System.Drawing.Size(103, 31);
            this.RejectIconButton.TabIndex = 1;
            this.RejectIconButton.Text = "Reject";
            this.RejectIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RejectIconButton.UseVisualStyleBackColor = false;
            this.RejectIconButton.Click += new System.EventHandler(this.RejectIconButton_Click);
            // 
            // PendingIconButton
            // 
            this.PendingIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.PendingIconButton.FlatAppearance.BorderSize = 0;
            this.PendingIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PendingIconButton.Font = new System.Drawing.Font("Lovelo Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.PendingIconButton.IconChar = FontAwesome.Sharp.IconChar.HourglassHalf;
            this.PendingIconButton.IconColor = System.Drawing.Color.Gainsboro;
            this.PendingIconButton.IconSize = 16;
            this.PendingIconButton.Location = new System.Drawing.Point(6, 118);
            this.PendingIconButton.Name = "PendingIconButton";
            this.PendingIconButton.Rotation = 0D;
            this.PendingIconButton.Size = new System.Drawing.Size(103, 31);
            this.PendingIconButton.TabIndex = 2;
            this.PendingIconButton.Text = "Pending";
            this.PendingIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PendingIconButton.UseVisualStyleBackColor = false;
            this.PendingIconButton.Click += new System.EventHandler(this.PendingIconButton_Click);
            // 
            // CasesGrid
            // 
            this.CasesGrid.AllowUserToAddRows = false;
            this.CasesGrid.AllowUserToDeleteRows = false;
            this.CasesGrid.AllowUserToOrderColumns = true;
            this.CasesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.CasesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CasesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CasesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CasesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.CasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CasesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.Col8,
            this.Col9});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CasesGrid.DefaultCellStyle = dataGridViewCellStyle29;
            this.CasesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CasesGrid.EnableHeadersVisualStyles = false;
            this.CasesGrid.Location = new System.Drawing.Point(17, 33);
            this.CasesGrid.Name = "CasesGrid";
            this.CasesGrid.ReadOnly = true;
            this.CasesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CasesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.CasesGrid.Size = new System.Drawing.Size(794, 427);
            this.CasesGrid.TabIndex = 62;
            this.CasesGrid.Tag = "";
            this.CasesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn9.HeaderText = "No.";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 27670;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.Width = 47;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn10.HeaderText = "Case ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn13.HeaderText = "Team ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.Width = 73;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn16.HeaderText = "Reference_ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.Width = 97;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn11.HeaderText = "Case Status";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn14.HeaderText = "Expected Support";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 115;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn15.HeaderText = "Total Support";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn15.Width = 95;
            // 
            // Col8
            // 
            this.Col8.HeaderText = "Approve/Reject/Accept";
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            this.Col8.Width = 115;
            // 
            // Col9
            // 
            this.Col9.HeaderText = "Completion Date";
            this.Col9.Name = "Col9";
            this.Col9.ReadOnly = true;
            this.Col9.Width = 115;
            // 
            // AddIconButton
            // 
            this.AddIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.AddIconButton.FlatAppearance.BorderSize = 0;
            this.AddIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddIconButton.Font = new System.Drawing.Font("Lovelo Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddIconButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddIconButton.IconColor = System.Drawing.Color.LightGray;
            this.AddIconButton.IconSize = 16;
            this.AddIconButton.Location = new System.Drawing.Point(6, 272);
            this.AddIconButton.Name = "AddIconButton";
            this.AddIconButton.Rotation = 0D;
            this.AddIconButton.Size = new System.Drawing.Size(103, 31);
            this.AddIconButton.TabIndex = 5;
            this.AddIconButton.Text = "Add";
            this.AddIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddIconButton.UseVisualStyleBackColor = false;
            this.AddIconButton.Click += new System.EventHandler(this.AddIconButton_Click);
            // 
            // CasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 484);
            this.Controls.Add(this.CasesGrid);
            this.Controls.Add(this.HidenPanel);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CasesForm";
            this.Tag = "Cases";
            this.Top.ResumeLayout(false);
            this.Top.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.HidenPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CasesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label HeadingLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel HidenPanel;
        private System.Windows.Forms.DataGridView CasesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col9;
        private System.Windows.Forms.Panel RightPanel;
        private FontAwesome.Sharp.IconButton DeleteIconButton;
        private FontAwesome.Sharp.IconButton ApproveIconButton;
        private FontAwesome.Sharp.IconButton CompletedIconButton;
        private FontAwesome.Sharp.IconButton RejectIconButton;
        private FontAwesome.Sharp.IconButton PendingIconButton;
        private FontAwesome.Sharp.IconButton AddIconButton;
    }
}