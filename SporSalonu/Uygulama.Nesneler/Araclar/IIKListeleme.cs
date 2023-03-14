using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Nesneler.Cagirma;

namespace Uygulama.Nesneler.Araclar
{
    public interface IIKListeleme
    {
        List<UyelerListele> UyelerTablosu();
        List<AntrenorlerListele> AntrenorlerTablosu();
        List<SporlarListele> SporlarTablosu();
        List<UyelikTurleriListele> UyelikTurleriTablosu();
    }
}
