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
    public partial class UC_SorularıGorSil : UserControl
    {
        Function fn = new Function();
        String query;

        public UC_SorularıGorSil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_SorularıGorSil_Load(object sender, EventArgs e)
        {
            comboUnite.Items.Clear();
            comboUnite.Items.Add("tüm sorular");
            query = "select distinct qUnite from sorular";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboUnite.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
        }

        private void comboUnite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboUnite.SelectedIndex != 0)
            {
                query = "select id, qNo, Soru, asikki, bsikki, csikki, dsikki, cevap from sorular where qUnite =‘”+comboUnite.text +”’";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select id, qNo, Soru, asikki, bsikki, csikki, dsikki, cevap from sorular";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }



        }
        int id, questionNo;



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                questionNo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch { }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Emin misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                {
                    query = "delete from sorular where id =" + id + " and qNo ='" + questionNo + "'";
                    fn.setData(query, "Soru silindi!");
                    UC_SorularıGorSil_Load(this, null);
                }
            }         

        }




    }
}

