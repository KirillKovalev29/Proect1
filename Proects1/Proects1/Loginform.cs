using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proects1
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void panellogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();
            // Создадим новый прямоугольник с размерами кнопки 
            Rectangle smallRectangle = btnEnter.ClientRectangle;
            // уменьшим размеры прямоугольника 
            smallRectangle.Inflate(-3, -3);
            // создадим эллипс, используя полученные размеры 
            gp.AddEllipse(smallRectangle);
            btnEnter.Region = new Region(gp);
            // рисуем окантовоку для круглой кнопки 
            g.DrawEllipse(new Pen(Color.Gray, 2),
            btnEnter.Left + 1,
            btnEnter.Top + 1,
            btnEnter.Width - 3,
            btnEnter.Height - 3);
            // освобождаем ресурсы 
            g.Dispose();

            if(cmbRole.SelectedItem.ToString() == "Администратор")
            {
                if(txtLogin.Text == "admin" && txtPassword.Text == "123456")
                {
                    MessageBox.Show("Добро Пожаловать, '"+cmbRole.SelectedItem.ToString()+"'!");
                    Adminforms ad = new Adminforms();
                    ad.Show();
                    this.Close();
                
                }
                else
                {
                    MessageBox.Show("Логин или Пароль введены неверно!!");
                }

            }
            
            if (cmbRole.SelectedItem.ToString() == "Менеджер")
            {
                if (txtLogin.Text == "menejer" && txtPassword.Text == "345678")
                {
                    MessageBox.Show("Добро Пожаловать, '" + cmbRole.SelectedItem.ToString() + "'!");
                    Menejerforms mjf = new Menejerforms();
                    mjf.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Логин или Пароль введены неверно!!");
                }

            }
            if (cmbRole.SelectedItem.ToString() == "Клиент")
            {
                if (txtLogin.Text == "klient" && txtPassword.Text == "121212")
                {
                    MessageBox.Show("Добро Пожаловать, '" + cmbRole.SelectedItem.ToString() + "'!");
                    Klientforms kf = new Klientforms();
                    kf.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Логин или Пароль введены неверно!!");
                }

            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbAutorization_Click(object sender, EventArgs e)
        {

        }

        private void lbRegistration_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
            this.Close();
        }

        private void lbRegistration_MouseClick(object sender, MouseEventArgs e)
        {
            lbRegistration.BackColor = Color.FromArgb(212, 15, 28);
        }

        private void checkpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpassword.Checked) 
            {
                txtPassword.UseSystemPasswordChar = true;
              //  txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
               // txtPassword.UseSystemPasswordChar = true;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txtPassword.Focus();
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                btnEnter.Focus();
            }
        }
        //private void picBox_Click(object sender, EventArgs e)
        //{

        //}

        //private void panelmenu_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
