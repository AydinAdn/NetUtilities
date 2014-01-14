using System.Web;

namespace Utilities.Exception
{
    public static class Ajax
    {
        /// <summary>
        ///     Use in conjunction with XMLHttpRequest in JavaScript (ASP.Net)
        /// </summary>
        /// <example>
        ///  function isError(message) {
        ///      return message.substring(0, 7) === "@ERROR:";
        ///  }
        /// 
        ///  $.ajax({
        ///     type: $frm.attr('method'),
        ///     url: $frm.attr('action'),
        ///     data: $frm.serialize(),
        ///     success: function(message) {
        ///         if (isError(message)) {
        ///             message = message.replace("@ERROR:", "");
        ///             alert(message);
        ///         } else {
        ///              // Success!
        ///         }
        ///     }
        ///  });
        ///  </example>
        public static void ThrowException(HttpContext context, string message)
        {
            context.Response.ContentType = "text/HTML";
            context.Response.Write("@ERROR:" + message);
        }

    }
}