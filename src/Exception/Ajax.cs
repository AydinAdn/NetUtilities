using System.Web;

namespace Utilities.Exception
{
    public static class Ajax
    {
        public static void ThrowException(HttpContext context, string message)
        {
            context.Response.ContentType = "text/HTML";
            context.Response.Write("@ERROR:" + message);
        }

    }
}
