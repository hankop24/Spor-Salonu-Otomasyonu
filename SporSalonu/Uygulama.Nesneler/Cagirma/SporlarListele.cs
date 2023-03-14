using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Nesneler.Cagirma
{
    public class SporlarListele
    {
        public int SporID { get; set; }
        public string SporAdi { get; set; }
        public string SporTuru { get; set; }
        public double AylikFiyat { get; set; }

        public override string ToString()
        {
            return $"{SporAdi} - {SporTuru}";
        }
    }
}
