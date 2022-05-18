using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımYapımı
{
    internal class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrno;
        private string eposta;
        private string sifre;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value.ToUpper(); }
        }
        public int Ogrno
        {
            get { return ogrno; }
            set { ogrno = value; }
        }
        public string Eposta
        {
            get { return eposta; }
            set { eposta = value; }
        }
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }








    }
}
