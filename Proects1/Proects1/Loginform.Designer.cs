namespace Proects1
{
    partial class Loginform
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.panellogin = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lbAutorization = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.lbRegistration = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkpassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(12, 161);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(79, 28);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Логин";
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.White;
            this.panellogin.ForeColor = System.Drawing.Color.White;
            this.panellogin.Location = new System.Drawing.Point(194, 188);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(250, 1);
            this.panellogin.TabIndex = 1;
            this.panellogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panellogin_Paint);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(12, 215);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(95, 28);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Пароль";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(194, 161);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(250, 25);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(194, 215);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 25);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(194, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 4;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Location = new System.Drawing.Point(110, 291);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(243, 37);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lbAutorization
            // 
            this.lbAutorization.AutoSize = true;
            this.lbAutorization.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAutorization.ForeColor = System.Drawing.Color.White;
            this.lbAutorization.Location = new System.Drawing.Point(147, 26);
            this.lbAutorization.Name = "lbAutorization";
            this.lbAutorization.Size = new System.Drawing.Size(181, 31);
            this.lbAutorization.TabIndex = 7;
            this.lbAutorization.Text = "Авторизация";
            this.lbAutorization.Click += new System.EventHandler(this.lbAutorization_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbExit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(446, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(27, 28);
            this.lbExit.TabIndex = 8;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbRegistration
            // 
            this.lbRegistration.AutoSize = true;
            this.lbRegistration.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRegistration.ForeColor = System.Drawing.Color.White;
            this.lbRegistration.Location = new System.Drawing.Point(132, 331);
            this.lbRegistration.Name = "lbRegistration";
            this.lbRegistration.Size = new System.Drawing.Size(205, 25);
            this.lbRegistration.TabIndex = 9;
            this.lbRegistration.Text = "Зарегистрироваться";
            this.lbRegistration.Click += new System.EventHandler(this.lbRegistration_Click);
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
            this.cmbRole.Location = new System.Drawing.Point(270, 89);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(174, 29);
            this.cmbRole.TabIndex = 10;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип учетной записи";
            // 
            // checkpassword
            // 
            this.checkpassword.AutoSize = true;
            this.checkpassword.ForeColor = System.Drawing.Color.White;
            this.checkpassword.Location = new System.Drawing.Point(330, 249);
            this.checkpassword.Name = "checkpassword";
            this.checkpassword.Size = new System.Drawing.Size(114, 17);
            this.checkpassword.TabIndex = 12;
            this.checkpassword.Text = "Показать пароль";
            this.checkpassword.UseVisualStyleBackColor = true;
            this.checkpassword.CheckedChanged += new System.EventHandler(this.checkpassword_CheckedChanged);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(473, 381);
            this.Controls.Add(this.checkpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lbRegistration);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbAutorization);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.lbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorisation";
            this.Load += new System.EventHandler(this.Loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lbAutorization;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lbRegistration;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkpassword;
    }
}