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

namespace YazılımYapımı.Öğretmen_UC
{
    

    public partial class UC_YeniSoruEkle : UserControl
    {
        Function fn = new Function();
        string query;
        DataSet ds;

        Int64 questionNo= 1;




        public UC_YeniSoruEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=SinavSistemi;Integrated Security=True");
        void VeriGetir()
        {
            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=SinavSistemi;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select *from sorular", baglanti);
            DataTable tablo = new DataTable();

            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void UC_YeniSoruEkle_Load(object sender, EventArgs e)
        {
            VeriGetir();
            query = "Select max(qUnite) from sorular";
            ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtUnite.Text = (id + 1).ToString();



            }
            else
            {
                txtUnite.Text = "1";
            }

            SoruLabel.Text = questionNo.ToString();

            labelNOSET.Visible = false;

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            String qUnite = txtUnite.Text;
            String qNo = questionNo.ToString();
            String Soru = txtSoru.Text;

            String asikki = txtA.Text;
            String bsikki = txtB.Text;
            String csikki = txtC.Text;
            String dsikki = txtD.Text;

            String cevap = txtCevap.Text;

          
            query = "insert into sorular(qUnite,qNo,Soru,aSikki,bSikki,cSikki,dSikki,cevap)values('" + qUnite + "','" + qNo + "','" + Soru + "','" + asikki + "','" + bsikki + "','" + csikki + "','" + dsikki + "','" + cevap + "')";
            
            fn.setData(query, "Soru Eklenmiştir."); questionNo++; SoruLabel.Text = questionNo.ToString();
           
            


        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            txtSoru.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD.Clear();
            txtCevap.Clear();
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tamamlandı", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtUnite.Text = (Int64.Parse(txtUnite.Text.ToString() + 1).ToString());
                SoruLabel.Text = "1";


            }
        }

        private void txtUnite_TextChanged(object sender, EventArgs e)
        {
            if (txtUnite.Text != "")
            {
    

                query = "select qNo from sorular where qUnite='" + txtUnite.Text + "'";
                ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    SoruLabel.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Int64.Parse(SoruLabel.Text.ToString());

                }
                else
                {
                    SoruLabel.Text = "1";
                    questionNo = Int64.Parse(SoruLabel.Text.ToString());
                    labelNOSET.Visible = true;

                }

            }


        }
        string imagepath;
        private void btnImg_Click(object sender, EventArgs e)
        {
            

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtResim_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);

            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();




            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sorular(resim) values(@resim)", baglanti);
            komut.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
