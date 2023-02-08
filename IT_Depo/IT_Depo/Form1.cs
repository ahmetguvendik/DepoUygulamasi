using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IT_Depo
{

    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q4VJJBK;Initial Catalog=ITDepoDb;Integrated Security=SSPI");
        public Form1()
        {
            InitializeComponent();
        }

        void getData()
        {
            try
            {
                string sql = string.Format("Select Product.id,Product.product_name,Product.seri_no,Product.info,Category.category_name from Product INNER JOIN Category on Product.kategori_id = Category.id");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].Visible = false;
                connection.Close();
                // SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void getListBoxData()
        {

            try
            {

                string sql = string.Format("Select id,product_name,seri_no from Product where kategori_id = '" + listBox1.SelectedValue + "' ");
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                //  SqlDataReader reader = cmd.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                comboBox1.SelectedValue = 1;
                listBox1.DataSource = dataSet.Tables[0];
                listBox1.ValueMember = "id";
                listBox1.DisplayMember = "product_name";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        void getAllData()
        {

            try
            {
                string sql = string.Format("Select Person.id,Product.product_name,Person.start_time,Person.person_info,Person.seri_no,Person.info from Person INNER JOIN Product ON Person.product_id = Product.id");
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

        void getCategory()
        {
            try
            {
                //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q4VJJBK;Initial Catalog=ITDepoDb;Integrated Security=SSPI");
                //string sql = string.Format("Select * from Category");
                //connection.Open();
                //SqlCommand command = new SqlCommand(sql, connection);
                //SqlDataReader reader = command.ExecuteReader();
                //while(reader.Read())
                //{
                //    comboBox1.Items.Add(reader["category_name"]);
                //}

                string sql = string.Format("Select id,category_name from Category");
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                //  SqlDataReader reader = cmd.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                comboBox1.DataSource = dataSet.Tables[0];
                comboBox1.ValueMember = "id";
                comboBox1.DisplayMember = "category_name";
                connection.Close() ;    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
            // getListBoxData();
            getAllData();
            getCategory();
            this.dateTimePicker1.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ints = new List<int>();
                string sql = string.Format(@"INSERT INTO Person (product_id, start_time, person_info,seri_no,info) VALUES (@product_id, @start_time, @person_info,@seri_no,@info)");
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                //foreach (var item in listBox1.Items)
                //{
                //    ints.Add(int.Parse(item.ToString()));
                //}
                cmd.Parameters.AddWithValue("@product_id", listBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@start_time", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@person_info", textBox2.Text);
                cmd.Parameters.AddWithValue("@seri_no", textBox1.Text);
                cmd.Parameters.AddWithValue("@info", textBox3.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                getData();
                getListBoxData();
                getAllData();
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
                string sql = string.Format("UPDATE Person SET product_id=@product_id,start_time=@start_time,person_info=@person_info,seri_no=@seri_no,info=@info WHERE id = '" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'  ");
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                //foreach (var item in listBox1.Items)
                //{
                //    ints.Add(int.Parse(item.ToString()));
                //}
                cmd.Parameters.AddWithValue("@product_id", listBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@start_time", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@person_info", textBox2.Text);
                cmd.Parameters.AddWithValue("@seri_no", textBox1.Text);
                cmd.Parameters.AddWithValue("@info", textBox3.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                getData();
                getListBoxData();
                getAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("DELETE FROM Person WHERE id = '" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "' ");
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                getData();
                getListBoxData();
                getAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        Font title = new Font("Verdana", 12, FontStyle.Bold);
        SolidBrush brush = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            StringFormat format = new StringFormat();
            Image ydaLogo = Image.FromFile("C:\\Users\\ahmet\\OneDrive\\Masaüstü\\DepoUygulamasi-main\\IT_Depo\\IT_Depo\\wwwroot\\yda logo.jpg");
            format.Alignment = StringAlignment.Center;
            e.Graphics.DrawImage(ydaLogo, 100, 100, 200, 100);
            e.Graphics.DrawString("TESLÝM TUTANAÐI", title, brush, 300, 300);
            e.Graphics.DrawString(listBox1.Text + " Modelli ve Seri Numarasý " + textBox1.Text + " Olan cihaz " + dataGridView1.CurrentRow.Cells[2].Value.ToString() + Environment.NewLine + "Tarihinde " + textBox2.Text + " tarafýndan teslim alýnmýþtýr.", title, brush, 75, 350);
            e.Graphics.DrawString("Teslim Alan", title, brush, 100, 500);
            e.Graphics.DrawString("Teslim Eden", title, brush, 600, 500);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }



        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("Select id,product_name,verildimi from Product where kategori_id = '" + comboBox1.SelectedValue + "' AND verildimi=0");
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                //  SqlDataReader reader = cmd.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                //SqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    if (reader["verildimi"].Equals(true))
                //    {

                //    }
                //}
                adapter.Fill(dataSet);
                listBox1.DataSource = dataSet.Tables[0];


                listBox1.ValueMember = "id";
                listBox1.DisplayMember = "product_name";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("Select seri_no from Product where id = '" + listBox1.SelectedValue + "' ");
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    textBox1.Text = sqlDataReader["seri_no"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}