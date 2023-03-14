using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Nesneler.Araclar;
using Uygulama.Nesneler.Cagirma;
using Uygulama.VeriTabaniKatmani;

namespace Uygulama.IsKatmani
{
    public class IKListelemeIslemleri:IIKListeleme
    {
        VKListelemeIslemleri VK;
        public IKListelemeIslemleri()
        {
            VK = new VKListelemeIslemleri();
        }

        //Listeleme İşlemleri
        public List<UyelerListele> UyelerTablosu()
        {
            List<UyelerListele> uyelerListesi = new List<UyelerListele>();
            SqlDataReader Tablo = VK.UyelerTablosu();
            while (Tablo.Read())
            {
                UyelerListele uye = new UyelerListele();
                uye.ID = Convert.ToInt32(Tablo["ID"]);
                uye.Ad = Tablo["Ad"].ToString();
                uye.Soyad = Tablo["Soyad"].ToString();
                uye.TelNo = Tablo["TelNo"].ToString();
                uye.Email = Tablo["Email"].ToString();
                bool kontrol = Convert.ToBoolean(Tablo["Cinsiyet"]);
                uye.Cinsiyet = kontrol ? "Erkek" : "Kadın";
                uye.DogumTarihi = Convert.ToDateTime(Tablo["DogumTarihi"]);
                uye.Adres = Tablo["Adres"].ToString();
                uye.SporAdi = Tablo["SporAdi"].ToString();
                uye.AntrenorAdiSoyadi = Tablo["AntrenorAdiSoyadi"].ToString();
                uye.UyelikTuru = Tablo["UyelikTuru"].ToString();
                uyelerListesi.Add(uye);
            }

            TemelSinif.BaglantiAyarla();
            return uyelerListesi;
        }

        public List<AntrenorlerListele> AntrenorlerTablosu()
        {
            List<AntrenorlerListele> antrenorlerListesi = new List<AntrenorlerListele>();
            SqlDataReader Tablo = VK.AntrenorlerTablosu();
            while (Tablo.Read())
            {
                AntrenorlerListele antrenor = new AntrenorlerListele();
                antrenor.AntrenorID = Convert.ToInt32(Tablo["AntrenorID"]);
                antrenor.Ad = Tablo["Ad"].ToString();
                antrenor.Soyad = Tablo["Soyad"].ToString();
                antrenor.Email = Tablo["Email"].ToString();
                antrenor.TelNo = Tablo["TelNo"].ToString();
                antrenor.DogumTarihi = Convert.ToDateTime(Tablo["DogumTarihi"]);
                bool kontrol = Convert.ToBoolean(Tablo["Cinsiyet"]);
                antrenor.Cinsiyet = kontrol ? "Erkek" : "Kadın";          
                antrenor.Adres = Tablo["Adres"].ToString();
                antrenor.Spor = Tablo["SporAdi"].ToString();
                antrenor.Maas = Convert.ToDouble(Tablo["Maas"]);
                antrenorlerListesi.Add(antrenor);
            }
            TemelSinif.BaglantiAyarla();
            return antrenorlerListesi;
        }

        public List<SporlarListele> SporlarTablosu()
        {
            List<SporlarListele> sporlarListesi = new List<SporlarListele>();
            SqlDataReader Tablo = VK.SporlarTablosu();
            while (Tablo.Read())
            {
                SporlarListele spor = new SporlarListele();
                spor.SporID = Convert.ToInt32(Tablo["SporID"]);
                spor.SporAdi = Tablo["SporAdi"].ToString();
                spor.SporTuru = Tablo["SporTuru"].ToString();
                spor.AylikFiyat = Convert.ToDouble(Tablo["AylikFiyati"]);

                sporlarListesi.Add(spor);
            }
            TemelSinif.BaglantiAyarla();
            return sporlarListesi;
        }

        public List<UyelikTurleriListele> UyelikTurleriTablosu()
        {
            List<UyelikTurleriListele> uyelikTurleriListesi = new List<UyelikTurleriListele>();
            SqlDataReader Tablo = VK.UyelikTurleriTablosu();
            while (Tablo.Read())
            {
                UyelikTurleriListele uyelikTuru = new UyelikTurleriListele();
                uyelikTuru.UyelikID = Convert.ToInt32(Tablo["UyelikID"]);
                uyelikTuru.UyelikTuru = Tablo["UyelikTuru"].ToString();
                uyelikTuru.IndirimMiktari = Convert.ToInt16(Tablo["IndirimMiktari"]);

                uyelikTurleriListesi.Add(uyelikTuru);
            }
            TemelSinif.BaglantiAyarla();
            return uyelikTurleriListesi;
        }

    }
}
