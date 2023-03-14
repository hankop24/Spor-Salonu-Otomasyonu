using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Nesneler.Cagirma
{
    public class UyelikTurleriListele
    {

        public int UyelikID { get; set; }
        public string UyelikTuru { get; set; }
        public short IndirimMiktari { get; set; }

        public override string ToString()
        {
            return $"{UyelikTuru} - %{IndirimMiktari}";
        }
    }
}
