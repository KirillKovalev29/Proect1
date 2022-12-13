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
    public partial class Postavki : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = KIRILL-KOVALEV; Initial Catalog = Автосалон_союз; Integrated Security = true");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        int IdPostavki;

        public Postavki()
        {
            InitializeComponent();
            displayData();
        }

        private void Postavki_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Поставки set Id_автомобиля = '"+txtidmobile.Text+"',Дата_поставки = '"+datepostavki.Text+"',Количество = '"+txtcount.Text+"',Стоимость = '"+txtcost.Text+"' where ID_поставки = '"+IdPostavki+"' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно обновленны!");
                con.Close();
                displayData();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Поставки values('"+txtidmobile.Text+"','"+datepostavki.Text+"','"+txtcount.Text+"','"+txtcost.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно добавленны!");
            con.Close();
            displayData();
            Clear();
        }
        public void displayData()
        {
            con.Open();
            adapter = new SqlDataAdapter("select * from Поставки", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvBD.DataSource = dt;
            con.Close();

        }
        public void Clear()
        {
            txtidmobile.Text = "";
            txtcount.Text = "";
            txtcost.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from Поставки where ID_поставки = '"+IdPostavki+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно удаленны!");
            con.Close();
            displayData();
        }

        private void dgvBD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPostavki = Convert.ToInt32(dgvBD.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtidmobile.Text = dgvBD.Rows[e.RowIndex].Cells[1].Value.ToString();
            datepostavki.Text = dgvBD.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcount.Text = dgvBD.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtcost.Text = dgvBD.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void txtidmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidmobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtcount.Focus();
            }
        }

        private void txtcount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txtcost.Focus();
            }
        }
    }
}
