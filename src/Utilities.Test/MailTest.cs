using System;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;
using Utilities.Crypt;
using Utilities.Mail;
using Utilities.Web;

namespace Utilities.Test
{
    [TestFixture]
    public class MailTest
    {
        [TestFixtureSetUp]
        public void Init()
        {
            MailOptions = new MailOptions();

            /* Edit settings:
             * **********************************************************/
            MailOptions.Username = "Username@gmail.com";
            MailOptions.Password = "Password";
            MailOptions.From = "Username@gmail.com";
            MailOptions.SMTPHost = "smtp.gmail.com";
            MailOptions.SMTPPort = 587;
            MailOptions.UseSsl = true;

            /* Do not edit the settings below: 
             ************************************************************/
            MailOptions.To = "netutilities@dispostable.com";
            MailOptions.Body = "Net Utilities";
        }

        public MailOptions MailOptions;

        [TestCase]
        public void Can_SendMail()
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(MailOptions.SMTPHost), "SMTP Host is not set");
            Debug.Assert(!string.IsNullOrWhiteSpace(MailOptions.Username), "Username is not set");
            Debug.Assert(!string.IsNullOrWhiteSpace(MailOptions.Password), "Password is not set");
            Debug.Assert(!string.IsNullOrWhiteSpace(MailOptions.To), "MailOptions.To email address is not set");
            Debug.Assert(!string.IsNullOrWhiteSpace(MailOptions.From), "MailOptions.From email address is not set");
            Debug.Assert(!string.IsNullOrWhiteSpace(MailOptions.Body), "Email body is not set");
            Debug.Assert(MailOptions.SMTPPort != 0, "SMTP Port is not set");

            // Generate a random subject header to cross check with the emails received.
            MailOptions.Subject = RngStringProvider.GenerateString(12);

            Debug.Assert(!string.IsNullOrWhiteSpace(MailOptions.Subject), "Email subject is not set");

            SMTP.Send(MailOptions);
            Console.WriteLine("Email sent \n\n" +
                              "Checking if email is received for a duration of 30 seconds...\n");

            int seconds = 0;
            while (seconds < 30)
            {
                Thread.Sleep(1000);

                string html = Http.Get("http://www.dispostable.com/inbox/netutilities/?last=0");
                if (html.Contains(MailOptions.Subject)) break;

                Console.WriteLine("Seconds: {0}", seconds++);
                Debug.Assert(seconds < 30, "Mail has not been received by the client, check your mail options.");
            }

            Console.WriteLine("\nReceived mail!");
        }
    }
}