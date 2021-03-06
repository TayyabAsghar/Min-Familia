﻿namespace Kaar_E_Kamal
{
    partial class DetailsForm
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.CloseIconButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.CNICMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.PasswordWarningLabel = new System.Windows.Forms.Label();
            this.AddressWarningLabel = new System.Windows.Forms.Label();
            this.NumberWarningLabel = new System.Windows.Forms.Label();
            this.CNICWarningLabel = new System.Windows.Forms.Label();
            this.GenderWarningLabel = new System.Windows.Forms.Label();
            this.EmailWarningLabel = new System.Windows.Forms.Label();
            this.NameWarningLabel = new System.Windows.Forms.Label();
            this.AddressRichBox = new System.Windows.Forms.RichTextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelIconButton = new FontAwesome.Sharp.IconButton();
            this.IconButton = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BorderPanel.SuspendLayout();
            this.HeadingPanel.SuspendLayout();
            this.FormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.HeadingLabel.Font = new System.Drawing.Font("Lovelo Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.HeadingLabel.Location = new System.Drawing.Point(347, 18);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(90, 24);
            this.HeadingLabel.TabIndex = 8;
            this.HeadingLabel.Text = "Heading";
            // 
            // BorderPanel
            // 
            this.BorderPanel.BackColor = System.Drawing.Color.Black;
            this.BorderPanel.Controls.Add(this.CloseIconButton);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderPanel.Location = new System.Drawing.Point(0, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(800, 28);
            this.BorderPanel.TabIndex = 50;
            this.BorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderPanel_MouseDown);
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
            this.CloseIconButton.Location = new System.Drawing.Point(763, 0);
            this.CloseIconButton.Name = "CloseIconButton";
            this.CloseIconButton.Rotation = 0D;
            this.CloseIconButton.Size = new System.Drawing.Size(37, 28);
            this.CloseIconButton.TabIndex = 0;
            this.CloseIconButton.UseVisualStyleBackColor = true;
            this.CloseIconButton.Click += new System.EventHandler(this.CloseIconButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 8);
            this.panel1.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(792, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 414);
            this.panel2.TabIndex = 73;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 414);
            this.panel3.TabIndex = 74;
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.Controls.Add(this.HeadingLabel);
            this.HeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingPanel.Location = new System.Drawing.Point(8, 28);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(784, 55);
            this.HeadingPanel.TabIndex = 75;
            // 
            // FormPanel
            // 
            this.FormPanel.Controls.Add(this.PasswordBox);
            this.FormPanel.Controls.Add(this.NumberBox);
            this.FormPanel.Controls.Add(this.EmailBox);
            this.FormPanel.Controls.Add(this.CNICMaskedBox);
            this.FormPanel.Controls.Add(this.PasswordWarningLabel);
            this.FormPanel.Controls.Add(this.AddressWarningLabel);
            this.FormPanel.Controls.Add(this.NumberWarningLabel);
            this.FormPanel.Controls.Add(this.CNICWarningLabel);
            this.FormPanel.Controls.Add(this.GenderWarningLabel);
            this.FormPanel.Controls.Add(this.EmailWarningLabel);
            this.FormPanel.Controls.Add(this.NameWarningLabel);
            this.FormPanel.Controls.Add(this.AddressRichBox);
            this.FormPanel.Controls.Add(this.GenderBox);
            this.FormPanel.Controls.Add(this.NameBox);
            this.FormPanel.Controls.Add(this.label6);
            this.FormPanel.Controls.Add(this.Passlabel);
            this.FormPanel.Controls.Add(this.label3);
            this.FormPanel.Controls.Add(this.CancelIconButton);
            this.FormPanel.Controls.Add(this.IconButton);
            this.FormPanel.Controls.Add(this.label10);
            this.FormPanel.Controls.Add(this.label9);
            this.FormPanel.Controls.Add(this.label8);
            this.FormPanel.Controls.Add(this.label7);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(8, 83);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(784, 359);
            this.FormPanel.TabIndex = 0;
            this.FormPanel.Click += new System.EventHandler(this.FormPanel_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(136, 209);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(215, 22);
            this.PasswordBox.TabIndex = 109;
            this.PasswordBox.Tag = "";
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(136, 154);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(215, 22);
            this.NumberBox.TabIndex = 108;
            this.NumberBox.Tag = "";
            this.NumberBox.Enter += new System.EventHandler(this.NumberBox_Enter);
            this.NumberBox.Leave += new System.EventHandler(this.NumberBox_Leave);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(136, 95);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(215, 22);
            this.EmailBox.TabIndex = 107;
            this.EmailBox.Tag = "";
            this.EmailBox.Enter += new System.EventHandler(this.EmailBox_Enter);
            this.EmailBox.Leave += new System.EventHandler(this.EmailBox_Leave);
            // 
            // CNICMaskedBox
            // 
            this.CNICMaskedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNICMaskedBox.Location = new System.Drawing.Point(530, 37);
            this.CNICMaskedBox.Mask = "00000-0000000-0";
            this.CNICMaskedBox.Name = "CNICMaskedBox";
            this.CNICMaskedBox.Size = new System.Drawing.Size(176, 22);
            this.CNICMaskedBox.TabIndex = 106;
            this.CNICMaskedBox.ValidatingType = typeof(System.DateTime);
            this.CNICMaskedBox.Enter += new System.EventHandler(this.CNICMaskedBox_Enter);
            this.CNICMaskedBox.Leave += new System.EventHandler(this.CNICMaskedBox_Leave);
            // 
            // PasswordWarningLabel
            // 
            this.PasswordWarningLabel.AutoSize = true;
            this.PasswordWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.PasswordWarningLabel.Location = new System.Drawing.Point(357, 213);
            this.PasswordWarningLabel.Name = "PasswordWarningLabel";
            this.PasswordWarningLabel.Size = new System.Drawing.Size(16, 20);
            this.PasswordWarningLabel.TabIndex = 105;
            this.PasswordWarningLabel.Text = "*";
            // 
            // AddressWarningLabel
            // 
            this.AddressWarningLabel.AutoSize = true;
            this.AddressWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.AddressWarningLabel.Location = new System.Drawing.Point(712, 161);
            this.AddressWarningLabel.Name = "AddressWarningLabel";
            this.AddressWarningLabel.Size = new System.Drawing.Size(16, 20);
            this.AddressWarningLabel.TabIndex = 104;
            this.AddressWarningLabel.Text = "*";
            // 
            // NumberWarningLabel
            // 
            this.NumberWarningLabel.AutoSize = true;
            this.NumberWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumberWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.NumberWarningLabel.Location = new System.Drawing.Point(357, 157);
            this.NumberWarningLabel.Name = "NumberWarningLabel";
            this.NumberWarningLabel.Size = new System.Drawing.Size(16, 20);
            this.NumberWarningLabel.TabIndex = 103;
            this.NumberWarningLabel.Text = "*";
            // 
            // CNICWarningLabel
            // 
            this.CNICWarningLabel.AutoSize = true;
            this.CNICWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.CNICWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNICWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.CNICWarningLabel.Location = new System.Drawing.Point(712, 40);
            this.CNICWarningLabel.Name = "CNICWarningLabel";
            this.CNICWarningLabel.Size = new System.Drawing.Size(16, 20);
            this.CNICWarningLabel.TabIndex = 102;
            this.CNICWarningLabel.Text = "*";
            // 
            // GenderWarningLabel
            // 
            this.GenderWarningLabel.AutoSize = true;
            this.GenderWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenderWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.GenderWarningLabel.Location = new System.Drawing.Point(712, 97);
            this.GenderWarningLabel.Name = "GenderWarningLabel";
            this.GenderWarningLabel.Size = new System.Drawing.Size(16, 20);
            this.GenderWarningLabel.TabIndex = 101;
            this.GenderWarningLabel.Text = "*";
            // 
            // EmailWarningLabel
            // 
            this.EmailWarningLabel.AutoSize = true;
            this.EmailWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.EmailWarningLabel.Location = new System.Drawing.Point(357, 99);
            this.EmailWarningLabel.Name = "EmailWarningLabel";
            this.EmailWarningLabel.Size = new System.Drawing.Size(16, 20);
            this.EmailWarningLabel.TabIndex = 100;
            this.EmailWarningLabel.Text = "*";
            // 
            // NameWarningLabel
            // 
            this.NameWarningLabel.AutoSize = true;
            this.NameWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.NameWarningLabel.Location = new System.Drawing.Point(357, 41);
            this.NameWarningLabel.Name = "NameWarningLabel";
            this.NameWarningLabel.Size = new System.Drawing.Size(16, 20);
            this.NameWarningLabel.TabIndex = 99;
            this.NameWarningLabel.Text = "*";
            // 
            // AddressRichBox
            // 
            this.AddressRichBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressRichBox.Location = new System.Drawing.Point(530, 157);
            this.AddressRichBox.Name = "AddressRichBox";
            this.AddressRichBox.Size = new System.Drawing.Size(176, 76);
            this.AddressRichBox.TabIndex = 98;
            this.AddressRichBox.Text = "";
            this.AddressRichBox.Enter += new System.EventHandler(this.AddressRichBox_Enter);
            this.AddressRichBox.Leave += new System.EventHandler(this.AddressRichBox_Leave);
            // 
            // GenderBox
            // 
            this.GenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unspecified"});
            this.GenderBox.Location = new System.Drawing.Point(530, 95);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(176, 24);
            this.GenderBox.TabIndex = 97;
            this.GenderBox.TextChanged += new System.EventHandler(this.GenderBox_TextChanged);
            this.GenderBox.Enter += new System.EventHandler(this.GenderBox_Enter);
            this.GenderBox.Leave += new System.EventHandler(this.GenderBox_Leave);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(136, 39);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(215, 22);
            this.NameBox.TabIndex = 95;
            this.NameBox.Tag = "";
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.NameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(417, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 94;
            this.label6.Text = "Gender";
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.Passlabel.Location = new System.Drawing.Point(40, 212);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(78, 17);
            this.Passlabel.TabIndex = 93;
            this.Passlabel.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(40, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 92;
            this.label3.Text = "Name";
            // 
            // CancelIconButton
            // 
            this.CancelIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.CancelIconButton.FlatAppearance.BorderSize = 0;
            this.CancelIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CancelIconButton.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelIconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CancelIconButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.CancelIconButton.IconColor = System.Drawing.Color.LightGray;
            this.CancelIconButton.IconSize = 16;
            this.CancelIconButton.Location = new System.Drawing.Point(530, 300);
            this.CancelIconButton.Name = "CancelIconButton";
            this.CancelIconButton.Rotation = 0D;
            this.CancelIconButton.Size = new System.Drawing.Size(81, 32);
            this.CancelIconButton.TabIndex = 91;
            this.CancelIconButton.Text = "Cancle";
            this.CancelIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CancelIconButton.UseVisualStyleBackColor = false;
            this.CancelIconButton.Click += new System.EventHandler(this.CancelIconButton_Click);
            // 
            // IconButton
            // 
            this.IconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.IconButton.FlatAppearance.BorderSize = 0;
            this.IconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IconButton.IconColor = System.Drawing.Color.LightGray;
            this.IconButton.IconSize = 16;
            this.IconButton.Location = new System.Drawing.Point(625, 300);
            this.IconButton.Name = "IconButton";
            this.IconButton.Rotation = 0D;
            this.IconButton.Size = new System.Drawing.Size(81, 32);
            this.IconButton.TabIndex = 90;
            this.IconButton.Text = "Add";
            this.IconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.IconButton.UseVisualStyleBackColor = false;
            this.IconButton.Click += new System.EventHandler(this.IconButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(421, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 87;
            this.label10.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(39, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 86;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(39, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Phone No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(421, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 84;
            this.label7.Text = "CNIC";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.HeadingPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.BorderPanel.ResumeLayout(false);
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label HeadingLabel;
        private FontAwesome.Sharp.IconButton CloseIconButton;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.MaskedTextBox CNICMaskedBox;
        private System.Windows.Forms.Label PasswordWarningLabel;
        private System.Windows.Forms.Label AddressWarningLabel;
        private System.Windows.Forms.Label NumberWarningLabel;
        private System.Windows.Forms.Label CNICWarningLabel;
        private System.Windows.Forms.Label GenderWarningLabel;
        private System.Windows.Forms.Label EmailWarningLabel;
        private System.Windows.Forms.Label NameWarningLabel;
        private System.Windows.Forms.RichTextBox AddressRichBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton CancelIconButton;
        private FontAwesome.Sharp.IconButton IconButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NameBox;
    }
}