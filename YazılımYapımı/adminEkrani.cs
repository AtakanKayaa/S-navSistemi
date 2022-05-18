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
    public partial class adminEkrani : Form
    {
        public adminEkrani()
        {
            InitializeComponent();
        }

        private void adminEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler Giriş Başarılı");

            adminPanel adminpanel = new adminPanel();

            adminpanel.Show();
            this.Hide();
        }
    }
}
