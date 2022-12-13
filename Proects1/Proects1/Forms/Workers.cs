using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proects1.Forms
{
    public partial class Workers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = KIRILL-KOVALEV; Initial Catalog = Автосалон_союз; Integrated Security = true");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        int Idworker;
        
        public Workers()
        {
            InitializeComponent();
            displayDate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Сотрудники values('"+txtsurname.Text+"','"+txtname.Text+"','"+txtmiddlename.Text+"','"+txtaddress.Text+"','"+txttelefon.Text+"','"+txtzandoljn.Text+"') ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно добавлено!");
            con.Close();
            displayDate();
            Clianer();
        }

        private void Clianer() 
        {
            txtsurname.Text = "";
            txtname.Text = "";
            txtmiddlename.Text = "";
            txtaddress.Text = "";
            txttelefon.Text = "";
            txtzandoljn.Text = "";
        }
        private void displayDate()
        {
            con.Open();
            adapter = new SqlDataAdapter("select* from Сотрудники", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvBD.DataSource = dt;
            con.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update Сотрудники set Фамилия = '"+txtsurname.Text+"',Имя = '"+txtname.Text+"',Отчество = '"+txtmiddlename.Text+"',Адрес = '"+txtaddress.Text+"',Телефон = '"+txttelefon.Text+"',Занимаемая_должность = '"+txtzandoljn.Text+"' where ID_сотрудника = '"+Idworker+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно обновленны!");
            con.Close();
            displayDate();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from Сотрудники where ID_сотрудника = '"+Idworker+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно удалены!");
            con.Close();
            displayDate();
        }

        private void dgvBD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Idworker = Convert.ToInt32(dgvBD.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtsurname.Text = dgvBD.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtname.Text = dgvBD.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmiddlename.Text = dgvBD.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtaddress.Text = dgvBD.Rows[e.RowIndex].Cells[4].Value.ToString(); 
            txttelefon.Text = dgvBD.Rows[e.RowIndex].Cells[5].Value.ToString(); 
            txtzandoljn.Text = dgvBD.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void txtsurname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txtname.Focus();
            }
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txtmiddlename.Focus(); 
            
            }
        }

        private void txtmiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmiddlename_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txtaddress.Focus();
            }
        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            { 
                txttelefon.Focus();
            }
        }

        private void txttelefon_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txtzandoljn.Focus();
            }
        }
    }
}
