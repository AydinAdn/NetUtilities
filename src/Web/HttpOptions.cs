using System;
using System.Net;
using Utilities.Web.Extras;

namespace Utilities.Web
{
    public enum HttpMethod
    {
        Get,
        Post
    }

    public enum HttpProtocol
    {
        Version10 = 10,
        Version11 = 11
    }

    public class HttpOptions
    {
        public HttpOptions()
        {
            ProtocolVersion = HttpProtocol.Version11;
            HttpMethod = HttpMethod.Get;
            HttpAcceptHeader = "*/*";
            UserAgent = UserAgents.GetRandomUserAgent();
            DecompressionMethod = DecompressionMethods.GZip;
            AllowAutoRedirect = true;
        }

        /// <summary>
        ///     Allows the WebRequest to be redirected by responding server.
        ///     <para>Default is True</para>
        /// </summary>
        public bool AllowAutoRedirect { get; set; }

        /// <summary>
        ///     Decompresses data that is compressed by some websites.
        ///     <para>Default is DecompressionMethods.GZip</para>
        /// </summary>
        public DecompressionMethods DecompressionMethod { get; set; }

        /// <summary>
        ///     Add headers to be sent to the server.
        /// </summary>
        public WebHeaderCollection HeaderCollection { get; set; }

        /// <summary>
        ///     The accept header.
        ///     <para>Default is "*/*"</para>
        /// </summary>
        public string HttpAcceptHeader { get; set; }

        /// <summary>
        ///     The HTTP method to use. GET / POST
        ///     <para>Default is Get</para>
        /// </summary>
        public HttpMethod HttpMethod { get; set; }

        /// <summary>
        ///     The data to post to server when using HTTP method POST
        /// </summary>
        public string PostData { get; set; }

        /// <summary>
        ///     HTTP Protocol version to use
        ///     <para>Default is Version 1.1</para>
        /// </summary>
        public HttpProtocol ProtocolVersion { get; set; }

        /// <summary>
        ///     Proxy settings
        /// </summary>
        public WebProxy Proxy { get; set; }

        /// <summary>
        ///     The referrer string.
        ///     <para>Default is null</para>
        /// </summary>
        public string Referer { get; set; }

        /// <summary>
        ///     The amount of time to wait for the server to respond
        /// </summary>
        public TimeSpan RequestTimeout { get; set; }

        /// <summary>
        ///     The URL of the website to visit
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        ///     The user agent you want to pose as
        ///     <para>Default is randomly selected</para>
        /// </summary>
        public string UserAgent { get; set; }

        internal Version ParseHttpVersion()
        {
            if (ProtocolVersion == HttpProtocol.Version10) return HttpVersion.Version10;
            
            return HttpVersion.Version11;
        }
    }
}