using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımı.Öğretmen_UC
{
    public partial class UC_SoruGüncelle : UserControl
    {
        Function fn = new Function();
        string query;

        public UC_SoruGüncelle()
        {
            InitializeComponent();
        }

        private void UC_SoruGüncelle_Load(object sender, EventArgs e)
        {
            comboUnite.Items.Clear();
            query = "Select distinct qUnite from sorular";
            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboUnite.Items.Add(ds.Tables[0].Rows[i][0].ToString());



            }
        }

        private void comboUnite_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSoruNo.Items.Clear();
            query = "select qNo from sorular where qUnite='" + comboUnite.Text + "'";
            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSoruNo.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }

        }

        private void comboSoruNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select Soru,asikki,bsikki,csikki,dsikki,cevap from sorular where qUnite='" + comboUnite.Text + "' and qNo='" + comboSoruNo.Text + "'";
            DataSet ds = fn.GetData(query);
            txtSoru.Text = ds.Tables[0].Rows[0][0].ToString();
            txtA.Text = ds.Tables[0].Rows[0][1].ToString();
            txtB.Text = ds.Tables[0].Rows[0][2].ToString();
            txtC.Text = ds.Tables[0].Rows[0][3].ToString();
            txtD.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCevap.Text = ds.Tables[0].Rows[0][5].ToString();

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        { clearAll(); }

        public void clearAll()
        {
            txtSoru.Clear();
            txtA.Clear(); txtB.Clear();
            txtC.Clear();
            txtD.Clear();
            txtCevap.Clear();
            comboUnite.SelectedIndex = -1;
            comboSoruNo.SelectedIndex = -1;


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (comboSoruNo.SelectedIndex != -1)
            {
                String qUnite = comboUnite.Text;
                String qNo = comboSoruNo.Text;
                String Soru = txtSoru.Text;
                String asikki = txtA.Text;
                String bsikki = txtA.Text;
                String csikki = txtA.Text;
                String dsikki = txtA.Text;
                String cevap = txtCevap.Text;

                query = "update sorular set Soru='" + Soru + "',asikki ='" +asikki + "',bsikki ='" + bsikki + "',csikki ='" + csikki + "',dsikki ='" + dsikki + "',cevap ='" + cevap + "' where qUnite ='" + qUnite + "' and qNo='" + qNo + "'";
                fn.setData(query, "Soru numarası  " + qNo + "\n Question Unitesi: " + qUnite + "\ngüncellendi");


            }
            else
            {
                MessageBox.Show("Önce Soruyu Seç.","Message!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }
    }
}