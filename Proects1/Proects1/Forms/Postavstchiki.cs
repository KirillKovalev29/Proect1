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
    public partial class Postavstchiki : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = KIRILL-KOVALEV; Initial Catalog = Автосалон_союз; Integrated Security = true");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        int Idpostavtschika;
        public Postavstchiki()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            con.Open();
            adapter = new SqlDataAdapter("Select * From Поставщики",con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvBD.DataSource = dt;
            con.Close();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Поставщики values('" + txtsurname.Text + "','" + txtname.Text + "','" + txtmiddlename.Text + "','" + txtidpostavki.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно добавлены!");
            con.Close();
            displayData();
            Cleaner();
        }

        public void Cleaner()
        {
            txtsurname.Text = "";
            txtname.Text = "";
            txtmiddlename.Text = "";
            txtidpostavki.Text = "";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Поставщики set Фамилия = '"+txtsurname.Text+"',Имя = '"+txtname.Text+"',Отчество = '"+txtmiddlename.Text+"',Id_поставки = '"+txtidpostavki.Text+"' where ID_поставщика = '"+Idpostavtschika+"'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно обновлены!");
                con.Close();
                displayData();
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from Поставщики where ID_потавщика = '"+Idpostavtschika+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно удалены!");
            con.Close();
            displayData();
        }

        private void dgvBD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Idpostavtschika = Convert.ToInt32(dgvBD.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtsurname.Text = dgvBD.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtname.Text = dgvBD.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmiddlename.Text = dgvBD.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtidpostavki.Text = dgvBD.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
