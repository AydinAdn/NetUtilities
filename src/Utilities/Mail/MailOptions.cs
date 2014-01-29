namespace Utilities.Mail
{
    public sealed class MailOptions
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string SMTPHost { get; set; }
        public int SMTPPort { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool UseSsl { get; set; }
        public bool UseHtml { get; set; }
    }
}