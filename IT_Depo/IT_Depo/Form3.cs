using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
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
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=10.100.110.202; Initial Catalog=ITDepoDb ;User ID=aguvendik ;Password=Ahmet.123");
        public Form3()
        {
            InitializeComponent();
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

        void getProductCategory()
        {

            try
            {
                string sql = string.Format("Select Product.id,Product.product_name,Product.seri_no,Product.info,Product.verildimi,Person.person_info from Product LEFT JOIN Person on Product.id = Person.product_id  where kategori_id = '" + comboBox1.SelectedValue + "'");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void getProductWithSeriNo()
        {
            try
            {
                string sql = string.Format("Select Product.id,Product.product_name,Product.seri_no,Product.info,Product.verildimi,Person.person_info from Product LEFT JOIN Person on Product.id = Person.product_id  where Product.seri_no = '" + textBox1.Text + "'");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            getCategory();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           getProductWithSeriNo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getProductCategory();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
