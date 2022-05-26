using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiVeTasarımı
{
    class sqlBaglantisi
    {
        public static SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-D3S9ESL2;Initial Catalog=YazılımMimarisi;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
