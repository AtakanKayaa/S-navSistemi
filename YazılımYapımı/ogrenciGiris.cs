using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Timers;

namespace YazılımYapımı
{
    public partial class ogrenciGiris : Form
    {
        

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public ogrenciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.Eposta = textBox1.Text;
            ogrenci.Sifre = textBox2.Text;


            con = new SqlConnection("Data Source =DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog = SinavSistemi;Integrated Security = True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select*from table_1 where eposta='" + ogrenci.Eposta + "'And sifre='" + ogrenci.Sifre + "'";

            dr = com.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("TEBRİKLER GİRİŞ BAŞARILI");
                SinavEkrani sinavEkrani = new SinavEkrani();
                sinavEkrani.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI GİRİS YAPTİNİZ.LÜTFEN TEKRAR DENEYİNİZ.");

            }
            con.Close();




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifremiUnuttum sifremiunuttum = new sifremiUnuttum();
            sifremiunuttum.Show();
            this.Hide();
        }

        private void ogrenciGiris_Load(object sender, EventArgs e)
        {
            

        }

        


    }
}
