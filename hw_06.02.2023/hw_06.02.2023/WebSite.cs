using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class WebSite
    {
        private string siteName;
        private string siteUrl;
        private string siteDescription;
        private string siteIp;

        public string SiteName { get { return siteName; }  set { siteName = value; } }
        public string SiteUrl { get { return siteUrl; } set { siteName = value; } }
        public string SiteDescription { get { return siteDescription; } set { siteName = value; } }
        public string SiteIp { get { return siteIp; } set { siteName = value; } }

        public override string ToString()
        {
            return $"Site Name : {SiteName}\nSite Url : {SiteUrl}\nSite Description : {SiteDescription}\nSite Ip : {SiteIp}\n";
        }
    }
}
