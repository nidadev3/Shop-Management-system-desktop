using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Common
{
    internal class Util
    {
        public static string GetDbConnection()
        {
            return "Server=localhost;Database=POS;trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        }
    }
}
