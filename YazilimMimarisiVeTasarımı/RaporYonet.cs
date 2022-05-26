using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    class RaporYonet
    {
        private Rapor_Builder Builder;

        public RaporYonet(Rapor_Builder builder)
        {
            Builder = builder;

        }

        public string RaporGetir()
        {
            string product = Builder.Header();
            product += Builder.Section();
            product += Builder.Footer();
            return product;
        }
    }
}
