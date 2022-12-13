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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pBar.Value= 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // timers.Start();
        }
        //int startPoint = 0;
        private void prgbforms_Click(object sender, EventArgs e)
        {

        }

        //private void timers_Tick(object sender, EventArgs e)
        //{
           
        //}

        private void timers_Tick_1(object sender, EventArgs e)
        {
            pBar.Value += 1;
            pBar.Text = pBar.Value.ToString() + "%";
            if(pBar.Value ==100)
            {
                timers.Enabled = false;
                timers.Stop();  
                Loginform loginform= new Loginform();
                this.Hide();
                loginform.Show();   
            }

        }
    }
}
