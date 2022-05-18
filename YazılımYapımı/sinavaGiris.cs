using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


     

namespace YazılımYapımı
{
    public partial class sinavaGiris : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        int saniye = 0, dakika = 0;

        public sinavaGiris()
        {
            InitializeComponent();
        }

        void SoruGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=SinavSistemi;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select *from sorular", baglanti);
            DataTable tablo = new DataTable();

            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void sinavaGiris_Load(object sender, EventArgs e)
        {
            SoruGetir();

        }

      



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            label8.Text = "1";
            richTextBox1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
           
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;


        }
        Int32 a = 1;
        int i = 0;
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(label8.Text);
            a = a + 1;
            label8.Text = a.ToString();

            richTextBox1.Text = dataGridView1.Rows[i + 1].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i + 1].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i + 1].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i + 1].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i + 1].Cells[7].Value.ToString();


            if (label8.Text=="10")
            {
                MessageBox.Show("sinav bitti");
                Form form = new Form();
                form.Show();
                this.Close();
            }
            i++;

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            richTextBox1.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }


            label9.Text = dakika.ToString() + ":" + saniye.ToString();
            saniye++;

            if (dakika == 10)
            {
                timer1.Stop();
                MessageBox.Show("SÜRENİZ DOLMUŞTUR");
                this.Close();

            }
            else
            {
                    
            }

        }
    }
}
