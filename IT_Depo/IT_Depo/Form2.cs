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
        SqlConnection connection = new SqlConnection("");
        public Form2()
        {
            InitializeComponent();
        }
        void getData()
        {
            try
            {

                string sql = string.Format("Select Product.id,Product.product_name,Product.seri_no,Product.info,Category.category_name,Product.verildimi from Product INNER JOIN Category on Product.kategori_id = Category.id");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                connection.Close();
                // SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void getCategory()
        {

            try
            {
                string sql = string.Format("Select id,category_name from Category");
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                comboBox1.DataSource = dataSet.Tables[0];
                comboBox1.ValueMember = "id";
                comboBox1.DisplayMember = "category_name";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            getData();
            getCategory();
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"INSERT INTO Product (product_name, seri_no,info,kategori_id,verildimi) VALUES (@product_name, @seri_no, @info,@kategori_id,@verildimi)");
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                //foreach (var item in listBox1.Items)
                //{
                //    ints.Add(int.Parse(item.ToString()));
                //}
                cmd.Parameters.AddWithValue("@product_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@seri_no", textBox2.Text);
                cmd.Parameters.AddWithValue("@info", textBox3.Text);
                cmd.Parameters.AddWithValue("@kategori_id", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@verildimi", false);
                cmd.ExecuteNonQuery();
                connection.Close();
                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("UPDATE Product SET product_name=@product_name,seri_no=@seri_no,info=@info,kategori_id=@kategori_id WHERE id = '" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'  ");
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                //foreach (var item in listBox1.Items)
                //{
                //    ints.Add(int.Parse(item.ToString()));
                //}
                cmd.Parameters.AddWithValue("@product_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@seri_no", textBox2.Text);
                cmd.Parameters.AddWithValue("@info", textBox3.Text);
                cmd.Parameters.AddWithValue("@kategori_id", comboBox1.SelectedValue);
                cmd.ExecuteNonQuery();
                connection.Close();
                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("DELETE FROM Product WHERE id = '" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "' ");
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
