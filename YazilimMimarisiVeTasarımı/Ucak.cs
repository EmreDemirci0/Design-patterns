using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiVeTasarımı
{
    class Ucak : IUlasim
    {
        public string ulasimAraci { get; set; }
        public int ulasimFiyat { get; set; }
        public Ucak(string ulasimAraci, int ulasimFiyat)
        {
            this.ulasimAraci = ulasimAraci;
            this.ulasimFiyat = ulasimFiyat;
        }


    }
}
