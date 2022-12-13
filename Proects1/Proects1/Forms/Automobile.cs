using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Proects1
{
    public partial class Automobile : Form
    { 
        SqlConnection con = new SqlConnection(@"Data Source = KIRILL-KOVALEV; Initial Catalog = Автосалон_союз; Integrated Security = true");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        int Idmobile;
        public Automobile()
        {
            InitializeComponent();
            displayData();
        }
       
         public void displayData()
        {
            con.Open();
            adapter = new SqlDataAdapter("Select * From Автомобили",con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvBD.DataSource = dt;

            con.Close();

        }

        private void Automobile_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            con.Open();
            cmd = new SqlCommand("insert into Автомобили values('"+txtgosnomer.Text+"','"+txtmarka.Text+"','"+txtmodel.Text+"','"+txtprobeg.Text+"','"+txtmostchnost.Text+"','"+dateIsgotovlenya.Text+"','"+txtCityIsgotovitel.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно добавлены!");
            con.Close();
            displayData();
            Cleaner();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            con.Open();
            cmd = new SqlCommand("update Автомобили set Гос_номер='" + txtgosnomer.Text + "',Марка ='" + txtmarka.Text + "',Модель='" + txtmodel.Text + "',Пробег='" + txtprobeg.Text + "',Мощность='" + txtmostchnost.Text + "',Год_выпуска='" + dateIsgotovlenya.Text + "', Страна_изготовитель='" + txtCityIsgotovitel.Text + "' where ID_автомобиля='" + Idmobile + "'", con);          
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd= new SqlCommand("delete from Автомобили where Гос_номер = '" + Idmobile + "'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно удалены!");
            con.Close();
            displayData();
        }

        public void Cleaner()
        {
            txtgosnomer.Text = "";
            txtmarka.Text = "";
            txtmodel.Text = "";
            txtprobeg.Text = "";
            txtmostchnost.Text = "";
            txtCityIsgotovitel.Text = "";

        }
        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtgosnomer.Clear();
            txtmarka.Clear();
            txtmodel.Clear();
            txtprobeg.Clear();
            txtmostchnost.Clear();
            txtCityIsgotovitel.Clear();

        }

        private void dgvBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvBD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Idmobile = Convert.ToInt32(dgvBD.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtgosnomer.Text = dgvBD.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtmarka.Text = dgvBD.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmodel.Text = dgvBD.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtprobeg.Text = dgvBD.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtmostchnost.Text = dgvBD.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateIsgotovlenya.Text = dgvBD.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCityIsgotovitel.Text = dgvBD.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void txtgosnomer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txtmarka.Focus();
            }
        }
        private void txtmarka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtmodel.Focus();
            }

        }
        private void txtmodel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtprobeg.Focus();
            }
        }
        private void txtprobeg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtmostchnost.Focus();
            }
        }
        private void txtmostchnost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtCityIsgotovitel.Focus();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dgvBD.RowCount; i++)
            {
                dgvBD.Rows[i].Selected = false;
            //    dgvBD.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                for (int j = 0; j<dgvBD.ColumnCount; j++)
                    if (dgvBD.Rows[i].Cells[j].Value != null)
                        if (dgvBD.Rows[i].Cells[j].Value.ToString().Contains(txtSearch.Text))
                        {
                            dgvBD.Rows[i].Selected = true;
                           
                            // dgvBD.CurrentCell = dgvBD.Item[1, 5];
                            break;
                        }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
