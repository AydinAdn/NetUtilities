using System.Diagnostics;
using System.IO;
using NUnit.Framework;
using Utilities.Web;

namespace Utilities.Test
{
    [TestFixture]
    public class WebTest
    {
        [TestCase]
        public void Can_Get()
        {
            string html = Http.Get("https://github.com/AydinAdn/NetUtilities");
            Debug.Assert(html.Contains("NetUtilities"), "Failed to find content");
        }

        [TestCase]
        public void Can_Download()
        {
            Http.Download("https://github.com/AydinAdn/NetUtilities", "downloadTest.html");
            string html = File.ReadAllText("downloadTest.html");
            Debug.Assert(html.Contains("NetUtilities"), "Failed to find content");
        }

        [TestCase]
        public void Can_Post()
        {
            string html = Http.Post("http://playsharp.net/PostTest.ashx", "q=NetUtilities");
            Debug.Assert(html.Trim() == "NetUtilities", "Returned response is incorrect");
        }
    }
}