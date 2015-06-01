using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class AppVariables
    {
        public static string KrakenID = string.Empty;
        public static bool IsAuthenticated()
        {
            return (KrakenID != string.Empty);
        }
    }
}
