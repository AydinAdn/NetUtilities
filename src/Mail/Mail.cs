using System.Net;

namespace Utilities.Mail
{
    public sealed class Mail
    {
        public string SMTPHost { get; set; }
        public int SMTPPort { get; set; }
        public NetworkCredential Credentials { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
