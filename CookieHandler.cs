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

        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool InternetGetCookie(string lpszUrl, string lpszCookieName,StringBuilder lpszCookieData, ref int lpdwSize);

        private readonly string defaultDayTime = "Sun, 01-Jan-2019 00:00:00 GMT";
        private string domain = "http://www.dmm.com/netgame/";
        private static string cookieName = "ckcy";

        private Cookie faCookie = new Cookie(cookieName, "1");

        public void setCookie()
        {
            InternetSetCookie(domain, null, faCookie.ToString() + "; expires = "+defaultDayTime);
        }
        public void setCookie(string dayTime)
        {  
            InternetSetCookie(domain, null, faCookie.ToString() + "; expires = " + dayTime);
        }

        public string getCookie()
        {
            int size = 0;
            InternetGetCookie(domain, cookieName, null, ref size);
            if (size <= 0)
                return "no cookie";
            StringBuilder lpszCookieData = new StringBuilder(size);
            InternetGetCookie(domain, cookieName, lpszCookieData, ref size);

            return lpszCookieData.ToString();
        }
        public string getDefaultDayTime()
        {
            return defaultDayTime;
        }
        
    }

   
}
