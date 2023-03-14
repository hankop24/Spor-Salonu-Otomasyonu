using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Nesneler.Araclar
{
    public interface IVKListeleme
    {
        SqlDataReader UyelerTablosu();
        SqlDataReader AntrenorlerTablosu();
        SqlDataReader SporlarTablosu();
        SqlDataReader UyelikTurleriTablosu();
    }
}
