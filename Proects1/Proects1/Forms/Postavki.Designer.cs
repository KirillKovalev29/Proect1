namespace Proects1.Forms
{
    partial class Postavki
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
            this.lbdate = new System.Windows.Forms.Label();
            this.datepostavki = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbmobile = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtidmobile = new System.Windows.Forms.TextBox();
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
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbdate.ForeColor = System.Drawing.Color.White;
            this.lbdate.Location = new System.Drawing.Point(638, 8);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(110, 19);
            this.lbdate.TabIndex = 53;
            this.lbdate.Text = "Дата поставки";
            // 
            // datepostavki
            // 
            this.datepostavki.Location = new System.Drawing.Point(642, 30);
            this.datepostavki.Name = "datepostavki";
            this.datepostavki.Size = new System.Drawing.Size(142, 20);
            this.datepostavki.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(224, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Количество";
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
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
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
            // lbmobile
            // 
            this.lbmobile.AutoSize = true;
            this.lbmobile.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbmobile.ForeColor = System.Drawing.Color.White;
            this.lbmobile.Location = new System.Drawing.Point(16, 34);
            this.lbmobile.Name = "lbmobile";
            this.lbmobile.Size = new System.Drawing.Size(126, 19);
            this.lbmobile.TabIndex = 43;
            this.lbmobile.Text = "Код_автомабиля";
            // 
            // txtcost
            // 
            this.txtcost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtcost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcost.ForeColor = System.Drawing.Color.White;
            this.txtcost.Location = new System.Drawing.Point(365, 91);
            this.txtcost.Multiline = true;
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(138, 25);
            this.txtcost.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(365, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 1);
            this.panel4.TabIndex = 39;
            // 
            // txtcount
            // 
            this.txtcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcount.ForeColor = System.Drawing.Color.White;
            this.txtcount.Location = new System.Drawing.Point(454, 28);
            this.txtcount.Multiline = true;
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(138, 25);
            this.txtcount.TabIndex = 34;
            this.txtcount.TextChanged += new System.EventHandler(this.txtcount_TextChanged);
            this.txtcount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcount_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(454, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 1);
            this.panel1.TabIndex = 33;
            // 
            // txtidmobile
            // 
            this.txtidmobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtidmobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtidmobile.ForeColor = System.Drawing.Color.White;
            this.txtidmobile.Location = new System.Drawing.Point(157, 28);
            this.txtidmobile.Multiline = true;
            this.txtidmobile.Name = "txtidmobile";
            this.txtidmobile.Size = new System.Drawing.Size(138, 25);
            this.txtidmobile.TabIndex = 32;
            this.txtidmobile.TextChanged += new System.EventHandler(this.txtidmobile_TextChanged);
            this.txtidmobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidmobile_KeyDown);
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.White;
            this.panellogin.ForeColor = System.Drawing.Color.White;
            this.panellogin.Location = new System.Drawing.Point(157, 55);
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
            // Postavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.datepostavki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbmobile);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtidmobile);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.dgvBD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Postavki";
            this.Text = "Postavki";
            this.Load += new System.EventHandler(this.Postavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.DateTimePicker datepostavki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbmobile;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtidmobile;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.DataGridView dgvBD;
    }
}