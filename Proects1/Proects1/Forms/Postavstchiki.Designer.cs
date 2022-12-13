namespace Proects1.Forms
{
    partial class Postavstchiki
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
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.middlename = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sername = new System.Windows.Forms.Label();
            this.txtidpostavki = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.panellogin = new System.Windows.Forms.Panel();
            this.dgvBD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(584, 200);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 56;
            this.cmbFilter.Text = "Фильтрация";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(388, 200);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(121, 21);
            this.cmbSort.TabIndex = 55;
            this.cmbSort.Text = "Сортировка";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(18, 200);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(319, 20);
            this.txtSearch.TabIndex = 54;
            this.txtSearch.Text = "Введите для поиска...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Код_поставки";
            // 
            // middlename
            // 
            this.middlename.AutoSize = true;
            this.middlename.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middlename.ForeColor = System.Drawing.Color.White;
            this.middlename.Location = new System.Drawing.Point(290, 31);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(72, 19);
            this.middlename.TabIndex = 49;
            this.middlename.Text = "Отчество";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(16, 91);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(39, 19);
            this.name.TabIndex = 47;
            this.name.Text = "Имя";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(531, 411);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 32);
            this.btndelete.TabIndex = 46;
            this.btndelete.Text = "Удалить";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(328, 411);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 32);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "Сохранить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(121, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sername
            // 
            this.sername.AutoSize = true;
            this.sername.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sername.ForeColor = System.Drawing.Color.White;
            this.sername.Location = new System.Drawing.Point(16, 34);
            this.sername.Name = "sername";
            this.sername.Size = new System.Drawing.Size(74, 19);
            this.sername.TabIndex = 43;
            this.sername.Text = "Фамилия";
            // 
            // txtidpostavki
            // 
            this.txtidpostavki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtidpostavki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidpostavki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtidpostavki.ForeColor = System.Drawing.Color.White;
            this.txtidpostavki.Location = new System.Drawing.Point(453, 82);
            this.txtidpostavki.Multiline = true;
            this.txtidpostavki.Name = "txtidpostavki";
            this.txtidpostavki.Size = new System.Drawing.Size(138, 25);
            this.txtidpostavki.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(453, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 1);
            this.panel3.TabIndex = 37;
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtmiddlename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtmiddlename.ForeColor = System.Drawing.Color.White;
            this.txtmiddlename.Location = new System.Drawing.Point(453, 25);
            this.txtmiddlename.Multiline = true;
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(138, 25);
            this.txtmiddlename.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(453, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 1);
            this.panel2.TabIndex = 35;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtname.ForeColor = System.Drawing.Color.White;
            this.txtname.Location = new System.Drawing.Point(137, 79);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(138, 25);
            this.txtname.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(137, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 1);
            this.panel1.TabIndex = 33;
            // 
            // txtsurname
            // 
            this.txtsurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtsurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtsurname.ForeColor = System.Drawing.Color.White;
            this.txtsurname.Location = new System.Drawing.Point(137, 22);
            this.txtsurname.Multiline = true;
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(138, 25);
            this.txtsurname.TabIndex = 32;
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.White;
            this.panellogin.ForeColor = System.Drawing.Color.White;
            this.panellogin.Location = new System.Drawing.Point(137, 49);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(138, 1);
            this.panellogin.TabIndex = 31;
            // 
            // dgvBD
            // 
            this.dgvBD.BackgroundColor = System.Drawing.Color.White;
            this.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBD.Location = new System.Drawing.Point(18, 241);
            this.dgvBD.Name = "dgvBD";
            this.dgvBD.Size = new System.Drawing.Size(744, 150);
            this.dgvBD.TabIndex = 30;
            this.dgvBD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBD_CellClick);
            // 
            // Postavstchiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.sername);
            this.Controls.Add(this.txtidpostavki);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.dgvBD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Postavstchiki";
            this.Text = "Postavstchiki";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label middlename;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label sername;
        private System.Windows.Forms.TextBox txtidpostavki;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.DataGridView dgvBD;
    }
}