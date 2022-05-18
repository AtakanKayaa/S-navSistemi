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
using System.Data.Sql;

namespace YazılımYapımı
{
    public partial class kayitOl : Form
    {
        public kayitOl()
        {
            InitializeComponent();
        }
        

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=SinavSistemi;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.Isim = textBox1.Text;
            ogrenci.Soyisim = textBox2.Text;
            ogrenci.Ogrno = Convert.ToInt32(textBox3.Text);
            ogrenci.Eposta = textBox4.Text;
            ogrenci.Sifre = textBox5.Text;


            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_1 (ad,soyad,ogrno,eposta,sifre) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", ogrenci.Isim);
            komut.Parameters.AddWithValue("@p2", ogrenci.Soyisim);
            komut.Parameters.AddWithValue("@p3", ogrenci.Ogrno);
            komut.Parameters.AddWithValue("@p4", ogrenci.Eposta);
            komut.Parameters.AddWithValue("@p5", ogrenci.Sifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Kaydı Başarıyla Tamamlandı!");

            ogrenciGiris ogrencigiris = new ogrenciGiris();
            ogrencigiris.Show();
            this.Hide();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}