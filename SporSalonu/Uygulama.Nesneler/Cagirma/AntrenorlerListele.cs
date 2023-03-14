using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Nesneler.Cagirma
{
    public class AntrenorlerListele
    {

        public int AntrenorID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string TelNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Adres { get; set; }
        public string Spor { get; set; }
        public double Maas { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
