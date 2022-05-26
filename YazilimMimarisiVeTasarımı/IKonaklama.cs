using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
   public interface IKonaklama
    {
       string konaklamaAdi { get; set; }
        string konaklamaYeri { get; set; }
        int konaklamaFiyati { get; set; }

    }
}
