using System.Web;

namespace Utilities.Web
{
    public static class Util
    {
        /// <summary>
        ///     Retrieves the visitors IP (ASP.Net)
        /// </summary>
        /// <param name="request">Visitors HttpRequest</param>
        /// <returns>Visitors IP</returns>
        public static string GetUserIp(HttpRequest request)
        {
            string ipList = request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList)) return ipList.Split(',')[0];

            return request.ServerVariables["REMOTE_ADDR"];
        }
    }
}