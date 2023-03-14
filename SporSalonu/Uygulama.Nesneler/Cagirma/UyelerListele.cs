using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Nesneler.Cagirma
{
    public class UyelerListele
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }
        public string SporAdi { get; set; }
        public string AntrenorAdiSoyadi { get; set; }
        public string UyelikTuru { get; set; }
    }
}
