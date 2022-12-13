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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void lbRegistration_Click(object sender, EventArgs e)
        {

        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Loginform lgf= new Loginform();
            lgf.Show();
            this.Close();
        }
    }
}
