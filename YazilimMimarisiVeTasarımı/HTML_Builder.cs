using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    public class HTML_Builder : Rapor_Builder
    {
        public HTML_Builder(Rapor raporBilgi) : base(raporBilgi)
        {

        }
       

        public override string Header()
        {

            string ad = Form1.ad.ToString();
            string soyad = Form1.soyad.ToString();
            string tc = Form1.tc.ToString();

            StringBuilder so = new StringBuilder();
            so.Append(string.Format($"<h1> Ad : {ad}</h1> <h1> Soyad : {soyad}</h1> <h1> TC Kimlik Numarası : {tc}</h1> "));
            return so.ToString();
        }

        public override string Section()
        {
            string adres = Form1.adres.ToString();
            string telno = Form1.telNo.ToString();
            string binilecekLokasyon = Form1.nereden.ToString();
            string ulasimTipi = Form1.ulasimTipi;
            StringBuilder so = new StringBuilder();
            Random rastgele = new Random();
            int fiyat = rastgele.Next(1500, 5000);
          // System.Windows.Forms.MessageBox.Show($"binis:{binis} inis:{inis}");
            so.Append(string.Format($"<h1> Adres : {adres}</h1> <h1> Telefon Numarası : {telno}</h1> <h1> Binilecek Lokasyon : {binilecekLokasyon}</h1> <h1> Fiyat : {fiyat}</h1> <h1> Ulasim Tipi : {ulasimTipi}</h1>  "));

            return so.ToString();
        }
        public override string Footer()
        {

            string binis = Form1.binisTarihi.ToString();
            string inis = Form1.inisTarihi.ToString();
            string konaklamaTipi = Form1.konaklamaTipi;
            StringBuilder so = new StringBuilder();
            so.Append(string.Format($"<h1>Konaklama Tipi: {konaklamaTipi }</h1><h1>Binis Tarihi: {binis}</h1><h1>Iniş Tarihi:{inis} </h1>"));
            return so.ToString();
        }

    }
}
