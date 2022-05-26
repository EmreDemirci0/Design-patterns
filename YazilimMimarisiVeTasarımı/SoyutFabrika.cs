using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    public abstract class SoyutFabrika
    {
        public abstract string ulasimAraci { get; set; }
        public abstract int ulasimFiyati { get; set; }
        public abstract string konaklamaAdi { get; set; }
        public abstract string konaklamaYeri { get; set; }
        public abstract int konaklamaFiyati { get; set; }
        public abstract IUlasim UlasimOlustur();
        public abstract IKonaklama KonaklamaOlustur();

    }
}
