using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    class Ucak_Cadir :SoyutFabrika
    {
        public override string ulasimAraci { get; set; }
        public override int ulasimFiyati { get; set; }
        public override string konaklamaAdi { get; set; }
        public override string konaklamaYeri { get; set; }
        public override int konaklamaFiyati { get; set; }
        public Ucak_Cadir(string konaklamaAdi, string konaklamaYeri, int konaklamaFiyati, string ulasimAraci, int ulasimFiyati)
        {
            this.ulasimAraci = ulasimAraci;
            this.ulasimFiyati = ulasimFiyati;
            this.konaklamaAdi = konaklamaAdi;
            this.konaklamaYeri = konaklamaYeri;
            this.konaklamaFiyati = konaklamaFiyati;
        }
        public override IKonaklama KonaklamaOlustur()
        {

            return new Cadir(konaklamaAdi, konaklamaYeri, konaklamaFiyati);
        }

        public override IUlasim UlasimOlustur()
        {
            return new Ucak(ulasimAraci, ulasimFiyati);
        }


    }
}
