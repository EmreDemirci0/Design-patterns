using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace YazilimMimarisiVeTasarımı
{
    class Otel : IKonaklama
    {
        
       
        public string konaklamaAdi { get; set; }
        public string konaklamaYeri { get; set; }
        public int konaklamaFiyati { get; set; }
        public Otel(string konaklamaAdi,string konaklamaYeri,int konaklamaFiyati)
        {
            this.konaklamaAdi = konaklamaAdi;
            this.konaklamaYeri = konaklamaYeri;
            this.konaklamaFiyati = konaklamaFiyati;
        }
    }
}
