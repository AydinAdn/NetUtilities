using System.IO;
using System.Net;
using System.Text;
using Utilities.Web.Extras;

namespace Utilities.Web
{
    /// <summary>
    ///     Syntactic sugar for HttpWebRequest
    /// </summary>
    public static class Http
    {
        /// <summary>
        ///     Retrieves the content of the specified web page.
        /// </summary>
        /// <param name="url">Location of the web page</param>
        /// <returns>Content of the web page</returns>
        public static string Get(string url)
        {
            string content;

            var request                    = (HttpWebRequest)WebRequest.Create(url);
            request.Method                 = WebRequestMethods.Http.Get;
            request.Accept                 = "*/*";
            request.UserAgent              = UserAgents.GetRandomUserAgent();
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.Headers.Add("Accept-Language: en-US,en;q=0.5");
            
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    if (stream == null) return "Stream is empty!";

                    using (var streamReader = new StreamReader(stream))
                    {
                        content = streamReader.ReadToEnd();
                    }
                }
            }

            return content;
        }

        /// <summary>
        ///     Configures the web request with HttpOptions and
        /// <para>retrieves the web pages response.</para>    
        /// </summary>
        /// <param name="options">Web request options</param>
        /// <returns>Content of the web page</returns>
        public static string Request(HttpOptions options)
        {
            string content;

            var request                    = (HttpWebRequest)WebRequest.Create(options.Url);
            request.ProtocolVersion        = options.ParseHttpVersion();
            request.Headers                = options.HeaderCollection;
            request.Accept                 = options.HttpAcceptHeader;
            request.Method                 = options.HttpMethod.ToString();
            request.Proxy                  = options.Proxy;
            request.AutomaticDecompression = options.DecompressionMethod;
            request.Referer                = options.Referer;
            request.UserAgent              = options.UserAgent;
            request.AllowAutoRedirect      = options.AllowAutoRedirect;
            request.Timeout                = (int)options.RequestTimeout.TotalMilliseconds;

            if (options.HttpMethod == HttpMethod.Post)
            {
                byte[] postBytes      = Encoding.UTF8.GetBytes(options.PostData);
                request.ContentType   = "application/x-www-form-urlencoded; charset=UTF-8";
                request.ContentLength = postBytes.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(postBytes, 0, postBytes.Length);
                } 
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    if (stream == null) return "Stream is empty!";

                    using (var streamReader = new StreamReader(stream))
                    {
                        content = streamReader.ReadToEnd();
                    }
                }
            }

            return content;
        }

        /// <summary>
        ///     Posts data and retrieves the content of the specified web page.
        /// </summary>
        /// <param name="url">Location of the web page</param>
        /// <param name="data">Data to post to the web page</param>
        /// <returns>Content of the web page</returns>
        public static string Post(string url, string data)
        {
            string content;
            byte[] postBytes = Encoding.UTF8.GetBytes(data);

            var request                    = (HttpWebRequest)WebRequest.Create(url);
            request.Method                 = WebRequestMethods.Http.Post;
            request.Accept                 = "*/*";
            request.UserAgent              = UserAgents.GetRandomUserAgent();
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.ContentType            = "application/x-www-form-urlencoded; charset=UTF-8";
            request.ContentLength          = postBytes.Length;
            request.Headers.Add("Accept-Language: en-US,en;q=0.5");

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(postBytes, 0, postBytes.Length);
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    if (stream == null) return "Stream is empty!";
                    using (var streamReader = new StreamReader(stream))
                    {
                        content = streamReader.ReadToEnd();
                    }
                }
            }

            return content;
        }
    }
}