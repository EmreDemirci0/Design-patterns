using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    public abstract class Rapor_Builder
    {
        protected Rapor Bilgi;

        public Rapor_Builder(Rapor raporBilgi)
        {
            string cikti = Header();
            cikti += Section();
            cikti += Footer();
        }
        public abstract string Header();
        public abstract string Section();
        public abstract string Footer();
    }
}
