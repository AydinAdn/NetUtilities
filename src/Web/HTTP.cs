using System.IO;
using System.Net;
using System.Text;

namespace Utilities.Web
{
    public static class Http
    {

        public static string Get(string url)
        {
            try
            {
                var content = "";

                var request = (HttpWebRequest)WebRequest.Create(url);

                request.ProtocolVersion = HttpVersion.Version11;
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "*/*";
                request.Headers.Add("Accept-Language: en-US,en;q=0.5");
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:24.0) Gecko/20100101 Firefox/24.0";
                request.AutomaticDecompression = DecompressionMethods.GZip;

                var response = (HttpWebResponse)request.GetResponse();
                using (var stream = response.GetResponseStream())
                {
                    if (stream != null)
                    {
                        using (var streamReader = new StreamReader(stream))
                        {
                            content = streamReader.ReadToEnd();
                        }
                    }
                }
                response.Close();
                return content;
            }
            catch { return null; } 
        }

        public static string Post(string url, string data)
        {
            try
            {
                var content = "";
                var postBytes = Encoding.UTF8.GetBytes(data);

                var request = (HttpWebRequest)WebRequest.Create(url);

                request.ProtocolVersion = HttpVersion.Version11;
                request.Method = WebRequestMethods.Http.Post;
                request.Accept = "*/*";
                request.Headers.Add("Accept-Language: en-US,en;q=0.5");
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:24.0) Gecko/20100101 Firefox/24.0";
                request.AutomaticDecompression = DecompressionMethods.GZip;
                request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                request.ContentLength = postBytes.Length;
                request.CookieContainer = new CookieContainer();
                request.KeepAlive = false;

                var requestStream = request.GetRequestStream();
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                var response = (HttpWebResponse)request.GetResponse();
                using (var stream = response.GetResponseStream())
                {
                    if (stream != null)
                    {
                        using (var streamReader = new StreamReader(stream))
                        {
                            content = streamReader.ReadToEnd();
                        }
                    }
                }
                response.Close();
                return content;
            }
            catch { return null; }

        }
    }
}
