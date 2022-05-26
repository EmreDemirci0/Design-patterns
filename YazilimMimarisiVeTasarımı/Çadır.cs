using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    class Cadir : IKonaklama
    {
        public string konaklamaAdi { get; set; }
        public string konaklamaYeri { get; set; }
        public int konaklamaFiyati { get; set; }
        public Cadir(string konaklamaAdi, string konaklamaYeri, int konaklamaFiyati)
        {
            this.konaklamaAdi = konaklamaAdi;
            this.konaklamaYeri = konaklamaYeri;
            this.konaklamaFiyati = konaklamaFiyati;
        }
    }
}
