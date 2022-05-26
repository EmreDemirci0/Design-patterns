using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    class XML_Builder : Rapor_Builder
    {
        public XML_Builder(Rapor raporBilgi) : base(raporBilgi)
        { }
        public override string Header()
        {
            string ad = Form1.ad.ToString();
            string soyad = Form1.soyad.ToString();
            string tcNo = Form1.tc.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<RAPOR>\n<KIMLIK>\n<Ad-Soyad>" + ad + " " + soyad + "</Ad-Soyad>\n<TcNo>" + tcNo + "</TcNo>\n</KIMLIK>\n<ULAŞIM>\n<Tipi>"));
         //   sb.Append(string.Format("<Footer> {0} </Footer> <Footer> {1} </Footer> ", ad, soyad));
            return sb.ToString();
        }

        public override string Section()
        {
          
            string adres = Form1.adres.ToString();
            string telno = Form1.telNo.ToString();
            string binilecekLokasyon = Form1.nereden.ToString();
            string ulasimTipi = Form1.ulasimTipi;
            StringBuilder so = new StringBuilder();
            so.Append(string.Format(ulasimTipi + "</Tipi>\n<OtelLokasyon>" + adres + "</OtelLokasyon>\n<BinilecekLokasyon>" + binilecekLokasyon + "</BinilecekLokasyon>\n<Ücret>50 TL</Ücret>\n</ULAŞIM>\n"));
            return so.ToString();
        }

        public override string Footer()
        {
            string binis = Form1.binisTarihi.ToString();
            string inis = Form1.inisTarihi.ToString();
            string konaklamaTipi=Form1.konaklamaTipi;
            StringBuilder so = new StringBuilder();
            Random random = new Random();
            int fiyat = random.Next(1500, 5000);

            so.Append(string.Format("<KONAKLAMA>\n<Tipi>" + konaklamaTipi + "</Tipi>\n<Check-In-Out>" + binis+" - "+inis + "</Check-In-Out>\n<Ücret>150 TL</Ücret>\n</KONAKLAMA>\n" + "</RAPOR>", binis, inis, fiyat));
            return so.ToString();
        }
    }
}
