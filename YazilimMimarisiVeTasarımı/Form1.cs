using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiVeTasarımı
{
    public partial class Form1 : Form
    {
        private SoyutFabrika _fabrika;
        public static string ad = "";
        public static string soyad = "";
        public static string telNo = "";
        public static string adres = "";
        public static string tc = "";
        public static string nereden = "";
        public static string nereye = "";
        public static DateTime binisTarihi ;
        public static DateTime inisTarihi ;
        public static string ulasimTipi = "";
        public static string konaklamaTipi = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad = txt_ad.Text;
            soyad = txt_soyad.Text;
            telNo = txt_telNo.Text;
            adres = txt_adres.Text;
            tc = txt_tc.Text;
            nereden = cmb_nereden.Text;
            nereye = cmb_nereye.Text;
            binisTarihi = Dtp_GirisTarihiYönetici.Value;
            inisTarihi = Dtp_CikisTarihiYönetici.Value;
            ulasimTipi = cmb_ulasim.Text;
            konaklamaTipi = cmb_konaklama.Text;

            if (cmb_ulasim.Text == "Uçak" && cmb_konaklama.Text == "Otel")
            {
                _fabrika = new Ucak_Otel("Otel", "Konaklama Yeri", 1000, "Uçak", 1000);
            }

            else if (cmb_ulasim.Text == "Uçak" && cmb_konaklama.Text == "Çadır")
            {
                _fabrika = new Ucak_Cadir("Çadır", "Konaklama Yeri", 100, "Uçak", 1000);
            }
            else if (cmb_ulasim.Text == "Otobüs" && cmb_konaklama.Text == "Otel")
            {
                _fabrika = new Otobus_Otel("Otel", "Konaklama Yeri", 1000, "Otobüs", 100);
            }
            else if (cmb_ulasim.Text == "Otobüs" && cmb_konaklama.Text == "Çadır")
            {
                _fabrika = new Otobus_Cadir("Cadir", "Konaklama Yeri", 100, "Otobüs", 100);
            }

            Seyehat seyehat = new Seyehat(_fabrika);
            seyehat.SeyehatKaydet(Dtp_GirisTarihiYönetici.Value, Dtp_CikisTarihiYönetici.Value, cmb_nereden.Text, cmb_nereye.Text, txt_ad.Text, txt_soyad.Text,txt_tc.Text, txt_telNo.Text, txt_adres.Text);
            frm_rapor f = new frm_rapor();
            f.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtrezyapmaAdi_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn_rapor_Click(object sender, EventArgs e)
        {

        }
    }
}
