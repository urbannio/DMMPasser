using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net;
namespace DMMPasser
{
    class CookieHandler
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);

        public void PassDMM()
        {
            Cookie temp1 = new Cookie("ckcy", "1");
            InternetSetCookie("http://www.dmm.com/netgame/", null, temp1.ToString() + "; expires = Sun, 01-Jan-2019 00:00:00 GMT");
        }
    }

   
}
