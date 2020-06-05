using AsyncWebContent.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWebContent.Classes
{
    public delegate void EventDelegate(object sender, EventArgs e);
    public class HttpHandler : IHttpHandler
    {
        public event EventDelegate WebContentReturned;

        protected virtual void OnWebContentReturned(HttpResponseArgs e)
        {
            Uri u = new Uri("");
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(u);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            System.IO.Stream st = res.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(st);
            e.httpBody = sr.ReadToEnd();
            e.responseCode = res.StatusCode == HttpStatusCode.OK ? 200 : 400;

            WebContentReturned(this, e);
        }


        public HttpResponseArgs GetContent(string url)
        {
            Uri u = new Uri(url);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(u);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            System.IO.Stream st = res.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(st);
            string body = sr.ReadToEnd();
            int code = res.StatusCode == HttpStatusCode.OK ? 200 : 400;

            return new HttpResponseArgs { httpBody = body, responseCode = code };
        }
    }
}
