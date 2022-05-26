using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    class Otobus : IUlasim
    {
        public string ulasimAraci { get; set ; }
        public int ulasimFiyat { get; set ; }
        public Otobus(string ulasimAraci,int ulasimFiyat)
        {
            this.ulasimAraci = ulasimAraci;
            this.ulasimFiyat = ulasimFiyat;
        }
    }
}
