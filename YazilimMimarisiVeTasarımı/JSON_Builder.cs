using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    class JSON_Builder : Rapor_Builder
    {
        public JSON_Builder(Rapor raporBilgi) : base(raporBilgi)
        { }
        public override string Footer()
        {   
            string ad = Form1.ad.ToString();
            string soyad = Form1.soyad.ToString();
            string tcNo = Form1.tc.ToString();

            StringBuilder so = new StringBuilder();
            so.Append("{'Bilgi':{'Ad': '" + ad+ "', 'Soyad': '" + soyad+ "','Tc': '"+tcNo+"'},");
            return so.ToString();
        }

        public override string Header()
        {
            string adres = Form1.adres.ToString();
            string telno = Form1.telNo.ToString();
            string nereden = Form1.nereden.ToString();
            string nereye = Form1.nereye.ToString();

            string ulasimTipi = Form1.ulasimTipi;
            StringBuilder so = new StringBuilder();
            so.Append("{'Ulaşım': {'tipi': '" + ulasimTipi + "', 'adres': '" + adres + "', 'telefon No': '" + telno+ "', 'nereden': '" + nereden + "', 'nereye': '" + nereye + "'}        },");
            return so.ToString();
        }

        public override string Section()
        {
            string binis = Form1.binisTarihi.ToString();
            string inis = Form1.inisTarihi.ToString();
            string konaklamaTipi = Form1.konaklamaTipi;
            StringBuilder so= new StringBuilder();
            Random random = new Random();
            int fiyat = random.Next(1500, 5000);
           so.Append("{'Konaklama': {'tipi': '" + konaklamaTipi + "', 'gidisTarihi': '" + binis + "', 'donusTarihi': '" + inis+ "','ücret': '"+fiyat +"'}}");   
            return so.ToString();
        }
    }
}
