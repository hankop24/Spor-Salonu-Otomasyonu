using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Nesneler.Araclar;
using Uygulama.Nesneler.Cagirma;
using Uygulama.Nesneler.Gonderme;

namespace Uygulama.VeriTabaniKatmani
{
    public class VKGondermeIslemleri
    {
        int donusDegeri = 0;
        SqlCommand komut;

        #region Ekleme İşlemleri
        public int UyelerEkle(UyelerGonder yeniUye)
        {
            try
            {
                komut = new SqlCommand("prc_Uyeler_Insert", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", yeniUye.Ad);
                komut.Parameters.AddWithValue("@Soyad", yeniUye.Soyad);
                komut.Parameters.AddWithValue("@TelNo", yeniUye.TelNo);
                komut.Parameters.AddWithValue("@Email", yeniUye.Email);
                komut.Parameters.AddWithValue("@Cinsiyet", yeniUye.Cinsiyet);
                komut.Parameters.AddWithValue("@DogumTarihi", yeniUye.DogumTarihi);
                komut.Parameters.AddWithValue("@Adres", yeniUye.Adres);
                komut.Parameters.AddWithValue("@SporID", yeniUye.SporID);
                komut.Parameters.AddWithValue("@AntrenorID", yeniUye.AntrenorID);
                komut.Parameters.AddWithValue("@UyelikID", yeniUye.UyelikID);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt",Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt",ex.Message);

                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }

        public int AntrenorlerEkle(AntrenorlerGonder yeniAntrenor)
        {
            try
            {
                komut = new SqlCommand("prc_Antrenorler_Insert", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Ad", yeniAntrenor.Ad);
                komut.Parameters.AddWithValue("@Soyad", yeniAntrenor.Soyad);
                komut.Parameters.AddWithValue("@TelNo", yeniAntrenor.TelNo);
                komut.Parameters.AddWithValue("@Email", yeniAntrenor.Email);
                komut.Parameters.AddWithValue("@Cinsiyet", yeniAntrenor.Cinsiyet);
                komut.Parameters.AddWithValue("@DogumTarihi", yeniAntrenor.DogumTarihi);
                komut.Parameters.AddWithValue("@Adres", yeniAntrenor.Adres);
                komut.Parameters.AddWithValue("@SporID", yeniAntrenor.SporID);
                komut.Parameters.AddWithValue("@Maas", yeniAntrenor.Maas);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);
                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }

        public int SporlarEkle(SporlarGonder yeniSpor)
        {
            try
            {
                komut = new SqlCommand("prc_Sporlar_Insert", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@SporAdi", yeniSpor.SporAdi);
                komut.Parameters.AddWithValue("@SporTuru", yeniSpor.SporTuru);
                komut.Parameters.AddWithValue("@Aylikfiyati", yeniSpor.AylikFiyati);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);
                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }

        public int UyelikTurleriEkle(UyelikTurleriGonder yeniUyelikTuru)
        {
            try
            {
                komut = new SqlCommand("prc_UyelikTurleri_Insert", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UyelikTuru", yeniUyelikTuru.UyelikTuru);
                komut.Parameters.AddWithValue("@IndirimMiktari", yeniUyelikTuru.IndirimMiktari);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);
                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }
        #endregion


        #region Güncelleme İşlemleri
        public int UyelerGuncelle(UyelerGonder uyeGuncelle)
        {
            try
            {
                komut = new SqlCommand("prc_Uyeler_Update", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ID", uyeGuncelle.ID);
                komut.Parameters.AddWithValue("@Ad", uyeGuncelle.Ad);
                komut.Parameters.AddWithValue("@Soyad", uyeGuncelle.Soyad);
                komut.Parameters.AddWithValue("@TelNo", uyeGuncelle.TelNo);
                komut.Parameters.AddWithValue("@Email", uyeGuncelle.Email);
                komut.Parameters.AddWithValue("@Cinsiyet", uyeGuncelle.Cinsiyet);
                komut.Parameters.AddWithValue("@DogumTarihi", uyeGuncelle.DogumTarihi);
                komut.Parameters.AddWithValue("@Adres", uyeGuncelle.Adres);
                komut.Parameters.AddWithValue("@SporID", uyeGuncelle.SporID);
                komut.Parameters.AddWithValue("@AntrenorID", uyeGuncelle.AntrenorID);
                komut.Parameters.AddWithValue("UyelikID", uyeGuncelle.UyelikID);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);
                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }

        public int AntrenorlerGuncelle(AntrenorlerGonder antrenorGuncelle)
        {
            try
            {
                komut = new SqlCommand("prc_Antrenorler_Update", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@AntrenorID", antrenorGuncelle.ID);
                komut.Parameters.AddWithValue("@Ad", antrenorGuncelle.Ad);
                komut.Parameters.AddWithValue("@Soyad", antrenorGuncelle.Soyad);
                komut.Parameters.AddWithValue("@Email", antrenorGuncelle.Email);
                komut.Parameters.AddWithValue("@TelNo", antrenorGuncelle.TelNo);
                komut.Parameters.AddWithValue("@DogumTarihi", antrenorGuncelle.DogumTarihi);
                komut.Parameters.AddWithValue("@Cinsiyet", antrenorGuncelle.Cinsiyet);
                komut.Parameters.AddWithValue("@Adres", antrenorGuncelle.Adres);
                komut.Parameters.AddWithValue("@SporID", antrenorGuncelle.SporID);
                komut.Parameters.AddWithValue("@Maas", antrenorGuncelle.Maas);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);
                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }

        public int SporlarGuncelle(SporlarGonder sporGuncelle)
        {
            try
            {
                komut = new SqlCommand("prc_Sporlar_Update", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@SporID", sporGuncelle.SporID);
                komut.Parameters.AddWithValue("@SporAdi", sporGuncelle.SporAdi);
                komut.Parameters.AddWithValue("@SporTuru", sporGuncelle.SporTuru);
                komut.Parameters.AddWithValue("@AylikFiyati", sporGuncelle.AylikFiyati);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);

                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;

        }
        public int UyelikTurleriGuncelle(UyelikTurleriGonder uyelikTurGuncelle)
        {
            try
            {
                komut = new SqlCommand("prc_UyelikTuru_Update", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UyelikID", uyelikTurGuncelle.UyelikTurID);
                komut.Parameters.AddWithValue("@UyelikTuru", uyelikTurGuncelle.UyelikTuru);
                komut.Parameters.AddWithValue("@IndirimMiktari", uyelikTurGuncelle.IndirimMiktari);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }
        #endregion

        #region Silme İşlemleri
        public int UyelerSil(int id)
        {
            try
            {
                komut = new SqlCommand("prc_Uyeler_Delete", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ID", id);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);

                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }

        public int AntrenorlerSil(int id)
        {
            try
            {
                komut = new SqlCommand("prc_Antrenorler_Delete", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@AntrenorID", id);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);
                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }

        public int SporlarSil(int id)
        {
            try
            {
                komut = new SqlCommand("prc_Sporlar_Delete", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@SporID", id);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);
                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }

        public int UyelikTurleriSil(int id)
        {
            try
            {
                komut = new SqlCommand("prc_UyelikTurleri_Delete", TemelSinif.baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UyelikID", id);
                TemelSinif.BaglantiAyarla();
                donusDegeri = komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString());
                File.AppendAllText("log.txt", ex.Message);

                //
            }
            finally
            {
                TemelSinif.BaglantiAyarla();
            }
            return donusDegeri;
        }
        #endregion
    }
}
