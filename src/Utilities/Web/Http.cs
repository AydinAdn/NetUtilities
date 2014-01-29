using System;
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

            var request                    = (HttpWebRequest) WebRequest.Create(url);
            request.Method                 = WebRequestMethods.Http.Get;
            request.Accept                 = "*/*";
            request.UserAgent              = UserAgents.GetRandomUserAgent();
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.Headers.Add("Accept-Language: en-US,en;q=0.5");

            using (var response = (HttpWebResponse) request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    if (stream == null) throw new Exception("Stream is empty!");

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
        ///     <para>retrieves the web pages response.</para>
        /// </summary>
        /// <param name="options">Web request options</param>
        /// <returns>Content of the web page</returns>
        public static string Request(HttpOptions options)
        {
            string content;

            var request                    = (HttpWebRequest) WebRequest.Create(options.Url);
            request.ProtocolVersion        = options.ParseHttpVersion();
            request.Headers                = options.HeaderCollection;
            request.Accept                 = options.HttpAcceptHeader;
            request.Method                 = options.HttpMethod.ToString();
            request.Proxy                  = options.Proxy;
            request.AutomaticDecompression = options.DecompressionMethod;
            request.Referer                = options.Referer;
            request.UserAgent              = options.UserAgent;
            request.AllowAutoRedirect      = options.AllowAutoRedirect;
            request.CookieContainer        = options.Cookies;
            request.Timeout                = (int) options.RequestTimeout.TotalMilliseconds;

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

            using (var response = (HttpWebResponse) request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    if (stream == null) throw new Exception("Stream is empty!");

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

            var request                    = (HttpWebRequest) WebRequest.Create(url);
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

            using (var response = (HttpWebResponse) request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    if (stream == null) throw new Exception("Stream is empty!");

                    using (var streamReader = new StreamReader(stream))
                    {
                        content = streamReader.ReadToEnd();
                    }
                }
            }

            return content;
        }

        /// <summary>
        ///     Downloads files from the specified URL
        /// </summary>
        /// <param name="url">URL of the file</param>
        /// <param name="path">Path to save the file to</param>
        public static void Download(string url, string path)
        {
            var request       = (HttpWebRequest) WebRequest.Create(url);
            request.Method    = WebRequestMethods.Http.Get;
            request.Accept    = "*/*";
            request.UserAgent = UserAgents.GetRandomUserAgent();

            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (Stream fileStream = File.OpenWrite(path))
                    {
                        if (stream == null) throw new Exception("Stream is empty!");

                        var buffer    = new byte[4096];
                        int bytesRead = stream.Read(buffer, 0, 4096);
                        while (bytesRead > 0)
                        {
                            fileStream.Write       (buffer, 0, bytesRead);
                            bytesRead = stream.Read(buffer, 0, 4096);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Downloads files with HttpOptions
        /// </summary>
        /// <param name="options">Web request options</param>
        /// <param name="path">Path to save the file to</param>
        public static void Download(HttpOptions options, string path)
        {
            var request             = (HttpWebRequest) WebRequest.Create(options.Url);
            request.ProtocolVersion = options.ParseHttpVersion();
            request.Headers         = options.HeaderCollection;
            request.Accept          = options.HttpAcceptHeader;
            request.Proxy           = options.Proxy;
            request.Referer         = options.Referer;
            request.UserAgent       = options.UserAgent;
            request.CookieContainer = options.Cookies;

            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (Stream fileStream = File.OpenWrite(path))
                    {
                        if (stream == null) throw new Exception("Stream is empty!");

                        var buffer    = new byte[4096];
                        int bytesRead = stream.Read(buffer, 0, 4096);
                        while (bytesRead > 0)
                        {
                            fileStream.Write       (buffer, 0, bytesRead);
                            bytesRead = stream.Read(buffer, 0, 4096);
                        }
                    }
                }
            }
        }
    }
}