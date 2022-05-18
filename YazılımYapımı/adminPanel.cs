using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımı
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            uC_YeniSoruEkle1.Visible = false;
            uC_SoruGüncelle1.Visible = false;
            uC_SorularıGorSil1.Visible = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_YeniSoruEkle1.Visible = true;
            uC_YeniSoruEkle1.BringToFront();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnSoruGüncelle_Click(object sender, EventArgs e)
        {
            uC_SoruGüncelle1.Visible = true;
            uC_SoruGüncelle1.BringToFront();

        }

        private void btnSoruGorSil_Click(object sender, EventArgs e)
        {
            uC_SorularıGorSil1.Visible = true;
            uC_SorularıGorSil1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
