using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Nesneler.Araclar;

namespace Uygulama.VeriTabaniKatmani
{
    public class VKListelemeIslemleri:IVKListeleme
    {
        SqlCommand komut;
        SqlDataReader okuma;

        //Listeleme İşlemleri
        public SqlDataReader AntrenorlerTablosu()
        {
            komut = new SqlCommand("prc_Antrenorler_Select", TemelSinif.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            TemelSinif.BaglantiAyarla();
            okuma = komut.ExecuteReader();
            return okuma;
        }

        public SqlDataReader SporlarTablosu()
        {
            komut = new SqlCommand("prc_Sporlar_Select", TemelSinif.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            TemelSinif.BaglantiAyarla();
            okuma = komut.ExecuteReader();
            return okuma;

        }

        public SqlDataReader UyelerTablosu()
        {
            komut = new SqlCommand("prc_Uyeler_Select", TemelSinif.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            TemelSinif.BaglantiAyarla();
            okuma = komut.ExecuteReader();
            return okuma;

        }

        public SqlDataReader UyelikTurleriTablosu()
        {
            komut = new SqlCommand("prc_UyelikTurleri_Select", TemelSinif.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            TemelSinif.BaglantiAyarla();
            okuma = komut.ExecuteReader();
            return okuma;
        }

    }
}
