using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Depo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void getData()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I8EG3NR;Initial Catalog=ITDepoDb;Integrated Security=SSPI");
            string sql = string.Format("Select id,product_name,stock,info from Product");
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            connection.Close();
            // SqlDataReader reader = cmd.ExecuteReader();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            getData();
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I8EG3NR;Initial Catalog=ITDepoDb;Integrated Security=SSPI");
            string sql = string.Format(@"INSERT INTO Product (product_name, stock,info) VALUES (@product_name, @stock, @info)");
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            //foreach (var item in listBox1.Items)
            //{
            //    ints.Add(int.Parse(item.ToString()));
            //}
            cmd.Parameters.AddWithValue("@product_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@stock", textBox2.Text);
            cmd.Parameters.AddWithValue("@info", textBox3.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            getData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I8EG3NR;Initial Catalog=ITDepoDb;Integrated Security=SSPI");
            string sql = string.Format("UPDATE Product SET product_name=@product_name,stock=@stock,info=@info WHERE id = '" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'  ");
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            //foreach (var item in listBox1.Items)
            //{
            //    ints.Add(int.Parse(item.ToString()));
            //}
            cmd.Parameters.AddWithValue("@product_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@stock", textBox2.Text);
            cmd.Parameters.AddWithValue("@info", textBox3.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            getData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I8EG3NR;Initial Catalog=ITDepoDb;Integrated Security=SSPI");
            string sql = string.Format("DELETE FROM Product WHERE id = '" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "' ");
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            getData();
        }
    }
}
