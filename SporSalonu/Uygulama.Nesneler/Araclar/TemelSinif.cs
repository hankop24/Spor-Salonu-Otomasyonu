using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Nesneler.Araclar
{
    public class TemelSinif
    {
        private static SqlConnection Baglanti;

        public static SqlConnection baglanti
        {
            get
            {
                if (Baglanti ==null)
                    Baglanti = new SqlConnection("Server=DESKTOP-D2L5B6N\\SQLEXPRESS;Database=HilalSengilProject;Integrated Security=true;");
                return Baglanti;
            }

        }


        public static void BaglantiAyarla()
        {
            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
            else
            {
                baglanti.Close();
            }
        }

    }
}
