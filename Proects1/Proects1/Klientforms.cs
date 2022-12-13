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
    public partial class Klientforms : Form
    {
        public Klientforms()
        {
            InitializeComponent();
        }

        private void Klientforms_Load(object sender, EventArgs e)
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

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
