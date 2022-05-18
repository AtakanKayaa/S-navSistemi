namespace YazılımYapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kAYITOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitOl kayıtOl = new kayitOl();
            kayıtOl.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void gİRİŞYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciGiris ogrencigiris = new ogrenciGiris();
            ogrencigiris.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aDMİNGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminEkrani adminekrani = new adminEkrani();
            adminekrani.Show();

        }
    }
}