using Proects1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proects1
{
    public partial class Adminforms : Form
    {
        public Adminforms()
        {
            InitializeComponent();
        }
        public void loadsforms(object Form)
        {
            if (this.panelsmenu.Controls.Count > 0)
                this.panelsmenu.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelsmenu.Controls.Add(f);
            this.panelsmenu.Tag= f;
            f.Show();
            

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb1_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
        }

        private void lb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmobil_Click(object sender, EventArgs e)
        {
            loadsforms(new Automobile());
        }

        private void btnSotrudnik_Click(object sender, EventArgs e)
        {
            loadsforms(new Workers());
        }

        private void btnPostavtschiki_Click(object sender, EventArgs e)
        {
            loadsforms(new Postavstchiki());
        }

        private void btnPostavki_Click(object sender, EventArgs e)
        {
            loadsforms(new Postavki());
        }

        private void btnklient_Click(object sender, EventArgs e)
        {
            loadsforms(new Klients());
        }
    }
}
