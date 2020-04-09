namespace Kaar_E_Kamal
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.SignInWarningLabel = new System.Windows.Forms.Label();
            this.EmailWarningLabel = new System.Windows.Forms.Label();
            this.PasswordWarningLabel = new System.Windows.Forms.Label();
            this.NameWarningLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailPic = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.AdminPic = new System.Windows.Forms.PictureBox();
            this.MemberPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordPic = new System.Windows.Forms.PictureBox();
            this.NamePic = new System.Windows.Forms.PictureBox();
            this.LoginPic = new System.Windows.Forms.PictureBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.FormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Controls.Add(this.PassBox);
            this.FormPanel.Controls.Add(this.SignInWarningLabel);
            this.FormPanel.Controls.Add(this.EmailWarningLabel);
            this.FormPanel.Controls.Add(this.PasswordWarningLabel);
            this.FormPanel.Controls.Add(this.NameWarningLabel);
            this.FormPanel.Controls.Add(this.NameBox);
            this.FormPanel.Controls.Add(this.EmailPic);
            this.FormPanel.Controls.Add(this.CloseLabel);
            this.FormPanel.Controls.Add(this.AdminPic);
            this.FormPanel.Controls.Add(this.MemberPic);
            this.FormPanel.Controls.Add(this.label1);
            this.FormPanel.Controls.Add(this.panel3);
            this.FormPanel.Controls.Add(this.panel2);
            this.FormPanel.Controls.Add(this.panel1);
            this.FormPanel.Controls.Add(this.EmailBox);
            this.FormPanel.Controls.Add(this.PasswordPic);
            this.FormPanel.Controls.Add(this.NamePic);
            this.FormPanel.Controls.Add(this.LoginPic);
            this.FormPanel.Controls.Add(this.SignInButton);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(362, 541);
            this.FormPanel.TabIndex = 0;
            this.FormPanel.Click += new System.EventHandler(this.FormPanel_Click);
            this.FormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseDown);
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.ForeColor = System.Drawing.Color.Gray;
            this.PassBox.Location = new System.Drawing.Point(72, 230);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(236, 19);
            this.PassBox.TabIndex = 51;
            this.PassBox.Tag = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[_\\-@#$%&!<>^,*`~?+:,.|])(?!.*[=;])(?=.{8," +
    "})";
            this.PassBox.Text = "Password";
            this.PassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassBox.Enter += new System.EventHandler(this.PassBox_Enter);
            this.PassBox.Leave += new System.EventHandler(this.PassBox_Leave);
            // 
            // SignInWarningLabel
            // 
            this.SignInWarningLabel.AutoSize = true;
            this.SignInWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignInWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SignInWarningLabel.Location = new System.Drawing.Point(312, 361);
            this.SignInWarningLabel.Name = "SignInWarningLabel";
            this.SignInWarningLabel.Size = new System.Drawing.Size(12, 13);
            this.SignInWarningLabel.TabIndex = 49;
            this.SignInWarningLabel.Text = "*";
            // 
            // EmailWarningLabel
            // 
            this.EmailWarningLabel.AutoSize = true;
            this.EmailWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.EmailWarningLabel.Location = new System.Drawing.Point(312, 307);
            this.EmailWarningLabel.Name = "EmailWarningLabel";
            this.EmailWarningLabel.Size = new System.Drawing.Size(12, 13);
            this.EmailWarningLabel.TabIndex = 48;
            this.EmailWarningLabel.Text = "*";
            // 
            // PasswordWarningLabel
            // 
            this.PasswordWarningLabel.AutoSize = true;
            this.PasswordWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PasswordWarningLabel.Location = new System.Drawing.Point(312, 243);
            this.PasswordWarningLabel.Name = "PasswordWarningLabel";
            this.PasswordWarningLabel.Size = new System.Drawing.Size(12, 13);
            this.PasswordWarningLabel.TabIndex = 47;
            this.PasswordWarningLabel.Text = "*";
            // 
            // NameWarningLabel
            // 
            this.NameWarningLabel.AutoSize = true;
            this.NameWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.NameWarningLabel.Location = new System.Drawing.Point(312, 180);
            this.NameWarningLabel.Name = "NameWarningLabel";
            this.NameWarningLabel.Size = new System.Drawing.Size(12, 13);
            this.NameWarningLabel.TabIndex = 46;
            this.NameWarningLabel.Text = "*";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.Color.Gray;
            this.NameBox.Location = new System.Drawing.Point(72, 167);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(236, 19);
            this.NameBox.TabIndex = 44;
            this.NameBox.Tag = "^[a-zA-Z]+([ -]?[a-zA-Z])*$";
            this.NameBox.Text = "Username";
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.NameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // EmailPic
            // 
            this.EmailPic.BackColor = System.Drawing.Color.Transparent;
            this.EmailPic.BackgroundImage = global::Kaar_E_Kamal.Properties.Resources.mail;
            this.EmailPic.Location = new System.Drawing.Point(42, 289);
            this.EmailPic.Name = "EmailPic";
            this.EmailPic.Size = new System.Drawing.Size(24, 24);
            this.EmailPic.TabIndex = 43;
            this.EmailPic.TabStop = false;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.CloseLabel.Font = new System.Drawing.Font("Lovelo Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLabel.Location = new System.Drawing.Point(343, 0);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(19, 20);
            this.CloseLabel.TabIndex = 42;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            this.CloseLabel.MouseHover += new System.EventHandler(this.CloseLabel_MouseHover);
            // 
            // AdminPic
            // 
            this.AdminPic.BackColor = System.Drawing.Color.Transparent;
            this.AdminPic.BackgroundImage = global::Kaar_E_Kamal.Properties.Resources.admin0;
            this.AdminPic.Location = new System.Drawing.Point(250, 402);
            this.AdminPic.Name = "AdminPic";
            this.AdminPic.Size = new System.Drawing.Size(32, 32);
            this.AdminPic.TabIndex = 41;
            this.AdminPic.TabStop = false;
            this.AdminPic.Click += new System.EventHandler(this.AdminPic_Click);
            this.AdminPic.MouseLeave += new System.EventHandler(this.AdminPic_MouseLeave);
            this.AdminPic.MouseHover += new System.EventHandler(this.AdminPic_MouseHover);
            // 
            // MemberPic
            // 
            this.MemberPic.BackColor = System.Drawing.Color.Transparent;
            this.MemberPic.BackgroundImage = global::Kaar_E_Kamal.Properties.Resources.Member0;
            this.MemberPic.Location = new System.Drawing.Point(63, 402);
            this.MemberPic.Name = "MemberPic";
            this.MemberPic.Size = new System.Drawing.Size(32, 32);
            this.MemberPic.TabIndex = 40;
            this.MemberPic.TabStop = false;
            this.MemberPic.Click += new System.EventHandler(this.MemberPic_Click);
            this.MemberPic.MouseLeave += new System.EventHandler(this.MemberPic_MouseLeave);
            this.MemberPic.MouseHover += new System.EventHandler(this.MemberPic_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lovelo Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sign-In As";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(42, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 1);
            this.panel3.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(42, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 1);
            this.panel2.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(42, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 1);
            this.panel1.TabIndex = 36;
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.Color.Gray;
            this.EmailBox.Location = new System.Drawing.Point(72, 294);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(236, 19);
            this.EmailBox.TabIndex = 35;
            this.EmailBox.Tag = "[a-z0-9!#$%&\'*+/?^_`{|}~-]+(?:\\.[a-z0-9!#$%&\'*+/?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0" +
    "-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            this.EmailBox.Text = "Someone@something.com";
            this.EmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailBox.Enter += new System.EventHandler(this.EmailBox_Enter);
            this.EmailBox.Leave += new System.EventHandler(this.EmailBox_Leave);
            // 
            // PasswordPic
            // 
            this.PasswordPic.BackColor = System.Drawing.Color.Transparent;
            this.PasswordPic.BackgroundImage = global::Kaar_E_Kamal.Properties.Resources.password;
            this.PasswordPic.Location = new System.Drawing.Point(42, 225);
            this.PasswordPic.Name = "PasswordPic";
            this.PasswordPic.Size = new System.Drawing.Size(24, 24);
            this.PasswordPic.TabIndex = 34;
            this.PasswordPic.TabStop = false;
            // 
            // NamePic
            // 
            this.NamePic.BackColor = System.Drawing.Color.Transparent;
            this.NamePic.BackgroundImage = global::Kaar_E_Kamal.Properties.Resources.login0;
            this.NamePic.Location = new System.Drawing.Point(42, 162);
            this.NamePic.Name = "NamePic";
            this.NamePic.Size = new System.Drawing.Size(24, 24);
            this.NamePic.TabIndex = 33;
            this.NamePic.TabStop = false;
            // 
            // LoginPic
            // 
            this.LoginPic.BackColor = System.Drawing.Color.Transparent;
            this.LoginPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPic.BackgroundImage")));
            this.LoginPic.Location = new System.Drawing.Point(155, 41);
            this.LoginPic.Name = "LoginPic";
            this.LoginPic.Size = new System.Drawing.Size(64, 64);
            this.LoginPic.TabIndex = 32;
            this.LoginPic.TabStop = false;
            this.LoginPic.Click += new System.EventHandler(this.FormPanel_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.SignInButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Lovelo Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(42, 475);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(266, 30);
            this.SignInButton.TabIndex = 31;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(362, 541);
            this.Controls.Add(this.FormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Label SignInWarningLabel;
        private System.Windows.Forms.Label EmailWarningLabel;
        private System.Windows.Forms.Label PasswordWarningLabel;
        private System.Windows.Forms.Label NameWarningLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox EmailPic;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.PictureBox AdminPic;
        private System.Windows.Forms.PictureBox MemberPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.PictureBox PasswordPic;
        private System.Windows.Forms.PictureBox NamePic;
        private System.Windows.Forms.PictureBox LoginPic;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox PassBox;
    }
}

