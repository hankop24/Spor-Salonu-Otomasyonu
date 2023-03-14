using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Nesneler.Cagirma;
using Uygulama.Nesneler.Gonderme;
using Uygulama.VeriTabaniKatmani;

namespace Uygulama.IsKatmani
{
    public class IKGondermeIslemleri
    {
        VKGondermeIslemleri VK;
        public IKGondermeIslemleri()
        {
            VK = new VKGondermeIslemleri();
        }

        #region Ekleme İşlemleri
        public int UyelerEkle(string ad, string soyad, string email, string telNo, DateTime dogumTarihi, int kontrol, string adres, AntrenorlerListele antrenorler, SporlarListele sporlar, UyelikTurleriListele uyelikTurleri)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telNo) || string.IsNullOrEmpty(adres) || antrenorler == null || sporlar == null || uyelikTurleri == null)
            {
                return -100; //Eksik Parametre Hatası
            }
            else
            {
                UyelerGonder yeniUye = new UyelerGonder();
                yeniUye.Ad = ad;
                yeniUye.Soyad = soyad;
                yeniUye.Email = email;
                yeniUye.TelNo = telNo;
                yeniUye.DogumTarihi = dogumTarihi;
                yeniUye.Cinsiyet = kontrol == 0 ? true : false;
                yeniUye.Adres = adres;
                yeniUye.SporID = sporlar.SporID;
                yeniUye.AntrenorID = antrenorler.AntrenorID;
                yeniUye.UyelikID = uyelikTurleri.UyelikID;
                return VK.UyelerEkle(yeniUye);
            }

        }

        public int AntrenorlerEkle(string ad, string soyad, string email, string telNo, DateTime dogumTarihi, int kontrol, string adres, int sporID, decimal maas)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telNo) || string.IsNullOrEmpty(adres))
            {
                return -100; //Eksik Parametre Hatası

            }
            else
            {
                AntrenorlerGonder yeniAntrenor = new AntrenorlerGonder();
                yeniAntrenor.Ad = ad;
                yeniAntrenor.Soyad = soyad;
                yeniAntrenor.Email = email;
                yeniAntrenor.TelNo = telNo;
                yeniAntrenor.DogumTarihi = dogumTarihi;
                yeniAntrenor.Cinsiyet = kontrol == 0 ? true : false;
                yeniAntrenor.Adres = adres;
                yeniAntrenor.SporID = sporID;
                yeniAntrenor.Maas = maas;
                return VK.AntrenorlerEkle(yeniAntrenor);
            }
        }

        public int SporlarEkle(string sporAdi, string sporTuru, decimal aylikFiyati)
        {
            if (string.IsNullOrEmpty(sporAdi) || string.IsNullOrEmpty(sporTuru))
            {
                return -100;

            }
            else
            {
                SporlarGonder yeniSpor = new SporlarGonder();
                yeniSpor.SporAdi = sporAdi;
                yeniSpor.SporTuru = sporTuru;
                yeniSpor.AylikFiyati = aylikFiyati;

                return VK.SporlarEkle(yeniSpor);
            }
        }

        public int UyelikTurleriEkle(string uyelikTuru, int indirimMiktari)
        {
            if (string.IsNullOrEmpty(uyelikTuru))
            {
                return -100;
            }
            else
            {
                UyelikTurleriGonder yeniUyelikTuru = new UyelikTurleriGonder();
                yeniUyelikTuru.UyelikTuru = uyelikTuru;
                yeniUyelikTuru.IndirimMiktari = indirimMiktari;
                return VK.UyelikTurleriEkle(yeniUyelikTuru);

            }
        }
        #endregion

        #region Güncelleme İşlemleri
        public int UyelerGuncelle(int ID, string ad, string soyad, string email, string telNo, DateTime dogumTarihi, int kontrol, string adres, AntrenorlerListele antrenorler, SporlarListele sporlar, UyelikTurleriListele uyelikTurleri)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telNo) || string.IsNullOrEmpty(adres) || antrenorler == null || sporlar == null || uyelikTurleri == null)
            {
                return -100;
            }
            else
            {
                UyelerGonder uyeGuncelle = new UyelerGonder();
                uyeGuncelle.ID = ID;
                uyeGuncelle.Ad = ad;
                uyeGuncelle.Soyad = soyad;
                uyeGuncelle.Email = email;
                uyeGuncelle.TelNo = telNo;
                uyeGuncelle.DogumTarihi = dogumTarihi;
                uyeGuncelle.Cinsiyet = kontrol == 0 ? true : false;
                uyeGuncelle.Adres = adres;
                uyeGuncelle.AntrenorID = antrenorler.AntrenorID;
                uyeGuncelle.SporID = sporlar.SporID;
                uyeGuncelle.UyelikID = uyelikTurleri.UyelikID;
                return VK.UyelerGuncelle(uyeGuncelle);
            }
        }

        public int AntrenorlerGuncelle(int ID, string ad, string soyad, string email, string telNo, DateTime dogumTarihi, int kontrol, string adres, SporlarListele sporlar, decimal maas)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telNo) || string.IsNullOrEmpty(adres) || sporlar == null)
            {
                return -100;
            }
            else
            {
                AntrenorlerGonder antrenorGuncelle = new AntrenorlerGonder();
                antrenorGuncelle.ID = ID;
                antrenorGuncelle.Ad = ad;
                antrenorGuncelle.Soyad = soyad;
                antrenorGuncelle.Email = email;
                antrenorGuncelle.TelNo = telNo;
                antrenorGuncelle.DogumTarihi = dogumTarihi;
                antrenorGuncelle.Cinsiyet = kontrol == 0 ? true : false;
                antrenorGuncelle.Adres = adres;
                antrenorGuncelle.SporID = sporlar.SporID;
                antrenorGuncelle.Maas = maas;
                return VK.AntrenorlerGuncelle(antrenorGuncelle);
            }


        }


        public int SporlarGuncelle(int ID, string sporAdi, string sporTuru, decimal AylikFiyati)
        {
            if (string.IsNullOrEmpty(sporTuru) || string.IsNullOrEmpty(sporAdi))
            {
                return -100;
            }
            else
            {
                SporlarGonder sporGuncelle = new SporlarGonder();
                sporGuncelle.SporID = ID;
                sporGuncelle.SporAdi = sporAdi;
                sporGuncelle.SporTuru = sporTuru;
                sporGuncelle.AylikFiyati = AylikFiyati;
                return VK.SporlarGuncelle(sporGuncelle);
            }
        }


        public int UyelikTurleriGuncelle(int ID,string uyelikTuru,int IndirimMiktari)
        {
            if (string.IsNullOrEmpty(uyelikTuru))
            {
                return -100;
            }
            else
            {
                UyelikTurleriGonder uyelikTurleriGuncelle = new UyelikTurleriGonder();
                uyelikTurleriGuncelle.UyelikTurID = ID;
                uyelikTurleriGuncelle.UyelikTuru = uyelikTuru;
                uyelikTurleriGuncelle.IndirimMiktari= IndirimMiktari;
                return VK.UyelikTurleriGuncelle(uyelikTurleriGuncelle);
            }
        }
        #endregion

        #region Silme İşlemleri
        public int UyelerSil(object ID)
        {
            if (ID==null)
            {
                return -100;
            }
            else
            {
                return VK.UyelerSil(Convert.ToInt32(ID));
            }
        }

        public int AntrenorlerSil(object ID)
        {
            if (ID == null)
            {
                return -100;
            }
            else
            {
                return VK.AntrenorlerSil(Convert.ToInt32(ID));
            }
        }

        public int SporlarSil(object ID)
        {
            if (ID == null)
            {
                return -100;
            }
            else
            {
                return VK.SporlarSil(Convert.ToInt32(ID));
            }
        }

        public int UyelikTurleriSil(object ID)
        {
            if (ID == null)
            {
                return -100;
            }
            else
            {
                return VK.UyelikTurleriSil(Convert.ToInt32(ID));
            }
        }
        #endregion

    }
}
