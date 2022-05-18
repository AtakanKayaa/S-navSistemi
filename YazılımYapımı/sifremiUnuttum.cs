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
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SİSTEME KAYITLI OLAN ŞİFRENİZ E-POSTA ADRESİNİZE GÖNDERİLMİŞTİR");
        }
    }
}
