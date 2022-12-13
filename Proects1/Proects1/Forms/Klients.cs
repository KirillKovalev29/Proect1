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
    public partial class Klients : Form
    {
        // строка подключения к бд
        SqlConnection con = new SqlConnection(@"Data Source = KIRILL-KOVALEV; Initial Catalog = Автосалон_союз; Integrated Security = true");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        int Klientid;
        public Klients()
        {
            InitializeComponent();
            displayData();
        }

        private void Klients_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e) //кнопка добавления
        {
            con.Open();
            cmd = new SqlCommand("insert into Клиенты values('"+txtsurname.Text+"','"+txtname.Text+"','"+txtmiddlename.Text+"','"+txtaddress.Text+"','"+txttelefone.Text+"','"+txtidmobile.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Даные успешно добавлены в базу данных!");
            con.Close();
            displayData();
            Clear();
        }
        public void displayData() // показ таблицы в датагридвью
        {
            con.Open();
            adapter = new SqlDataAdapter("select * from Клиенты", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvBD.DataSource = dt;
            con.Close();
        }
        public void Clear()
        {
            txtsurname.Text = "";
            txtname.Text = "";
            txtmiddlename.Text = "";
            txtaddress.Text = "";
            txttelefone.Text = "";
            txtidmobile.Text = "";

        }

        private void dgvBD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e) // Кнопка сохранения изменения
        {
            try
            { 
            con.Open();
            cmd = new SqlCommand("update Клиенты set Фамилия = '"+txtsurname.Text+"',Имя = '"+txtname.Text+"', Отчество = '"+txtmiddlename.Text+"',Адрес = '"+txtaddress.Text+"',Телефон = '"+txttelefone.Text+"',Id_автомобиля = '"+txtidmobile.Text+"' where ID_клиента ='"+Klientid+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно обновленны!");
            con.Close();
            displayData();
            }
            catch(Exception)
            {
                throw;
            }
            }

        private void btndelete_Click(object sender, EventArgs e)  // Кнопка удаления
        {
            con.Open();
            cmd = new SqlCommand("delete from Клиенты where ID_клиента = '"+Klientid+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
        }

        private void txtsurname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtsurname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtname.Focus();
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtmiddlename.Focus();
            }
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
                txttelefone.Focus(); 
            }
        }

        private void txttelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txtidmobile.Focus();
            }
        }

        private void dgvBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Klientid = Convert.ToInt32(dgvBD.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtsurname.Text = dgvBD.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtname.Text = dgvBD.Rows[e.RowIndex].Cells[2].Value.ToString();
           // txtmiddlename.Text = dgvBD.Rows[0].Cells[3].Value.ToString();
            txtmiddlename.Text = dgvBD.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtaddress.Text = dgvBD.Rows[e.RowIndex].Cells[4].Value.ToString();
            txttelefone.Text = dgvBD.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtidmobile.Text = dgvBD.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
