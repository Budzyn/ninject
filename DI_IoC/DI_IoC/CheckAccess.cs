using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace DI_IoC
{
    class CheckAccess:ICheck
    {
        public string Ping(string url)
        {
#pragma warning disable
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(url);
            httpReq.AllowAutoRedirect = false;
            HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();
            if (httpRes.StatusCode == HttpStatusCode.NotFound)
            {
                return "Not";
            }
            else
            {
                return "Ok";
            }
            httpRes.Close();
#pragma warning restore
        }

        internal object PingUrl(string p)
        {
            throw new NotImplementedException();
        }
    }
}
