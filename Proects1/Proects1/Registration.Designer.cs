namespace Proects1
{
    partial class Registration
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
            this.lbExit = new System.Windows.Forms.Label();
            this.lbRegistration = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.panellogin = new System.Windows.Forms.Panel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbExit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(585, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(27, 28);
            this.lbExit.TabIndex = 9;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // lbRegistration
            // 
            this.lbRegistration.AutoSize = true;
            this.lbRegistration.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRegistration.ForeColor = System.Drawing.Color.White;
            this.lbRegistration.Location = new System.Drawing.Point(215, 25);
            this.lbRegistration.Name = "lbRegistration";
            this.lbRegistration.Size = new System.Drawing.Size(173, 31);
            this.lbRegistration.TabIndex = 10;
            this.lbRegistration.Text = "Регистрация";
            this.lbRegistration.Click += new System.EventHandler(this.lbRegistration_Click);
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRole.ForeColor = System.Drawing.Color.White;
            this.lbRole.Location = new System.Drawing.Point(78, 115);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(231, 28);
            this.lbRole.TabIndex = 19;
            this.lbRole.Text = "Тип учетной записи";
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cmbRole.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbRole.ForeColor = System.Drawing.Color.White;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Клиент"});
            this.cmbRole.Location = new System.Drawing.Point(336, 114);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(174, 29);
            this.cmbRole.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(260, 240);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 25);
            this.txtName.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(260, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(260, 186);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(250, 25);
            this.txtSurname.TabIndex = 15;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(78, 237);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(60, 28);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Имя";
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.White;
            this.panellogin.ForeColor = System.Drawing.Color.White;
            this.panellogin.Location = new System.Drawing.Point(260, 213);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(250, 1);
            this.panellogin.TabIndex = 13;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(78, 186);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(114, 28);
            this.lbLogin.TabIndex = 12;
            this.lbLogin.Text = "Фамилия";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(260, 359);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(250, 25);
            this.txtLogin.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(260, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 24;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.White;
            this.txtMiddleName.Location = new System.Drawing.Point(260, 305);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(250, 25);
            this.txtMiddleName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Логин";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(260, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Отчество";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(260, 416);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 25);
            this.txtPassword.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(260, 443);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 1);
            this.panel5.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Пароль";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Location = new System.Drawing.Point(153, 486);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(243, 37);
            this.btnEnter.TabIndex = 30;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(612, 548);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbRegistration);
            this.Controls.Add(this.lbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lbRegistration;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnter;
    }
}