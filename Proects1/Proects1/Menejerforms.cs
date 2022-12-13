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
    public partial class Menejerforms : Form
    {
        public Menejerforms()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
        }

        private void lb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
