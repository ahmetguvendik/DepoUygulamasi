namespace IT_Depo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            button5 = new Button();
            comboBox1 = new ComboBox();
            button6 = new Button();
            button7 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            button8 = new Button();
            label8 = new Label();
            label9 = new Label();
            button9 = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(992, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy ";
            dateTimePicker1.Location = new Point(820, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.Value = new DateTime(2023, 1, 28, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(820, 168);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 4;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(992, 168);
            button2.Name = "button2";
            button2.Size = new Size(173, 23);
            button2.TabIndex = 5;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1171, 168);
            button3.Name = "button3";
            button3.Size = new Size(136, 23);
            button3.TabIndex = 6;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-9, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1508, 426);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(820, 56);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 11;
            label2.Text = "Veriliş Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(992, 56);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 12;
            label3.Text = "Verilecek Kişi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 360);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Veriler";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(342, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(419, 334);
            listBox1.TabIndex = 15;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1173, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1313, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1171, 56);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 19;
            label6.Text = "Cihaz Seri Numarası";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1313, 56);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 20;
            label7.Text = "Not";
            // 
            // button4
            // 
            button4.Location = new Point(1313, 168);
            button4.Name = "button4";
            button4.Size = new Size(166, 23);
            button4.TabIndex = 21;
            button4.Text = "Yazdır";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(820, 208);
            button5.Name = "button5";
            button5.Size = new Size(659, 23);
            button5.TabIndex = 22;
            button5.Text = "Cihaz Ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 23);
            comboBox1.TabIndex = 23;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // button6
            // 
            button6.Location = new Point(820, 248);
            button6.Name = "button6";
            button6.Size = new Size(659, 23);
            button6.TabIndex = 24;
            button6.Text = "Cihaz Detay";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(958, 337);
            button7.Name = "button7";
            button7.Size = new Size(8, 8);
            button7.TabIndex = 25;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(820, 127);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 23);
            textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(992, 127);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(173, 23);
            textBox5.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(821, 108);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 28;
            label1.Text = "Ip Adresi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(992, 108);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 29;
            label5.Text = "Mac Adresi";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(9, 322);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(220, 23);
            textBox6.TabIndex = 30;
            // 
            // button8
            // 
            button8.Location = new Point(235, 322);
            button8.Name = "button8";
            button8.Size = new Size(101, 23);
            button8.TabIndex = 31;
            button8.Text = "Ara";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 135);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 32;
            label8.Text = "Kategori Seç";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 304);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 33;
            label9.Text = "Seri Numarası";
            // 
            // button9
            // 
            button9.Location = new Point(235, 351);
            button9.Name = "button9";
            button9.Size = new Size(101, 23);
            button9.TabIndex = 34;
            button9.Text = "Verileri Getir\r\n";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1173, 135);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 35;
            label10.Text = "CihazID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 816);
            Controls.Add(label10);
            Controls.Add(button9);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button8);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private Label label6;
        private Label label7;
        private Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        public Button button5;
        public TextBox textBox2;
        public TextBox textBox1;
        public TextBox textBox3;
        private ComboBox comboBox1;
        private Button button6;
        private Button button7;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label5;
        private TextBox textBox6;
        private Button button8;
        private Label label8;
        private Label label9;
        private Button button9;
        private Label label10;
    }
}