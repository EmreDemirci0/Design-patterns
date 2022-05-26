using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiVeTasarımı
{
   public class Seyehat
    {
        private SoyutFabrika rezervasyonFabrikasi;
        private IKonaklama konaklama;
        private IUlasim ulasim;

        public Seyehat(SoyutFabrika soyutFabrika)
        {
            this.rezervasyonFabrikasi = soyutFabrika;
            this.konaklama = this.rezervasyonFabrikasi.KonaklamaOlustur();
            this.ulasim = this.rezervasyonFabrikasi.UlasimOlustur();
        }


        public void SeyehatKaydet(DateTime gidisTarihi, DateTime donusTarihi, string nereden, string nereye, string ad, string soyad, string tc, string telNo, string adres)
{
            
            if (sqlBaglantisi.baglanti().State == ConnectionState.Closed)
                sqlBaglantisi.baglanti().Open();
            if (sqlBaglantisi.baglanti().State == ConnectionState.Open)
                sqlBaglantisi.baglanti().Close();
            string kayit = "insert into TblKisiBilgi(KisiAd,KisiSoyad,KisiTC,KisiTelNo,KisiAdres,GidisTarihi,DönüsTarihi,UlasimBilgi,KonaklamaBilgi,Nereden,Nereye,UlasimFiyat,KonaklamaFiyat, KonaklamaYeri)" +
                 "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)";
            SqlCommand sc = new SqlCommand(kayit, sqlBaglantisi.baglanti());

            sc.Parameters.AddWithValue("@p1", ad);
            sc.Parameters.AddWithValue("@p2", soyad);
            sc.Parameters.AddWithValue("@p3", tc);
            sc.Parameters.AddWithValue("@p4", telNo);
            sc.Parameters.AddWithValue("@p5", adres);
            sc.Parameters.Add("@p6", System.Data.SqlDbType.DateTime).Value =gidisTarihi;
            sc.Parameters.Add("@p7", System.Data.SqlDbType.DateTime).Value =donusTarihi;
            sc.Parameters.AddWithValue("@p8", ulasim.ulasimAraci);
            sc.Parameters.AddWithValue("@p9", konaklama.konaklamaAdi);
            sc.Parameters.AddWithValue("@p10", nereden);
            sc.Parameters.AddWithValue("@p11", nereye);
            sc.Parameters.AddWithValue("@p12", ulasim.ulasimFiyat);
            sc.Parameters.AddWithValue("@p13", konaklama.konaklamaFiyati);
            sc.Parameters.AddWithValue("@p14", konaklama.konaklamaYeri);



            sc.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi...");
            sqlBaglantisi.baglanti().Close();
        }
    }
}
