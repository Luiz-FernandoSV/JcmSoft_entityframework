using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.EFCore
{
    public class AppConfig
    {
        public static string GetConnectionString()
        {
            return "Data Source=DSV06;Initial Catalog=JcmSoftDatabaseTesteFluentApi;Integrated Security=True;TrustServerCertificate=True;";
        }
    }
}
