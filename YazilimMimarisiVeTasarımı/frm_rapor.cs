using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiVeTasarımı
{
    public partial class frm_rapor : Form
    {
        public frm_rapor()
        {
            InitializeComponent();
        }

        private void btn_html_Click(object sender, EventArgs e)
        {
            Rapor bilgi = new Rapor();
            bilgi.detayliBilgi = "";
            bilgi.GenelBilgi = "";
            Rapor_Builder builder = new HTML_Builder(bilgi);
            RaporYonet raporyonetici = new RaporYonet(builder);
            string str = raporyonetici.RaporGetir();

            System.IO.File.WriteAllText(@"D:\Yazılım\nesneye yönelimli programlama\YazilimMimarisiVeTasarımı\YazilimMimarisiVeTasarımı\bin\Debug\HTMLRAPOR.html", str);
            frm_htmlGöster f = new frm_htmlGöster();
            f.ShowDialog();
        }

        private void btn_json_Click(object sender, EventArgs e)
        {
           

            
            Rapor bilgi = new Rapor();



            Rapor_Builder builder = new JSON_Builder(bilgi);
            RaporYonet raporyonetici = new RaporYonet(builder);

            string str = raporyonetici.RaporGetir();

            System.IO.File.WriteAllText(@"D:\Yazılım\nesneye yönelimli programlama\YazilimMimarisiVeTasarımı\YazilimMimarisiVeTasarımı\bin\Debug\JSONRAPOR.json", str);

            frm_jsongöster f = new frm_jsongöster();
            f.ShowDialog();

        }

        private void btn_xml_Click(object sender, EventArgs e)
        {
            Rapor bilgi = new Rapor();
            Rapor_Builder builder = new XML_Builder(bilgi);
            RaporYonet raporyonetici = new RaporYonet(builder);

            string str = raporyonetici.RaporGetir();

            System.IO.File.WriteAllText(@"D:\Yazılım\nesneye yönelimli programlama\YazilimMimarisiVeTasarımı\YazilimMimarisiVeTasarımı\bin\Debug\XMLRAPOR.xml", str);
            frm_xmlgöster f = new frm_xmlgöster();
            f.ShowDialog();
        }

        private void frm_rapor_Load(object sender, EventArgs e)
        {

        }
    }
}
