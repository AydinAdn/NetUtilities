using System;
using System.Collections.Concurrent;

namespace Utilities.Web.Extras
{
    public static class UserAgents
    {
        public static ConcurrentDictionary<int, string> UseragentsDictionary = new ConcurrentDictionary<int, string>();

        static UserAgents()
        {
            UseragentsDictionary.TryAdd(0, "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110613 Firefox/6.0a2");
            UseragentsDictionary.TryAdd(1, "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110612 Firefox/6.0a2");
            UseragentsDictionary.TryAdd(2,
                "Mozilla/5.0 (X11; Linux i686 on x86_64; rv:5.0a2) Gecko/20110524 Firefox/5.0a2");
            UseragentsDictionary.TryAdd(3,
                "Mozilla/5.0 (Windows NT 6.1; U; ru; rv:5.0.1.6) Gecko/20110501 Firefox/5.0.1 Firefox/5.0.1");
            UseragentsDictionary.TryAdd(4, "mozilla/3.0 (Windows NT 6.1; rv:2.0.1) Gecko/20100101 Firefox/5.0.1");
            UseragentsDictionary.TryAdd(5, "Mozilla/5.0 (X11; U; Linux i586; de; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(6,
                "Mozilla/5.0 (X11; U; Linux amd64; rv:5.0) Gecko/20100101 Firefox/5.0 (Debian)");
            UseragentsDictionary.TryAdd(7, "Mozilla/5.0 (X11; U; Linux amd64; en-US; rv:5.0) Gecko/20110619 Firefox/5.0");
            UseragentsDictionary.TryAdd(8,
                "Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 FirePHP/0.5");
            UseragentsDictionary.TryAdd(9,
                "Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 Firefox/5.0");
            UseragentsDictionary.TryAdd(10, "Mozilla/5.0 (X11; Linux x86_64) Gecko Firefox/5.0");
            UseragentsDictionary.TryAdd(11, "Mozilla/5.0 (X11; FreeBSD amd64; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(12, "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(13,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20110619 Firefox/5.0");
            UseragentsDictionary.TryAdd(14,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(15, "Mozilla/5.0 (Windows NT 6.1.1; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(16, "Mozilla/5.0 (Windows NT 5.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(17, "Mozilla/5.0 (Windows NT 5.1; U; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(18, "Mozilla/5.0 (Windows NT 5.1; rv:2.0.1) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(19, "Mozilla/5.0 (Windows NT 5.0; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(20, "Mozilla/5.0 (Windows NT 5.0; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(21, "Mozilla/5.0 (U; Windows NT 5.1; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(22, "Mozilla/5.0 (Macintosh; PPC MacOS X; rv:5.0) Gecko/20110615 Firefox/5.0");
            UseragentsDictionary.TryAdd(23,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.7; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(24,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.5; rv:5.0) Gecko/20100101 Firefox/5.0");
            UseragentsDictionary.TryAdd(25,
                "Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre");
            UseragentsDictionary.TryAdd(26,
                "Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20100101 Firefox/4.2a1pre");
            UseragentsDictionary.TryAdd(27,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre");
            UseragentsDictionary.TryAdd(28,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110323 Firefox/4.2a1pre");
            UseragentsDictionary.TryAdd(29,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110208 Firefox/4.2a1pre");
            UseragentsDictionary.TryAdd(30,
                "Mozilla/5.0 (X11; Linux x86_64; rv:2.0b9pre) Gecko/20110111 Firefox/4.0b9pre");
            UseragentsDictionary.TryAdd(31,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b9pre) Gecko/20101228 Firefox/4.0b9pre");
            UseragentsDictionary.TryAdd(32, "Mozilla/5.0 (Windows NT 5.1; rv:2.0b9pre) Gecko/20110105 Firefox/4.0b9pre");
            UseragentsDictionary.TryAdd(33,
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre");
            UseragentsDictionary.TryAdd(34,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101213 Firefox/4.0b8pre");
            UseragentsDictionary.TryAdd(35,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101128 Firefox/4.0b8pre");
            UseragentsDictionary.TryAdd(36,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre");
            UseragentsDictionary.TryAdd(37, "Mozilla/5.0 (Windows NT 5.1; rv:2.0b8pre) Gecko/20101127 Firefox/4.0b8pre");
            UseragentsDictionary.TryAdd(38,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b8) Gecko/20100101 Firefox/4.0b8");
            UseragentsDictionary.TryAdd(39, "Mozilla/5.0 (Windows NT 6.1; rv:2.0b7pre) Gecko/20100921 Firefox/4.0b7pre");
            UseragentsDictionary.TryAdd(40, "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20101111 Firefox/4.0b7");
            UseragentsDictionary.TryAdd(41, "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20100101 Firefox/4.0b7");
            UseragentsDictionary.TryAdd(42,
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre");
            UseragentsDictionary.TryAdd(43,
                "Mozilla/5.0 (Windows NT 6.1; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre Firefox/4.0b6pre");
            UseragentsDictionary.TryAdd(44, "Mozilla/5.0 (X11; Linux x86_64; rv:2.0b4) Gecko/20100818 Firefox/4.0b4");
            UseragentsDictionary.TryAdd(45, "Mozilla/5.0 (X11; Linux i686; rv:2.0b3pre) Gecko/20100731 Firefox/4.0b3pre");
            UseragentsDictionary.TryAdd(46,
                "Mozilla/5.0 (Windows NT 5.2; rv:2.0b13pre) Gecko/20110304 Firefox/4.0b13pre");
            UseragentsDictionary.TryAdd(47,
                "Mozilla/5.0 (Windows NT 5.1; rv:2.0b13pre) Gecko/20110223 Firefox/4.0b13pre");
            UseragentsDictionary.TryAdd(48,
                "Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20110204 Firefox/4.0b12pre");
            UseragentsDictionary.TryAdd(49,
                "Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20100101 Firefox/4.0b12pre");
            UseragentsDictionary.TryAdd(50,
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre");
            UseragentsDictionary.TryAdd(51,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110131 Firefox/4.0b11pre");
            UseragentsDictionary.TryAdd(52,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110129 Firefox/4.0b11pre");
            UseragentsDictionary.TryAdd(53,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre");
            UseragentsDictionary.TryAdd(54,
                "Mozilla/5.0 (Windows NT 6.1; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre");
            UseragentsDictionary.TryAdd(55,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre");
            UseragentsDictionary.TryAdd(56,
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b10pre) Gecko/20110118 Firefox/4.0b10pre");
            UseragentsDictionary.TryAdd(57,
                "Mozilla/5.0 (Windows NT 6.1; rv:2.0b10pre) Gecko/20110113 Firefox/4.0b10pre");
            UseragentsDictionary.TryAdd(58, "Mozilla/5.0 (X11; Linux i686; rv:2.0b10) Gecko/20100101 Firefox/4.0b10");
            UseragentsDictionary.TryAdd(59,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:2.0b10) Gecko/20110126 Firefox/4.0b10");
            UseragentsDictionary.TryAdd(60, "Mozilla/5.0 (Windows NT 6.1; rv:2.0b10) Gecko/20110126 Firefox/4.0b10");
            UseragentsDictionary.TryAdd(61, "Mozilla/5.0 (X11; Linux x86_64; rv:2.0.1) Gecko/20110506 Firefox/4.0.1");
            UseragentsDictionary.TryAdd(62, "Mozilla/5.0 (X11; Linux i686; rv:2.0.1) Gecko/20110518 Firefox/4.0.1");
            UseragentsDictionary.TryAdd(63,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:2.0.1) Gecko/20110606 Firefox/4.0.1");
            UseragentsDictionary.TryAdd(64,
                "Mozilla/5.0 (X11; U; Linux x86_64; pl-PL; rv:2.0) Gecko/20110307 Firefox/4.0");
            UseragentsDictionary.TryAdd(65,
                "Mozilla/5.0 (X11; U; Linux i686; en-GB; rv:2.0) Gecko/20110404 Fedora/16-dev Firefox/4.0");
            UseragentsDictionary.TryAdd(66, "Mozilla/5.0 (X11; Arch Linux i686; rv:2.0) Gecko/20110321 Firefox/4.0");
            UseragentsDictionary.TryAdd(67,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(68, "Mozilla/5.0 (Windows NT 6.1; rv:2.0) Gecko/20110319 Firefox/4.0");
            UseragentsDictionary.TryAdd(69, "Mozilla/5.0 (Windows NT 6.1; rv:1.9) Gecko/20100101 Firefox/4.0");
            UseragentsDictionary.TryAdd(70,
                "Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/20121223 Ubuntu/9.25 (jaunty) Firefox/3.8");
            UseragentsDictionary.TryAdd(71,
                "Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8");
            UseragentsDictionary.TryAdd(72,
                "Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8");
            UseragentsDictionary.TryAdd(73,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.3) Gecko/20100401 Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8");
            UseragentsDictionary.TryAdd(74,
                "Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.3a5pre) Gecko/20100526 Firefox/3.7a5pre");
            UseragentsDictionary.TryAdd(75,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5");
            UseragentsDictionary.TryAdd(76,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5");
            UseragentsDictionary.TryAdd(77,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5");
            UseragentsDictionary.TryAdd(78,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6; en-US; rv:1.9.2) Gecko/20091218 Firefox 3.6b5");
            UseragentsDictionary.TryAdd(79,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(80,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4");
            UseragentsDictionary.TryAdd(81,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b1) Gecko/20091014 Firefox/3.6b1 GTB5");
            UseragentsDictionary.TryAdd(82,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090428 Firefox/3.6a1pre");
            UseragentsDictionary.TryAdd(83,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090405 Firefox/3.6a1pre");
            UseragentsDictionary.TryAdd(84,
                "Mozilla/5.0 (X11; U; Linux i686; ru-RU; rv:1.9.2a1pre) Gecko/20090405 Ubuntu/9.04 (jaunty) Firefox/3.6a1pre");
            UseragentsDictionary.TryAdd(85,
                "Mozilla/5.0 (Windows; Windows NT 5.1; es-ES; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre");
            UseragentsDictionary.TryAdd(86,
                "Mozilla/5.0 (Windows; Windows NT 5.1; en-US; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre");
            UseragentsDictionary.TryAdd(87,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ja; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(88,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.9) Gecko/20100915 Gentoo Firefox/3.6.9");
            UseragentsDictionary.TryAdd(89,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.9) Gecko/20100827 Red Hat/3.6.9-2.el6 Firefox/3.6.9");
            UseragentsDictionary.TryAdd(90,
                "Mozilla/5.0 (X11; U; FreeBSD i386; en-US; rv:1.9.2.9) Gecko/20100913 Firefox/3.6.9");
            UseragentsDictionary.TryAdd(91,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9 ( .NET CLR 3.5.30729; .NET CLR 4.0.20506)");
            UseragentsDictionary.TryAdd(92,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9");
            UseragentsDictionary.TryAdd(93,
                "Mozilla/5.0 (X11; U; OpenBSD i386; en-US; rv:1.9.2.8) Gecko/20101230 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(94,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100804 Gentoo Firefox/3.6.8");
            UseragentsDictionary.TryAdd(95,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100723 SUSE/3.6.8-0.1.1 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(96,
                "Mozilla/5.0 (X11; U; Linux i686; zh-CN; rv:1.9.2.8) Gecko/20100722 Ubuntu/10.04 (lucid) Firefox/3.6.8");
            UseragentsDictionary.TryAdd(97,
                "Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8");
            UseragentsDictionary.TryAdd(98,
                "Mozilla/5.0 (X11; U; Linux i686; fi-FI; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8");
            UseragentsDictionary.TryAdd(99,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.8) Gecko/20100727 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(100,
                "Mozilla/5.0 (X11; U; Linux i686; de-DE; rv:1.9.2.8) Gecko/20100725 Gentoo Firefox/3.6.8");
            UseragentsDictionary.TryAdd(101,
                "Mozilla/5.0 (X11; U; FreeBSD i386; de-CH; rv:1.9.2.8) Gecko/20100729 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(102,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(103,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-BR; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 GTB7.1");
            UseragentsDictionary.TryAdd(104,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.8) Gecko/20100722 AskTbADAP/3.9.1.14019 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(105,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; he; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(106,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; fr; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8 GTB7.1");
            UseragentsDictionary.TryAdd(107,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0C)");
            UseragentsDictionary.TryAdd(108,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8");
            UseragentsDictionary.TryAdd(109,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.3) Gecko/20121221 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(110,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; zh-TW; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(111,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8");
            UseragentsDictionary.TryAdd(112,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; tr; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0E)");
            UseragentsDictionary.TryAdd(113,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100809 Fedora/3.6.7-1.fc14 Firefox/3.6.7");
            UseragentsDictionary.TryAdd(114,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100723 Fedora/3.6.7-1.fc13 Firefox/3.6.7");
            UseragentsDictionary.TryAdd(115,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.7) Gecko/20100726 CentOS/3.6-3.el5.centos Firefox/3.6.7");
            UseragentsDictionary.TryAdd(116,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; hu; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 GTB7.1");
            UseragentsDictionary.TryAdd(117,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ru; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.7 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(118,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(119,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.1");
            UseragentsDictionary.TryAdd(120,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.0");
            UseragentsDictionary.TryAdd(121,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(122,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6");
            UseragentsDictionary.TryAdd(123,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-PT; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6");
            UseragentsDictionary.TryAdd(124,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(125,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(126,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 GTB7.1");
            UseragentsDictionary.TryAdd(127,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; nl; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6");
            UseragentsDictionary.TryAdd(128,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729; .NET4.0E)");
            UseragentsDictionary.TryAdd(129,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.4) Gecko/20100614 Ubuntu/10.04 (lucid) Firefox/3.6.4");
            UseragentsDictionary.TryAdd(130,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.4) Gecko/20100625 Gentoo Firefox/3.6.4");
            UseragentsDictionary.TryAdd(131,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(132,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4");
            UseragentsDictionary.TryAdd(133,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ja; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.1");
            UseragentsDictionary.TryAdd(134,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; cs; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(135,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4");
            UseragentsDictionary.TryAdd(136,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; ja; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(137,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; fr; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(138,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(139,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4");
            UseragentsDictionary.TryAdd(140,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(141,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(142,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-CA; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4");
            UseragentsDictionary.TryAdd(143,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.0 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(144,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(145,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100503 Firefox/3.6.4 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(146,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; nb-NO; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(147,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ko; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4");
            UseragentsDictionary.TryAdd(148,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4");
            UseragentsDictionary.TryAdd(149,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.3pre) Gecko/20100405 Firefox/3.6.3plugin1 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(150,
                "Mozilla/5.0 (X11; U; Linux x86_64; fr; rv:1.9.2.3) Gecko/20100403 Fedora/3.6.3-4.fc13 Firefox/3.6.3");
            UseragentsDictionary.TryAdd(151,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.3) Gecko/20100403 Firefox/3.6.3");
            UseragentsDictionary.TryAdd(152,
                "Mozilla/5.0 (X11; U; Linux x86_64; de; rv:1.9.2.3) Gecko/20100401 SUSE/3.6.3-1.1 Firefox/3.6.3");
            UseragentsDictionary.TryAdd(153,
                "Mozilla/5.0 (X11; U; Linux i686; ko-KR; rv:1.9.2.3) Gecko/20100423 Ubuntu/10.04 (lucid) Firefox/3.6.3");
            UseragentsDictionary.TryAdd(154,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.3) Gecko/20100404 Ubuntu/10.04 (lucid) Firefox/3.6.3");
            UseragentsDictionary.TryAdd(155,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3 GTB7.1");
            UseragentsDictionary.TryAdd(156,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.3");
            UseragentsDictionary.TryAdd(157,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.3) Gecko/20100423 Ubuntu/10.04 (lucid) Firefox/3.6.3");
            UseragentsDictionary.TryAdd(158,
                "Mozilla/5.0 (X11; U; Linux AMD64; en-US; rv:1.9.2.3) Gecko/20100403 Ubuntu/10.10 (maverick) Firefox/3.6.3");
            UseragentsDictionary.TryAdd(159,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-CN; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(160,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3");
            UseragentsDictionary.TryAdd(161,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; pl; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3");
            UseragentsDictionary.TryAdd(162,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3");
            UseragentsDictionary.TryAdd(163,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; hu; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3 GTB7.1");
            UseragentsDictionary.TryAdd(164,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3 GTB7.1");
            UseragentsDictionary.TryAdd(165,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3 GTB7.0 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(166,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3");
            UseragentsDictionary.TryAdd(167,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(168,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; cs; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(169,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ca; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(170,
                "Mozilla/5.0 (X11; U; Linux i686; fr; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2");
            UseragentsDictionary.TryAdd(171,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; fr; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2 GTB7.0");
            UseragentsDictionary.TryAdd(172,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.2) Gecko/20100316 AskTbSPC2/3.9.1.14019 Firefox/3.6.2");
            UseragentsDictionary.TryAdd(173,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(174,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ru; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(175,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pl; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2 GTB6 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(176,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; de; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2 ( .NET CLR 3.0.04506.648)");
            UseragentsDictionary.TryAdd(177,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; de; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2 ( .NET CLR 3.0.04506.30)");
            UseragentsDictionary.TryAdd(178,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.7; en-US; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2");
            UseragentsDictionary.TryAdd(179,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.10pre) Gecko/20100902 Ubuntu/9.10 (karmic) Firefox/3.6.1pre");
            UseragentsDictionary.TryAdd(180,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10.4; en-GB; rv:1.9.2.19) Gecko/20110707 Firefox/3.6.19");
            UseragentsDictionary.TryAdd(181,
                "Mozilla/5.0 (X11; U; Linux x86_64; ru; rv:1.9.2.18) Gecko/20110628 Ubuntu/10.10 (maverick) Firefox/3.6.18");
            UseragentsDictionary.TryAdd(182,
                "Mozilla/5.0 (X11; U; Linux i686; pl; rv:1.9.2.18) Gecko/20110614 Firefox/3.6.18 ( .NET CLR 3.5.30729; .NET4.0E)");
            UseragentsDictionary.TryAdd(183,
                "Mozilla/5.0 (X11; U; Linux i686; en-GB; rv:1.9.2.18) Gecko/20110628 Ubuntu/10.10 (maverick) Firefox/3.6.18");
            UseragentsDictionary.TryAdd(184,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.18) Gecko/20110628 Ubuntu/10.10 (maverick) Firefox/3.6.18");
            UseragentsDictionary.TryAdd(185,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.18) Gecko/20110615 Ubuntu/10.10 (maverick) Firefox/3.6.18");
            UseragentsDictionary.TryAdd(186,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-BR; rv:1.9.2.18) Gecko/20110614 Firefox/3.6.18 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(187,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ar; rv:1.9.2.18) Gecko/20110614 Firefox/3.6.18");
            UseragentsDictionary.TryAdd(188,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; pt-BR; rv:1.9.2.18) Gecko/20110614 Firefox/3.6.18 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(189,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-GB; rv:1.9.2.18) Gecko/20110614 Firefox/3.6.18 ( .NET CLR 3.5.30729; .NET4.0E)");
            UseragentsDictionary.TryAdd(190,
                "Mozilla/5.0 (X11; U; Linux i686 (x86_64); en-GB; rv:1.9.2.17) Gecko/20110420 Firefox/3.6.17");
            UseragentsDictionary.TryAdd(191,
                "Mozilla/5.0 (X11; Linux i686 on x86_64; rv:5.0) Gecko/20100101 Firefox/3.6.17 Firefox/3.6.17");
            UseragentsDictionary.TryAdd(192,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.17) Gecko/20110420 Firefox/3.6.17");
            UseragentsDictionary.TryAdd(193,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; tr; rv:1.9.2.17) Gecko/20110420 Firefox/3.6.17");
            UseragentsDictionary.TryAdd(194,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; sl; rv:1.9.2.17) Gecko/20110420 Firefox/3.6.17 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(195,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-BR; rv:1.9.2.17) Gecko/20110420 Firefox/3.6.17 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(196,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; it; rv:1.9.2.17) Gecko/20110420 Firefox/3.6.17 ( .NET CLR 3.5.30729; .NET4.0E)");
            UseragentsDictionary.TryAdd(197,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; hu; rv:1.9.2.17) Gecko/20110420 Firefox/3.6.17 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(198,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2.17) Gecko/20110420 Firefox/3.6.17 ( .NET CLR 3.5.30729; .NET4.0E)");
            UseragentsDictionary.TryAdd(199,
                "Mozilla/5.0 (X11; U; Linux x86_64; ja-JP; rv:1.9.2.16) Gecko/20110323 Ubuntu/10.10 (maverick) Firefox/3.6.16");
            UseragentsDictionary.TryAdd(200,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.16) Gecko/20110323 Ubuntu/9.10 (karmic) Firefox/3.6.16 FirePHP/0.5");
            UseragentsDictionary.TryAdd(201,
                "Mozilla/5.0 (X11; U; Linux i686; en-GB; rv:1.9.2.16) Gecko/20110319 Firefox/3.6.16");
            UseragentsDictionary.TryAdd(202,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; fr; rv:1.9.2.16) Gecko/20110319 Firefox/3.6.16");
            UseragentsDictionary.TryAdd(203,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; pl; rv:1.9.2.16) Gecko/20110319 Firefox/3.6.16");
            UseragentsDictionary.TryAdd(204,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ko; rv:1.9.2.16) Gecko/20110319 Firefox/3.6.16 ( .NET CLR 3.5.30729; .NET4.0E)");
            UseragentsDictionary.TryAdd(205,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2.16) Gecko/20110319 Firefox/3.6.16 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(206,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en; rv:1.9.1.13) Gecko/20100914 Firefox/3.6.16");
            UseragentsDictionary.TryAdd(207,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-GB; rv:1.9.2.16) Gecko/20110319 AskTbUTR/3.11.3.15590 Firefox/3.6.16");
            UseragentsDictionary.TryAdd(208,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.16pre) Gecko/20110304 Ubuntu/10.10 (maverick) Firefox/3.6.15pre");
            UseragentsDictionary.TryAdd(209,
                "Mozilla/5.0 (X11; U; Linux i686; nl; rv:1.9.2.15) Gecko/20110303 Ubuntu/8.04 (hardy) Firefox/3.6.15");
            UseragentsDictionary.TryAdd(210,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.15) Gecko/20110303 Ubuntu/10.04 (lucid) Firefox/3.6.15 FirePHP/0.5");
            UseragentsDictionary.TryAdd(211,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.15) Gecko/20110330 CentOS/3.6-1.el5.centos Firefox/3.6.15");
            UseragentsDictionary.TryAdd(212,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15");
            UseragentsDictionary.TryAdd(213,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15 ( .NET CLR 3.5.30729; .NET4.0C) FirePHP/0.5");
            UseragentsDictionary.TryAdd(214,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-GB; rv:1.9.2.15) Gecko/20110303 AskTbBT4/3.11.3.15590 Firefox/3.6.15 ( .NET CLR 3.5.30729; .NET4.0C)");
            UseragentsDictionary.TryAdd(215,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(216,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.14pre) Gecko/20110105 Firefox/3.6.14pre");
            UseragentsDictionary.TryAdd(217,
                "Mozilla/5.0 (X11; U; Linux armv7l; en-US; rv:1.9.2.14) Gecko/20110224 Firefox/3.6.14 MB860/Version.0.43.3.MB860.AmericaMovil.en.MX");
            UseragentsDictionary.TryAdd(218,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-CN; rv:1.9.2.14) Gecko/20110218 Firefox/3.6.14");
            UseragentsDictionary.TryAdd(219,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-AU; rv:1.9.2.14) Gecko/20110218 Firefox/3.6.14");
            UseragentsDictionary.TryAdd(220,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-GB; rv:1.9.2.14) Gecko/20110218 Firefox/3.6.14 GTB7.1 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(221,
                "Mozilla/5.0 Mozilla/5.0 (Windows; U; Windows NT 5.1; de; rv:1.9.2.13) Firefox/3.6.13");
            UseragentsDictionary.TryAdd(222,
                "Mozilla/5.0 (X11; U; Linux x86_64; pl-PL; rv:1.9.2.13) Gecko/20101206 Ubuntu/10.04 (lucid) Firefox/3.6.13");
            UseragentsDictionary.TryAdd(223,
                "Mozilla/5.0 (X11; U; Linux x86_64; nb-NO; rv:1.9.2.13) Gecko/20101206 Ubuntu/10.04 (lucid) Firefox/3.6.13");
            UseragentsDictionary.TryAdd(224,
                "Mozilla/5.0 (X11; U; Linux x86_64; it; rv:1.9.2.13) Gecko/20101206 Ubuntu/10.04 (lucid) Firefox/3.6.13 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(225,
                "Mozilla/5.0 (X11; U; Linux x86_64; fr; rv:1.9.2.13) Gecko/20110103 Fedora/3.6.13-1.fc14 Firefox/3.6.13");
            UseragentsDictionary.TryAdd(226,
                "Mozilla/5.0 (X11; U; Linux x86_64; fr; rv:1.9.2.13) Gecko/20101203 Firefox/3.6.13");
            UseragentsDictionary.TryAdd(227,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.13) Gecko/20101223 Gentoo Firefox/3.6.13");
            UseragentsDictionary.TryAdd(228,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.13) Gecko/20101219 Gentoo Firefox/3.6.13");
            UseragentsDictionary.TryAdd(229,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.13) Gecko/20101206 Red Hat/3.6-3.el4 Firefox/3.6.13");
            UseragentsDictionary.TryAdd(230,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.13) Gecko/20101206 Firefox/3.6.13");
            UseragentsDictionary.TryAdd(231,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-NZ; rv:1.9.2.13) Gecko/20101206 Ubuntu/10.10 (maverick) Firefox/3.6.13");
            UseragentsDictionary.TryAdd(232,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-GB; rv:1.9.2.13) Gecko/20101206 Ubuntu/9.10 (karmic) Firefox/3.6.13");
            UseragentsDictionary.TryAdd(233,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-GB; rv:1.9.2.13) Gecko/20101206 Red Hat/3.6-2.el5 Firefox/3.6.13");
            UseragentsDictionary.TryAdd(234,
                "Mozilla/5.0 (X11; U; Linux x86_64; da-DK; rv:1.9.2.13) Gecko/20101206 Ubuntu/10.10 (maverick) Firefox/3.6.13");
            UseragentsDictionary.TryAdd(235,
                "Mozilla/5.0 (X11; U; Linux MIPS32 1074Kf CPS QuadCore; en-US; rv:1.9.2.13) Gecko/20110103 Fedora/3.6.13-1.fc14 Firefox/3.6.13");
            UseragentsDictionary.TryAdd(236,
                "Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.2.13) Gecko/20101206 Ubuntu/10.10 (maverick) Firefox/3.6.13");
            UseragentsDictionary.TryAdd(237,
                "Mozilla/5.0 (X11; U; Linux i686; pt-BR; rv:1.9.2.13) Gecko/20101209 Fedora/3.6.13-1.fc13 Firefox/3.6.13");
            UseragentsDictionary.TryAdd(238,
                "Mozilla/5.0 (X11; U; Linux i686; es-ES; rv:1.9.2.13) Gecko/20101206 Ubuntu/9.10 (karmic) Firefox/3.6.13");
            UseragentsDictionary.TryAdd(239,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.13) Gecko/20101209 CentOS/3.6-2.el5.centos Firefox/3.6.13");
            UseragentsDictionary.TryAdd(240,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.13) Gecko/20101206 Ubuntu/10.10 (maverick) Firefox/3.6.13");
            UseragentsDictionary.TryAdd(241,
                "Mozilla/5.0 (X11; U; NetBSD i386; en-US; rv:1.9.2.12) Gecko/20101030 Firefox/3.6.12");
            UseragentsDictionary.TryAdd(242,
                "Mozilla/5.0 (X11; U; Linux x86_64; es-MX; rv:1.9.2.12) Gecko/20101027 Ubuntu/10.04 (lucid) Firefox/3.6.12");
            UseragentsDictionary.TryAdd(243,
                "Mozilla/5.0 (X11; U; Linux x86_64; es-ES; rv:1.9.2.12) Gecko/20101027 Fedora/3.6.12-1.fc13 Firefox/3.6.12");
            UseragentsDictionary.TryAdd(244,
                "Mozilla/5.0 (X11; U; Linux x86_64; es-ES; rv:1.9.2.12) Gecko/20101026 SUSE/3.6.12-0.7.1 Firefox/3.6.12");
            UseragentsDictionary.TryAdd(245,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.12) Gecko/20101102 Gentoo Firefox/3.6.12");
            UseragentsDictionary.TryAdd(246,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.12) Gecko/20101102 Firefox/3.6.12");
            UseragentsDictionary.TryAdd(247,
                "Mozilla/5.0 (X11; U; Linux ppc; fr; rv:1.9.2.12) Gecko/20101027 Ubuntu/10.10 (maverick) Firefox/3.6.12");
            UseragentsDictionary.TryAdd(248,
                "Mozilla/5.0 (X11; U; Linux i686; ko-KR; rv:1.9.2.12) Gecko/20101027 Ubuntu/10.10 (maverick) Firefox/3.6.12");
            UseragentsDictionary.TryAdd(249,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.12) Gecko/20101114 Gentoo Firefox/3.6.12");
            UseragentsDictionary.TryAdd(250,
                "Mozilla/5.0 (X11; U; Linux i686; en-GB; rv:1.9.2.12) Gecko/20101027 Ubuntu/10.10 (maverick) Firefox/3.6.12 GTB7.1");
            UseragentsDictionary.TryAdd(251,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.12) Gecko/20101027 Fedora/3.6.12-1.fc13 Firefox/3.6.12");
            UseragentsDictionary.TryAdd(252, "Mozilla/5.0 (X11; FreeBSD x86_64; rv:2.0) Gecko/20100101 Firefox/3.6.12");
            UseragentsDictionary.TryAdd(253,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-CN; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12 ( .NET CLR 3.5.30729; .NET4.0E)");
            UseragentsDictionary.TryAdd(254,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; sv-SE; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12");
            UseragentsDictionary.TryAdd(255,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12 (.NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; .NET CLR 3.5.21022)");
            UseragentsDictionary.TryAdd(256,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6; de; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12 GTB5");
            UseragentsDictionary.TryAdd(257,
                "Mozilla/5.0 (X11; U; Linux armv7l; en-GB; rv:1.9.2.3pre) Gecko/20100723 Firefox/3.6.11");
            UseragentsDictionary.TryAdd(258,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; ru; rv:1.9.2.11) Gecko/20101012 Firefox/3.6.11");
            UseragentsDictionary.TryAdd(259,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; it; rv:1.9.2.11) Gecko/20101012 Firefox/3.6.11 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(260,
                "Mozilla/5.0 (X11; U; Linux x86_64; zh-CN; rv:1.9.2.10) Gecko/20100922 Ubuntu/10.10 (maverick) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(261,
                "Mozilla/5.0 (X11; U; Linux x86_64; pt-BR; rv:1.9.2.10) Gecko/20100922 Ubuntu/10.10 (maverick) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(262,
                "Mozilla/5.0 (X11; U; Linux x86_64; pl-PL; rv:1.9.2.10) Gecko/20100922 Ubuntu/10.10 (maverick) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(263,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.10) Gecko/20100922 Ubuntu/10.10 (maverick) Firefox/3.6.10 GTB7.1");
            UseragentsDictionary.TryAdd(264,
                "Mozilla/5.0 (X11; U; Linux x86_64; el-GR; rv:1.9.2.10) Gecko/20100922 Ubuntu/10.10 (maverick) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(265,
                "Mozilla/5.0 (X11; U; Linux x86_64; de; rv:1.9.2.10) Gecko/20100922 Ubuntu/10.10 (maverick) Firefox/3.6.10 GTB7.1");
            UseragentsDictionary.TryAdd(266,
                "Mozilla/5.0 (X11; U; Linux x86_64; cs-CZ; rv:1.9.2.10) Gecko/20100915 Ubuntu/10.04 (lucid) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(267,
                "Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.2.10) Gecko/20100915 Ubuntu/10.04 (lucid) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(268,
                "Mozilla/5.0 (X11; U; Linux i686; fr-FR; rv:1.9.2.10) Gecko/20100914 Firefox/3.6.10");
            UseragentsDictionary.TryAdd(269,
                "Mozilla/5.0 (X11; U; Linux i686; es-AR; rv:1.9.2.10) Gecko/20100922 Ubuntu/10.10 (maverick) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(270,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.10) Gecko/20100915 Ubuntu/9.04 (jaunty) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(271,
                "Mozilla/5.0 (X11; U; Linux i686; en-GB; rv:1.9.2.11) Gecko/20101013 Ubuntu/10.10 (maverick) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(272,
                "Mozilla/5.0 (X11; U; Linux i686; en-CA; rv:1.9.2.10) Gecko/20100922 Ubuntu/10.10 (maverick) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(273,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.10) Gecko/20100922 Ubuntu/10.10 (maverick) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(274,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.10) Gecko/20100915 Ubuntu/9.10 (karmic) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(275,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.10) Gecko/20100915 Ubuntu/10.04 (lucid) Firefox/3.6.10");
            UseragentsDictionary.TryAdd(276,
                "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.2.10) Gecko/20100914 SUSE/3.6.10-0.3.1 Firefox/3.6.10");
            UseragentsDictionary.TryAdd(277,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ro; rv:1.9.2.10) Gecko/20100914 Firefox/3.6.10");
            UseragentsDictionary.TryAdd(278,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; nl; rv:1.9.2.10) Gecko/20100914 Firefox/3.6.10 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(279,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; fr; rv:1.9.2.10) Gecko/20100914 Firefox/3.6.10 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(280,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.1) Gecko/20100122 firefox/3.6.1");
            UseragentsDictionary.TryAdd(281,
                "Mozilla/5.0(Windows; U; Windows NT 7.0; rv:1.9.2) Gecko/20100101 Firefox/3.6");
            UseragentsDictionary.TryAdd(282,
                "Mozilla/5.0(Windows; U; Windows NT 5.2; rv:1.9.2) Gecko/20100101 Firefox/3.6");
            UseragentsDictionary.TryAdd(283,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2) Gecko/20100222 Ubuntu/10.04 (lucid) Firefox/3.6");
            UseragentsDictionary.TryAdd(284,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2) Gecko/20100130 Gentoo Firefox/3.6");
            UseragentsDictionary.TryAdd(285,
                "Mozilla/5.0 (X11; U; Linux x86_64; de; rv:1.9.2) Gecko/20100308 Ubuntu/10.04 (lucid) Firefox/3.6");
            UseragentsDictionary.TryAdd(286,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.2pre) Gecko/20100312 Ubuntu/9.04 (jaunty) Firefox/3.6");
            UseragentsDictionary.TryAdd(287,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2) Gecko/20100128 Gentoo Firefox/3.6");
            UseragentsDictionary.TryAdd(288,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2) Gecko/20100115 Ubuntu/10.04 (lucid) Firefox/3.6");
            UseragentsDictionary.TryAdd(289,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2) Gecko/20100115 Firefox/3.6 FirePHP/0.4");
            UseragentsDictionary.TryAdd(290, "Mozilla/5.0 (X11; Linux i686; rv:2.0) Gecko/20100101 Firefox/3.6");
            UseragentsDictionary.TryAdd(291, "Mozilla/5.0 (X11; FreeBSD i686) Firefox/3.6");
            UseragentsDictionary.TryAdd(292,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru-RU; rv:1.9.2) Gecko/20100105 MRA 5.6 (build 03278) Firefox/3.6 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(293,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; lt; rv:1.9.2) Gecko/20100115 Firefox/3.6");
            UseragentsDictionary.TryAdd(294,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.3a3pre) Gecko/20100306 Firefox3.6 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(295,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.8) Gecko/20100806 Firefox/3.6");
            UseragentsDictionary.TryAdd(296,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.17) Gecko/20110420 Firefox/3.6");
            UseragentsDictionary.TryAdd(297,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.3) Gecko/20100401 Firefox/3.6;MEGAUPLOAD 1.0");
            UseragentsDictionary.TryAdd(298,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ar; rv:1.9.2) Gecko/20100115 Firefox/3.6");
            UseragentsDictionary.TryAdd(299,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; ru; rv:1.9.2) Gecko/20100115 Firefox/3.6");
            UseragentsDictionary.TryAdd(300,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; ru; rv:1.9.2) Gecko/20100105 Firefox/3.6 (.NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(301, "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; WOW64; Trident/6.0)");
            UseragentsDictionary.TryAdd(302, "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)");
            UseragentsDictionary.TryAdd(303, "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/5.0)");
            UseragentsDictionary.TryAdd(304, "Mozilla/4.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/5.0)");
            UseragentsDictionary.TryAdd(305, "Mozilla/1.22 (compatible; MSIE 10.0; Windows 3.1)");
            UseragentsDictionary.TryAdd(306, "Mozilla/5.0 (Windows; U; MSIE 9.0; WIndows NT 9.0; en-US))");
            UseragentsDictionary.TryAdd(307, "Mozilla/5.0 (Windows; U; MSIE 9.0; Windows NT 9.0; en-US)");
            UseragentsDictionary.TryAdd(308, "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)");
            UseragentsDictionary.TryAdd(309,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; Media Center PC 6.0; InfoPath.3; MS-RTC LM 8; Zune 4.7)");
            UseragentsDictionary.TryAdd(310,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; Zune 4.0; InfoPath.3; MS-RTC LM 8; .NET4.0C; .NET4.0E)");
            UseragentsDictionary.TryAdd(311,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; chromeframe/12.0.742.112)");
            UseragentsDictionary.TryAdd(312,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET CLR 2.0.50727; Media Center PC 6.0)");
            UseragentsDictionary.TryAdd(313,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Win64; x64; Trident/5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET CLR 2.0.50727; Media Center PC 6.0)");
            UseragentsDictionary.TryAdd(314,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Win64; x64; Trident/5.0; .NET CLR 2.0.50727; SLCC2; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; Zune 4.0; Tablet PC 2.0; InfoPath.3; .NET4.0C; .NET4.0E)");
            UseragentsDictionary.TryAdd(315,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Win64; x64; Trident/5.0");
            UseragentsDictionary.TryAdd(316, "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0; yie8)");
            UseragentsDictionary.TryAdd(317,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0; FunWebProducts)");
            UseragentsDictionary.TryAdd(318,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0; chromeframe/11.0.696.57)");
            UseragentsDictionary.TryAdd(319,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0) chromeframe/10.0.648.205");
            UseragentsDictionary.TryAdd(320,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.0; Trident/5.0; chromeframe/11.0.696.57)");
            UseragentsDictionary.TryAdd(321, "Mozilla/5.0 ( ; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            UseragentsDictionary.TryAdd(322,
                "Mozilla/4.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/4.0; FDM; MSIECrawler; Media Center PC 5.0)");
            UseragentsDictionary.TryAdd(323, "Mozilla/4.0 (compatible; MSIE 9.0; Windows NT 5.1; Trident/5.0)");
            UseragentsDictionary.TryAdd(324,
                "Mozilla/4.0 (compatible; MSIE 9.0; Windows NT 5.1; Trident/4.0; .NET CLR 2.0.50727; .NET CLR 1.1.4322; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; OfficeLiveConnector.1.4; OfficeLivePatch.1.3; .NET4.0C; .NE");
            UseragentsDictionary.TryAdd(325,
                "Mozilla/5.0 (compatible; MSIE 8.0; Windows NT 5.2; Trident/4.0; Media Center PC 4.0; SLCC1; .NET CLR 3.0.04320)");
            UseragentsDictionary.TryAdd(326,
                "Mozilla/5.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; SLCC1; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(327,
                "Mozilla/5.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; InfoPath.2; SLCC1; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(328,
                "Mozilla/5.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(329,
                "Mozilla/5.0 (compatible; MSIE 8.0; Windows NT 5.0; Trident/4.0; InfoPath.1; SV1; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET CLR 3.0.04506.30)");
            UseragentsDictionary.TryAdd(330,
                "Mozilla/5.0 (compatible; MSIE 7.0; Windows NT 5.0; Trident/4.0; FBSMTWB; .NET CLR 2.0.34861; .NET CLR 3.0.3746.3218; .NET CLR 3.5.33652; msn OptimizedIE8;ENUS)");
            UseragentsDictionary.TryAdd(331,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.2; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)");
            UseragentsDictionary.TryAdd(332,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; Media Center PC 6.0; InfoPath.2; MS-RTC LM 8)");
            UseragentsDictionary.TryAdd(333,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; Media Center PC 6.0; InfoPath.2; MS-RTC LM 8");
            UseragentsDictionary.TryAdd(334,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; Media Center PC 6.0; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C)");
            UseragentsDictionary.TryAdd(335,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; InfoPath.3; .NET4.0C; .NET4.0E; .NET CLR 3.5.30729; .NET CLR 3.0.30729; MS-RTC LM 8)");
            UseragentsDictionary.TryAdd(336,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; InfoPath.2)");
            UseragentsDictionary.TryAdd(337,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; Zune 3.0)");
            UseragentsDictionary.TryAdd(338,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; msn OptimizedIE8;ZHCN)");
            UseragentsDictionary.TryAdd(339,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; MS-RTC LM 8; InfoPath.3; .NET4.0C; .NET4.0E) chromeframe/8.0.552.224");
            UseragentsDictionary.TryAdd(340,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; MS-RTC LM 8; .NET4.0C; .NET4.0E; Zune 4.7; InfoPath.3)");
            UseragentsDictionary.TryAdd(341,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; MS-RTC LM 8; .NET4.0C; .NET4.0E; Zune 4.7)");
            UseragentsDictionary.TryAdd(342,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; MS-RTC LM 8)");
            UseragentsDictionary.TryAdd(343,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.3; Zune 4.0)");
            UseragentsDictionary.TryAdd(344,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.3; .NET4.0C; .NET4.0E; MS-RTC LM 8; Zune 4.7)");
            UseragentsDictionary.TryAdd(345, "Mozilla/4.0(compatible; MSIE 7.0b; Windows NT 6.0)");
            UseragentsDictionary.TryAdd(346, "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 6.0)");
            UseragentsDictionary.TryAdd(347,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; InfoPath.2; .NET CLR 3.0.04506.30)");
            UseragentsDictionary.TryAdd(348,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; Media Center PC 3.0; .NET CLR 1.0.3705; .NET CLR 1.1.4322; .NET CLR 2.0.50727; InfoPath.1)");
            UseragentsDictionary.TryAdd(349,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; FDM; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(350,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; .NET CLR 1.1.4322; InfoPath.1; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(351,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; .NET CLR 1.1.4322; InfoPath.1)");
            UseragentsDictionary.TryAdd(352,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; .NET CLR 1.1.4322; Alexa Toolbar; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(353,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; .NET CLR 1.1.4322; Alexa Toolbar)");
            UseragentsDictionary.TryAdd(354,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(355,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.40607)");
            UseragentsDictionary.TryAdd(356, "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(357,
                "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 5.1; .NET CLR 1.0.3705; Media Center PC 3.1; Alexa Toolbar; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(358, "Mozilla/5.0 (Windows; U; MSIE 7.0; Windows NT 6.0; en-US)");
            UseragentsDictionary.TryAdd(359, "Mozilla/5.0 (Windows; U; MSIE 7.0; Windows NT 6.0; el-GR)");
            UseragentsDictionary.TryAdd(360, "Mozilla/5.0 (Windows; U; MSIE 7.0; Windows NT 5.2)");
            UseragentsDictionary.TryAdd(361,
                "Mozilla/5.0 (MSIE 7.0; Macintosh; U; SunOS; X11; gu; SV1; InfoPath.2; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648)");
            UseragentsDictionary.TryAdd(362,
                "Mozilla/5.0 (compatible; MSIE 7.0; Windows NT 6.0; WOW64; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; c .NET CLR 3.0.04506; .NET CLR 3.5.30707; InfoPath.1; el-GR)");
            UseragentsDictionary.TryAdd(363,
                "Mozilla/5.0 (compatible; MSIE 7.0; Windows NT 6.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; c .NET CLR 3.0.04506; .NET CLR 3.5.30707; InfoPath.1; el-GR)");
            UseragentsDictionary.TryAdd(364, "Mozilla/5.0 (compatible; MSIE 7.0; Windows NT 6.0; fr-FR)");
            UseragentsDictionary.TryAdd(365, "Mozilla/5.0 (compatible; MSIE 7.0; Windows NT 6.0; en-US)");
            UseragentsDictionary.TryAdd(366,
                "Mozilla/5.0 (compatible; MSIE 7.0; Windows NT 5.2; WOW64; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(367,
                "Mozilla/5.0 (compatible; MSIE 7.0; Windows 98; SpamBlockerUtility 6.3.91; SpamBlockerUtility 6.2.91; .NET CLR 4.1.89;GB)");
            UseragentsDictionary.TryAdd(368,
                "Mozilla/4.79 [en] (compatible; MSIE 7.0; Windows NT 5.0; .NET CLR 2.0.50727; InfoPath.2; .NET CLR 1.1.4322; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648)");
            UseragentsDictionary.TryAdd(369, "Mozilla/4.0 (Windows; MSIE 7.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(370,
                "Mozilla/4.0 (Mozilla/4.0; MSIE 7.0; Windows NT 5.1; FDM; SV1; .NET CLR 3.0.04506.30)");
            UseragentsDictionary.TryAdd(371, "Mozilla/4.0 (Mozilla/4.0; MSIE 7.0; Windows NT 5.1; FDM; SV1)");
            UseragentsDictionary.TryAdd(372, "Mozilla/4.0 (compatible;MSIE 7.0;Windows NT 6.0)");
            UseragentsDictionary.TryAdd(373,
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; SLCC2; .NET CLR 2.0.50727; InfoPath.3; .NET4.0C; .NET4.0E; .NET CLR 3.5.30729; .NET CLR 3.0.30729; MS-RTC LM 8)");
            UseragentsDictionary.TryAdd(374,
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; MS-RTC LM 8; .NET4.0C; .NET4.0E; InfoPath.3)");
            UseragentsDictionary.TryAdd(375,
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; chromeframe/12.0.742.100)");
            UseragentsDictionary.TryAdd(376,
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E)");
            UseragentsDictionary.TryAdd(377,
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)");
            UseragentsDictionary.TryAdd(378,
                "Mozilla/4.0 (compatible; MSIE 6.1; Windows XP; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(379, "Mozilla/4.0 (compatible; MSIE 6.1; Windows XP)");
            UseragentsDictionary.TryAdd(380, "Mozilla/4.0 (compatible; MSIE 6.01; Windows NT 6.0)");
            UseragentsDictionary.TryAdd(381, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 5.1; DigExt)");
            UseragentsDictionary.TryAdd(382, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 5.1)");
            UseragentsDictionary.TryAdd(383, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 5.0; YComp 5.0.2.6)");
            UseragentsDictionary.TryAdd(384,
                "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 5.0; YComp 5.0.0.0) (Compatible; ; ; Trident/4.0)");
            UseragentsDictionary.TryAdd(385, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 5.0; YComp 5.0.0.0)");
            UseragentsDictionary.TryAdd(386, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 5.0; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(387, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 5.0)");
            UseragentsDictionary.TryAdd(388, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 4.0; .NET CLR 1.0.2914)");
            UseragentsDictionary.TryAdd(389, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 4.0)");
            UseragentsDictionary.TryAdd(390, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows 98; YComp 5.0.0.0)");
            UseragentsDictionary.TryAdd(391, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows 98; Win 9x 4.90)");
            UseragentsDictionary.TryAdd(392, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows 98)");
            UseragentsDictionary.TryAdd(393, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 5.1)");
            UseragentsDictionary.TryAdd(394, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 5.0; .NET CLR 1.0.3705)");
            UseragentsDictionary.TryAdd(395, "Mozilla/4.0 (compatible; MSIE 6.0b; Windows NT 4.0)");
            UseragentsDictionary.TryAdd(396,
                "Mozilla/5.0 (Windows; U; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(397,
                "Mozilla/5.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(398,
                "Mozilla/5.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4325)");
            UseragentsDictionary.TryAdd(399, "Mozilla/5.0 (compatible; MSIE 6.0; Windows NT 5.1)");
            UseragentsDictionary.TryAdd(400, "Mozilla/45.0 (compatible; MSIE 6.0; Windows NT 5.1)");
            UseragentsDictionary.TryAdd(401, "Mozilla/4.08 (compatible; MSIE 6.0; Windows NT 5.1)");
            UseragentsDictionary.TryAdd(402, "Mozilla/4.01 (compatible; MSIE 6.0; Windows NT 5.1)");
            UseragentsDictionary.TryAdd(403,
                "Mozilla/4.0 (X11; MSIE 6.0; i686; .NET CLR 1.1.4322; .NET CLR 2.0.50727; FDM)");
            UseragentsDictionary.TryAdd(404, "Mozilla/4.0 (Windows; MSIE 6.0; Windows NT 6.0)");
            UseragentsDictionary.TryAdd(405, "Mozilla/4.0 (Windows; MSIE 6.0; Windows NT 5.2)");
            UseragentsDictionary.TryAdd(406, "Mozilla/4.0 (Windows; MSIE 6.0; Windows NT 5.0)");
            UseragentsDictionary.TryAdd(407, "Mozilla/4.0 (Windows; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(408, "Mozilla/4.0 (MSIE 6.0; Windows NT 5.1)");
            UseragentsDictionary.TryAdd(409, "Mozilla/4.0 (MSIE 6.0; Windows NT 5.0)");
            UseragentsDictionary.TryAdd(410, "Mozilla/4.0 (compatible;MSIE 6.0;Windows 98;Q312461)");
            UseragentsDictionary.TryAdd(411,
                "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(412, "Mozilla/4.0 (compatible; U; MSIE 6.0; Windows NT 5.1)");
            UseragentsDictionary.TryAdd(413,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; InfoPath.3; Tablet PC 2.0)");
            UseragentsDictionary.TryAdd(414,
                "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; GTB6.5; QQDownload 534; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; SLCC2; .NET CLR 2.0.50727; Media Center PC 6.0; .NET CLR 3.5.30729; .NET CLR 3.0.30729)");
            UseragentsDictionary.TryAdd(415,
                "Mozilla/4.0 (Compatible; MSIE 8.0; Windows NT 6.1; FDM; .NET CLR 1.1.4322; Windows NT 6.1; Trident/4.0; Mozilla/4.0; MSIE 6.0; Windows NT 5.1; SV1 ; SLCC2; .NET CLR 2.0.50727; Media Center PC 6.0; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET CLR 1.1.");
            UseragentsDictionary.TryAdd(416, "Opera/9.80 (Windows NT 6.1; U; es-ES) Presto/2.9.181 Version/12.00");
            UseragentsDictionary.TryAdd(417, "Opera/9.80 (X11; Linux x86_64; U; fr) Presto/2.9.168 Version/11.50");
            UseragentsDictionary.TryAdd(418, "Opera/9.80 (X11; Linux i686; U; ru) Presto/2.8.131 Version/11.11");
            UseragentsDictionary.TryAdd(419, "Opera/9.80 (X11; Linux i686; U; es-ES) Presto/2.8.131 Version/11.11");
            UseragentsDictionary.TryAdd(420,
                "Mozilla/5.0 (Windows NT 5.1; U; en; rv:1.8.1) Gecko/20061208 Firefox/5.0 Opera 11.11");
            UseragentsDictionary.TryAdd(421, "Opera/9.80 (X11; Linux x86_64; U; bg) Presto/2.8.131 Version/11.10");
            UseragentsDictionary.TryAdd(422, "Opera/9.80 (Windows NT 6.0; U; en) Presto/2.8.99 Version/11.10");
            UseragentsDictionary.TryAdd(423, "Opera/9.80 (Windows NT 5.1; U; zh-tw) Presto/2.8.131 Version/11.10");
            UseragentsDictionary.TryAdd(424,
                "Opera/9.80 (Windows NT 6.1; Opera Tablet/15165; U; en) Presto/2.8.149 Version/11.1");
            UseragentsDictionary.TryAdd(425,
                "Opera/9.80 (X11; Linux x86_64; U; Ubuntu/10.10 (maverick); pl) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(426, "Opera/9.80 (X11; Linux i686; U; ja) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(427, "Opera/9.80 (X11; Linux i686; U; fr) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(428, "Opera/9.80 (Windows NT 6.1; U; zh-tw) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(429, "Opera/9.80 (Windows NT 6.1; U; zh-cn) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(430, "Opera/9.80 (Windows NT 6.1; U; sv) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(431, "Opera/9.80 (Windows NT 6.1; U; en-US) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(432, "Opera/9.80 (Windows NT 6.1; U; cs) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(433, "Opera/9.80 (Windows NT 6.0; U; pl) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(434, "Opera/9.80 (Windows NT 5.2; U; ru) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(435, "Opera/9.80 (Windows NT 5.1; U;) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(436, "Opera/9.80 (Windows NT 5.1; U; cs) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(437,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.13) Gecko/20101213 Opera/9.80 (Windows NT 6.1; U; zh-tw) Presto/2.7.62 Version/11.01");
            UseragentsDictionary.TryAdd(438,
                "Mozilla/5.0 (Windows NT 6.1; U; nl; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.01");
            UseragentsDictionary.TryAdd(439,
                "Mozilla/5.0 (Windows NT 6.1; U; de; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.01");
            UseragentsDictionary.TryAdd(440, "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; de) Opera 11.01");
            UseragentsDictionary.TryAdd(441, "Opera/9.80 (X11; Linux x86_64; U; pl) Presto/2.7.62 Version/11.00");
            UseragentsDictionary.TryAdd(442, "Opera/9.80 (X11; Linux i686; U; it) Presto/2.7.62 Version/11.00");
            UseragentsDictionary.TryAdd(443, "Opera/9.80 (Windows NT 6.1; U; zh-cn) Presto/2.6.37 Version/11.00");
            UseragentsDictionary.TryAdd(444, "Opera/9.80 (Windows NT 6.1; U; pl) Presto/2.7.62 Version/11.00");
            UseragentsDictionary.TryAdd(445, "Opera/9.80 (Windows NT 6.1; U; ko) Presto/2.7.62 Version/11.00");
            UseragentsDictionary.TryAdd(446, "Opera/9.80 (Windows NT 6.1; U; fi) Presto/2.7.62 Version/11.00");
            UseragentsDictionary.TryAdd(447, "Opera/9.80 (Windows NT 6.1; U; en-GB) Presto/2.7.62 Version/11.00");
            UseragentsDictionary.TryAdd(448, "Opera/9.80 (Windows NT 6.1 x64; U; en) Presto/2.7.62 Version/11.00");
            UseragentsDictionary.TryAdd(449, "Opera/9.80 (Windows NT 6.0; U; en) Presto/2.7.39 Version/11.00");
            UseragentsDictionary.TryAdd(450, "Opera/9.80 (Windows NT 5.1; U; ru) Presto/2.7.39 Version/11.00");
            UseragentsDictionary.TryAdd(451,
                "Opera/9.80 (Windows NT 5.1; U; MRA 5.5 (build 02842); ru) Presto/2.7.62 Version/11.00");
            UseragentsDictionary.TryAdd(452, "Opera/9.80 (Windows NT 5.1; U; it) Presto/2.7.62 Version/11.00");
            UseragentsDictionary.TryAdd(453,
                "Mozilla/5.0 (Windows NT 6.0; U; ja; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.00");
            UseragentsDictionary.TryAdd(454,
                "Mozilla/5.0 (Windows NT 5.1; U; pl; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.00");
            UseragentsDictionary.TryAdd(455,
                "Mozilla/5.0 (Windows NT 5.1; U; de; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.00");
            UseragentsDictionary.TryAdd(456, "Mozilla/4.0 (compatible; MSIE 8.0; X11; Linux x86_64; pl) Opera 11.00");
            UseragentsDictionary.TryAdd(457, "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; fr) Opera 11.00");
            UseragentsDictionary.TryAdd(458, "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; ja) Opera 11.00");
            UseragentsDictionary.TryAdd(459, "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; en) Opera 11.00");
            UseragentsDictionary.TryAdd(460, "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; pl) Opera 11.00");
            UseragentsDictionary.TryAdd(461, "Opera/9.80 (Windows NT 6.1; U; pl) Presto/2.6.31 Version/10.70");
            UseragentsDictionary.TryAdd(462,
                "Mozilla/5.0 (Windows NT 5.2; U; ru; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.70");
            UseragentsDictionary.TryAdd(463,
                "Mozilla/5.0 (Windows NT 5.1; U; zh-cn; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.70");
            UseragentsDictionary.TryAdd(464, "Opera/9.80 (Windows NT 5.2; U; zh-cn) Presto/2.6.30 Version/10.63");
            UseragentsDictionary.TryAdd(465, "Opera/9.80 (Windows NT 5.2; U; en) Presto/2.6.30 Version/10.63");
            UseragentsDictionary.TryAdd(466,
                "Opera/9.80 (Windows NT 5.1; U; MRA 5.6 (build 03278); ru) Presto/2.6.30 Version/10.63");
            UseragentsDictionary.TryAdd(467, "Opera/9.80 (Windows NT 5.1; U; pl) Presto/2.6.30 Version/10.62");
            UseragentsDictionary.TryAdd(468,
                "Mozilla/5.0 (X11; Linux x86_64; U; de; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.62");
            UseragentsDictionary.TryAdd(469, "Mozilla/4.0 (compatible; MSIE 8.0; X11; Linux x86_64; de) Opera 10.62");
            UseragentsDictionary.TryAdd(470, "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; en) Opera 10.62");
            UseragentsDictionary.TryAdd(471, "Opera/9.80 (X11; Linux i686; U; pl) Presto/2.6.30 Version/10.61");
            UseragentsDictionary.TryAdd(472, "Opera/9.80 (X11; Linux i686; U; es-ES) Presto/2.6.30 Version/10.61");
            UseragentsDictionary.TryAdd(473, "Opera/9.80 (Windows NT 6.1; U; zh-cn) Presto/2.6.30 Version/10.61");
            UseragentsDictionary.TryAdd(474, "Opera/9.80 (Windows NT 6.1; U; en) Presto/2.6.30 Version/10.61");
            UseragentsDictionary.TryAdd(475, "Opera/9.80 (Windows NT 6.0; U; it) Presto/2.6.30 Version/10.61");
            UseragentsDictionary.TryAdd(476, "Opera/9.80 (Windows NT 5.2; U; ru) Presto/2.6.30 Version/10.61");
            UseragentsDictionary.TryAdd(477, "Opera/9.80 (Windows 98; U; de) Presto/2.6.30 Version/10.61");
            UseragentsDictionary.TryAdd(478, "Opera/9.80 (Macintosh; Intel Mac OS X; U; nl) Presto/2.6.30 Version/10.61");
            UseragentsDictionary.TryAdd(479, "Opera/9.80 (X11; Linux i686; U; en) Presto/2.5.27 Version/10.60");
            UseragentsDictionary.TryAdd(480, "Opera/9.80 (Windows NT 6.0; U; nl) Presto/2.6.30 Version/10.60");
            UseragentsDictionary.TryAdd(481, "Opera/10.60 (Windows NT 5.1; U; zh-cn) Presto/2.6.30 Version/10.60");
            UseragentsDictionary.TryAdd(482, "Opera/10.60 (Windows NT 5.1; U; en-US) Presto/2.6.30 Version/10.60");
            UseragentsDictionary.TryAdd(483, "Opera/9.80 (X11; Linux i686; U; it) Presto/2.5.24 Version/10.54");
            UseragentsDictionary.TryAdd(484, "Opera/9.80 (X11; Linux i686; U; en-GB) Presto/2.5.24 Version/10.53");
            UseragentsDictionary.TryAdd(485,
                "Mozilla/5.0 (Windows NT 5.1; U; zh-cn; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.53");
            UseragentsDictionary.TryAdd(486,
                "Mozilla/5.0 (Windows NT 5.1; U; Firefox/5.0; en; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.53");
            UseragentsDictionary.TryAdd(487,
                "Mozilla/5.0 (Windows NT 5.1; U; Firefox/4.5; en; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.53");
            UseragentsDictionary.TryAdd(488,
                "Mozilla/5.0 (Windows NT 5.1; U; Firefox/3.5; en; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.53");
            UseragentsDictionary.TryAdd(489, "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; ko) Opera 10.53");
            UseragentsDictionary.TryAdd(490, "Opera/9.80 (Windows NT 6.1; U; fr) Presto/2.5.24 Version/10.52");
            UseragentsDictionary.TryAdd(491, "Opera/9.80 (Windows NT 6.1; U; en) Presto/2.5.22 Version/10.51");
            UseragentsDictionary.TryAdd(492, "Opera/9.80 (Windows NT 6.0; U; cs) Presto/2.5.22 Version/10.51");
            UseragentsDictionary.TryAdd(493, "Opera/9.80 (Windows NT 5.2; U; ru) Presto/2.5.22 Version/10.51");
            UseragentsDictionary.TryAdd(494, "Opera/9.80 (Linux i686; U; en) Presto/2.5.22 Version/10.51");
            UseragentsDictionary.TryAdd(495,
                "Mozilla/5.0 (Windows NT 6.1; U; en-GB; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.51");
            UseragentsDictionary.TryAdd(496,
                "Mozilla/5.0 (Linux i686; U; en; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.51");
            UseragentsDictionary.TryAdd(497, "Mozilla/4.0 (compatible; MSIE 8.0; Linux i686; en) Opera 10.51");
            UseragentsDictionary.TryAdd(498, "Opera/9.80 (Windows NT 6.1; U; zh-tw) Presto/2.5.22 Version/10.50");
            UseragentsDictionary.TryAdd(499, "Opera/9.80 (Windows NT 6.1; U; zh-cn) Presto/2.5.22 Version/10.50");
            UseragentsDictionary.TryAdd(500, "Opera/9.80 (Windows NT 6.1; U; sk) Presto/2.6.22 Version/10.50");
            UseragentsDictionary.TryAdd(501, "Opera/9.80 (Windows NT 6.1; U; ja) Presto/2.5.22 Version/10.50");
            UseragentsDictionary.TryAdd(502, "Opera/9.80 (Windows NT 6.0; U; zh-cn) Presto/2.5.22 Version/10.50");
            UseragentsDictionary.TryAdd(503, "Opera/9.80 (Windows NT 5.1; U; sk) Presto/2.5.22 Version/10.50");
            UseragentsDictionary.TryAdd(504, "Opera/9.80 (Windows NT 5.1; U; ru) Presto/2.5.22 Version/10.50");
            UseragentsDictionary.TryAdd(505, "Opera/10.50 (Windows NT 6.1; U; en-GB) Presto/2.2.2");
            UseragentsDictionary.TryAdd(506,
                "Opera/9.80 (S60; SymbOS; Opera Tablet/9174; U; en) Presto/2.7.81 Version/10.5");
            UseragentsDictionary.TryAdd(507,
                "Opera/9.80 (X11; U; Linux i686; en-US; rv:1.9.2.3) Presto/2.2.15 Version/10.10");
            UseragentsDictionary.TryAdd(508, "Opera/9.80 (X11; Linux x86_64; U; it) Presto/2.2.15 Version/10.10");
            UseragentsDictionary.TryAdd(509, "Opera/9.80 (Windows NT 6.1; U; de) Presto/2.2.15 Version/10.10");
            UseragentsDictionary.TryAdd(510,
                "Opera/9.80 (Windows NT 6.0; U; Gecko/20100115; pl) Presto/2.2.15 Version/10.10");
            UseragentsDictionary.TryAdd(511, "Opera/9.80 (Windows NT 6.0; U; en) Presto/2.2.15 Version/10.10");
            UseragentsDictionary.TryAdd(512, "Opera/9.80 (Windows NT 5.1; U; de) Presto/2.2.15 Version/10.10");
            UseragentsDictionary.TryAdd(513, "Opera/9.80 (Windows NT 5.1; U; cs) Presto/2.2.15 Version/10.10");
            UseragentsDictionary.TryAdd(514,
                "Mozilla/5.0 (Windows NT 6.0; U; tr; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 10.10");
            UseragentsDictionary.TryAdd(515, "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686; de) Opera 10.10");
            UseragentsDictionary.TryAdd(516, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 6.0; tr) Opera 10.10");
            UseragentsDictionary.TryAdd(517, "Opera/9.80 (X11; Linux x86_64; U; en-GB) Presto/2.2.15 Version/10.01");
            UseragentsDictionary.TryAdd(518, "Opera/9.80 (X11; Linux x86_64; U; en) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(519, "Opera/9.80 (X11; Linux x86_64; U; de) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(520, "Opera/9.80 (X11; Linux i686; U; ru) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(521, "Opera/9.80 (X11; Linux i686; U; pt-BR) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(522, "Opera/9.80 (X11; Linux i686; U; pl) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(523, "Opera/9.80 (X11; Linux i686; U; nb) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(524, "Opera/9.80 (X11; Linux i686; U; en-GB) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(525, "Opera/9.80 (X11; Linux i686; U; en) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(526, "Opera/9.80 (X11; Linux i686; U; Debian; pl) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(527, "Opera/9.80 (X11; Linux i686; U; de) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(528, "Opera/9.80 (Windows NT 6.1; U; zh-cn) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(529, "Opera/9.80 (Windows NT 6.1; U; fi) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(530, "Opera/9.80 (Windows NT 6.1; U; en) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(531, "Opera/9.80 (Windows NT 6.1; U; de) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(532, "Opera/9.80 (Windows NT 6.1; U; cs) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(533, "Opera/9.80 (Windows NT 6.0; U; en) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(534, "Opera/9.80 (Windows NT 6.0; U; de) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(535, "Opera/9.80 (Windows NT 5.2; U; en) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(536, "Opera/9.80 (Windows NT 5.1; U; zh-cn) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(537, "Opera/9.80 (Windows NT 5.1; U; ru) Presto/2.2.15 Version/10.00");
            UseragentsDictionary.TryAdd(538, "Opera/9.99 (Windows NT 5.1; U; pl) Presto/9.9.9");
            UseragentsDictionary.TryAdd(539,
                "Opera/9.80 (J2ME/MIDP; Opera Mini/5.0 (Windows; U; Windows NT 5.1; en) AppleWebKit/886; U; en) Presto/2.4.15");
            UseragentsDictionary.TryAdd(540, "Opera/9.70 (Linux ppc64 ; U; en) Presto/2.2.1");
            UseragentsDictionary.TryAdd(541, "Opera/9.70 (Linux i686 ; U; zh-cn) Presto/2.2.0");
            UseragentsDictionary.TryAdd(542, "Opera/9.70 (Linux i686 ; U; en-us) Presto/2.2.0");
            UseragentsDictionary.TryAdd(543, "Opera/9.70 (Linux i686 ; U; en) Presto/2.2.1");
            UseragentsDictionary.TryAdd(544, "Opera/9.70 (Linux i686 ; U; en) Presto/2.2.0");
            UseragentsDictionary.TryAdd(545, "Opera/9.70 (Linux i686 ; U; ; en) Presto/2.2.1");
            UseragentsDictionary.TryAdd(546, "Opera/9.70 (Linux i686 ; U; ; en) Presto/2.2.1");
            UseragentsDictionary.TryAdd(547,
                "Mozilla/5.0 (Linux i686 ; U; en; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.70");
            UseragentsDictionary.TryAdd(548, "Mozilla/4.0 (compatible; MSIE 6.0; Linux i686 ; en) Opera 9.70");
            UseragentsDictionary.TryAdd(549, "HTC_HD2_T8585 Opera/9.70 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(550, "Opera 9.7 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(551, "Opera/9.64(Windows NT 5.1; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(552, "Opera/9.64 (X11; Linux x86_64; U; pl) Presto/2.1.1");
            UseragentsDictionary.TryAdd(553, "Opera/9.64 (X11; Linux x86_64; U; hr) Presto/2.1.1");
            UseragentsDictionary.TryAdd(554, "Opera/9.64 (X11; Linux x86_64; U; en-GB) Presto/2.1.1");
            UseragentsDictionary.TryAdd(555, "Opera/9.64 (X11; Linux x86_64; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(556, "Opera/9.64 (X11; Linux x86_64; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(557, "Opera/9.64 (X11; Linux x86_64; U; cs) Presto/2.1.1");
            UseragentsDictionary.TryAdd(558, "Opera/9.64 (X11; Linux i686; U; tr) Presto/2.1.1");
            UseragentsDictionary.TryAdd(559, "Opera/9.64 (X11; Linux i686; U; sv) Presto/2.1.1");
            UseragentsDictionary.TryAdd(560, "Opera/9.64 (X11; Linux i686; U; pl) Presto/2.1.1");
            UseragentsDictionary.TryAdd(561, "Opera/9.64 (X11; Linux i686; U; nb) Presto/2.1.1");
            UseragentsDictionary.TryAdd(562, "Opera/9.64 (X11; Linux i686; U; Linux Mint; nb) Presto/2.1.1");
            UseragentsDictionary.TryAdd(563, "Opera/9.64 (X11; Linux i686; U; Linux Mint; it) Presto/2.1.1");
            UseragentsDictionary.TryAdd(564, "Opera/9.64 (X11; Linux i686; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(565, "Opera/9.64 (X11; Linux i686; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(566, "Opera/9.64 (X11; Linux i686; U; da) Presto/2.1.1");
            UseragentsDictionary.TryAdd(567, "Opera/9.64 (Windows NT 6.1; U; MRA 5.5 (build 02842); ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(568, "Opera/9.64 (Windows NT 6.1; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(569, "Opera/9.64 (Windows NT 6.0; U; zh-cn) Presto/2.1.1");
            UseragentsDictionary.TryAdd(570, "Opera/9.64 (Windows NT 6.0; U; pl) Presto/2.1.1");
            UseragentsDictionary.TryAdd(571, "Opera/9.63 (X11; Linux x86_64; U; ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(572, "Opera/9.63 (X11; Linux x86_64; U; cs) Presto/2.1.1");
            UseragentsDictionary.TryAdd(573, "Opera/9.63 (X11; Linux i686; U; ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(574, "Opera/9.63 (X11; Linux i686; U; ru)");
            UseragentsDictionary.TryAdd(575, "Opera/9.63 (X11; Linux i686; U; nb) Presto/2.1.1");
            UseragentsDictionary.TryAdd(576, "Opera/9.63 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(577, "Opera/9.63 (X11; Linux i686; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(578, "Opera/9.63 (X11; Linux i686)");
            UseragentsDictionary.TryAdd(579, "Opera/9.63 (X11; FreeBSD 7.1-RELEASE i386; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(580, "Opera/9.63 (Windows NT 6.1; U; hu) Presto/2.1.1");
            UseragentsDictionary.TryAdd(581, "Opera/9.63 (Windows NT 6.1; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(582, "Opera/9.63 (Windows NT 6.1; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(583, "Opera/9.63 (Windows NT 6.0; U; pl) Presto/2.1.1");
            UseragentsDictionary.TryAdd(584, "Opera/9.63 (Windows NT 6.0; U; nb) Presto/2.1.1");
            UseragentsDictionary.TryAdd(585, "Opera/9.63 (Windows NT 6.0; U; fr) Presto/2.1.1");
            UseragentsDictionary.TryAdd(586, "Opera/9.63 (Windows NT 6.0; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(587, "Opera/9.63 (Windows NT 6.0; U; cs) Presto/2.1.1");
            UseragentsDictionary.TryAdd(588, "Opera/9.63 (Windows NT 5.2; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(589, "Opera/9.63 (Windows NT 5.2; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(590, "Opera/9.63 (Windows NT 5.1; U; pt-BR) Presto/2.1.1");
            UseragentsDictionary.TryAdd(591, "Opera/9.62 (X11; Linux x86_64; U; ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(592, "Opera/9.62 (X11; Linux i686; U; pt-BR) Presto/2.1.1");
            UseragentsDictionary.TryAdd(593, "Opera/9.62 (X11; Linux i686; U; Linux Mint; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(594, "Opera/9.62 (X11; Linux i686; U; it) Presto/2.1.1");
            UseragentsDictionary.TryAdd(595, "Opera/9.62 (X11; Linux i686; U; fi) Presto/2.1.1");
            UseragentsDictionary.TryAdd(596, "Opera/9.62 (X11; Linux i686; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(597, "Opera/9.62 (Windows NT 6.1; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(598, "Opera/9.62 (Windows NT 6.1; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(599, "Opera/9.62 (Windows NT 6.0; U; pl) Presto/2.1.1");
            UseragentsDictionary.TryAdd(600, "Opera/9.62 (Windows NT 6.0; U; nb) Presto/2.1.1");
            UseragentsDictionary.TryAdd(601, "Opera/9.62 (Windows NT 6.0; U; en-GB) Presto/2.1.1");
            UseragentsDictionary.TryAdd(602, "Opera/9.62 (Windows NT 6.0; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(603, "Opera/9.62 (Windows NT 6.0; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(604, "Opera/9.62 (Windows NT 5.2; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(605, "Opera/9.62 (Windows NT 5.1; U; zh-tw) Presto/2.1.1");
            UseragentsDictionary.TryAdd(606, "Opera/9.62 (Windows NT 5.1; U; zh-cn) Presto/2.1.1");
            UseragentsDictionary.TryAdd(607, "Opera/9.62 (Windows NT 5.1; U; tr) Presto/2.1.1");
            UseragentsDictionary.TryAdd(608, "Opera/9.62 (Windows NT 5.1; U; ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(609, "Opera/9.62 (Windows NT 5.1; U; pt-BR) Presto/2.1.1");
            UseragentsDictionary.TryAdd(610, "Opera/9.62 (Windows NT 5.1; U; pl) Presto/2.1.1");
            UseragentsDictionary.TryAdd(611, "Opera/9.61 (X11; Linux x86_64; U; fr) Presto/2.1.1");
            UseragentsDictionary.TryAdd(612, "Opera/9.61 (X11; Linux i686; U; ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(613, "Opera/9.61 (X11; Linux i686; U; pl) Presto/2.1.1");
            UseragentsDictionary.TryAdd(614, "Opera/9.61 (X11; Linux i686; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(615, "Opera/9.61 (X11; Linux i686; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(616, "Opera/9.61 (Windows NT 6.0; U; ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(617, "Opera/9.61 (Windows NT 6.0; U; pt-BR) Presto/2.1.1");
            UseragentsDictionary.TryAdd(618, "Opera/9.61 (Windows NT 6.0; U; http://lucideer.com; en-GB) Presto/2.1.1");
            UseragentsDictionary.TryAdd(619, "Opera/9.61 (Windows NT 6.0; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(620, "Opera/9.61 (Windows NT 5.2; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(621, "Opera/9.61 (Windows NT 5.1; U; zh-tw) Presto/2.1.1");
            UseragentsDictionary.TryAdd(622, "Opera/9.61 (Windows NT 5.1; U; zh-cn) Presto/2.1.1");
            UseragentsDictionary.TryAdd(623, "Opera/9.61 (Windows NT 5.1; U; ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(624, "Opera/9.61 (Windows NT 5.1; U; fr) Presto/2.1.1");
            UseragentsDictionary.TryAdd(625, "Opera/9.61 (Windows NT 5.1; U; en-GB) Presto/2.1.1");
            UseragentsDictionary.TryAdd(626, "Opera/9.61 (Windows NT 5.1; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(627, "Opera/9.61 (Windows NT 5.1; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(628, "Opera/9.61 (Windows NT 5.1; U; cs) Presto/2.1.1");
            UseragentsDictionary.TryAdd(629, "Opera/9.61 (Macintosh; Intel Mac OS X; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(630,
                "Mozilla/5.0 (Windows NT 5.1; U; en-GB; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.61");
            UseragentsDictionary.TryAdd(631, "Opera/9.60 (X11; Linux x86_64; U)");
            UseragentsDictionary.TryAdd(632, "Opera/9.60 (X11; Linux i686; U; ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(633, "Opera/9.60 (X11; Linux i686; U; en-GB) Presto/2.1.1");
            UseragentsDictionary.TryAdd(634, "Opera/9.60 (Windows NT 6.0; U; uk) Presto/2.1.1");
            UseragentsDictionary.TryAdd(635, "Opera/9.60 (Windows NT 6.0; U; ru) Presto/2.1.1");
            UseragentsDictionary.TryAdd(636, "Opera/9.60 (Windows NT 6.0; U; pl) Presto/2.1.1");
            UseragentsDictionary.TryAdd(637, "Opera/9.60 (Windows NT 6.0; U; de) Presto/2.1.1");
            UseragentsDictionary.TryAdd(638, "Opera/9.60 (Windows NT 6.0; U; bg) Presto/2.1.1");
            UseragentsDictionary.TryAdd(639, "Opera/9.60 (Windows NT 5.1; U; tr) Presto/2.1.1");
            UseragentsDictionary.TryAdd(640, "Opera/9.60 (Windows NT 5.1; U; sv) Presto/2.1.1");
            UseragentsDictionary.TryAdd(641, "Opera/9.60 (Windows NT 5.1; U; es-ES) Presto/2.1.1");
            UseragentsDictionary.TryAdd(642, "Opera/9.60 (Windows NT 5.1; U; en-GB) Presto/2.1.1");
            UseragentsDictionary.TryAdd(643, "Opera/9.60 (Windows NT 5.0; U; en) Presto/2.1.1");
            UseragentsDictionary.TryAdd(644,
                "Mozilla/5.0 (X11; Linux x86_64; U; en; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.60");
            UseragentsDictionary.TryAdd(645, "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux x86_64; en) Opera 9.60");
            UseragentsDictionary.TryAdd(646, "Opera/9.52 (X11; Linux x86_64; U; ru)");
            UseragentsDictionary.TryAdd(647, "Opera/9.52 (X11; Linux x86_64; U; en)");
            UseragentsDictionary.TryAdd(648, "Opera/9.52 (X11; Linux x86_64; U)");
            UseragentsDictionary.TryAdd(649, "Opera/9.52 (X11; Linux ppc; U; de)");
            UseragentsDictionary.TryAdd(650, "Opera/9.52 (X11; Linux i686; U; fr)");
            UseragentsDictionary.TryAdd(651, "Opera/9.52 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(652, "Opera/9.52 (X11; Linux i686; U; cs)");
            UseragentsDictionary.TryAdd(653, "Opera/9.52 (Windows NT 6.0; U; Opera/9.52 (X11; Linux x86_64; U); en)");
            UseragentsDictionary.TryAdd(654, "Opera/9.52 (Windows NT 6.0; U; fr)");
            UseragentsDictionary.TryAdd(655, "Opera/9.52 (Windows NT 6.0; U; en)");
            UseragentsDictionary.TryAdd(656, "Opera/9.52 (Windows NT 6.0; U; de)");
            UseragentsDictionary.TryAdd(657, "Opera/9.52 (Windows NT 5.2; U; ru)");
            UseragentsDictionary.TryAdd(658, "Opera/9.52 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(659, "Opera/9.52 (Macintosh; PPC Mac OS X; U; ja)");
            UseragentsDictionary.TryAdd(660, "Opera/9.52 (Macintosh; PPC Mac OS X; U; fr)");
            UseragentsDictionary.TryAdd(661, "Opera/9.52 (Macintosh; Intel Mac OS X; U; pt-BR)");
            UseragentsDictionary.TryAdd(662, "Opera/9.52 (Macintosh; Intel Mac OS X; U; pt)");
            UseragentsDictionary.TryAdd(663,
                "Mozilla/5.0 (Windows NT 5.1; U; de; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.52");
            UseragentsDictionary.TryAdd(664,
                "Mozilla/5.0 (Windows NT 5.1; U; ; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.52");
            UseragentsDictionary.TryAdd(665, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; ru) Opera 9.52");
            UseragentsDictionary.TryAdd(666, "Opera/9.51 (X11; Linux i686; U; Linux Mint; en)");
            UseragentsDictionary.TryAdd(667, "Opera/9.51 (X11; Linux i686; U; fr)");
            UseragentsDictionary.TryAdd(668, "Opera/9.51 (X11; Linux i686; U; de)");
            UseragentsDictionary.TryAdd(669, "Opera/9.51 (Windows NT 6.0; U; sv)");
            UseragentsDictionary.TryAdd(670, "Opera/9.51 (Windows NT 6.0; U; es)");
            UseragentsDictionary.TryAdd(671, "Opera/9.51 (Windows NT 6.0; U; en)");
            UseragentsDictionary.TryAdd(672, "Opera/9.51 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(673, "Opera/9.51 (Windows NT 5.1; U; nn)");
            UseragentsDictionary.TryAdd(674, "Opera/9.51 (Windows NT 5.1; U; fr)");
            UseragentsDictionary.TryAdd(675, "Opera/9.51 (Windows NT 5.1; U; es-LA)");
            UseragentsDictionary.TryAdd(676, "Opera/9.51 (Windows NT 5.1; U; es-AR)");
            UseragentsDictionary.TryAdd(677, "Opera/9.51 (Windows NT 5.1; U; en-GB)");
            UseragentsDictionary.TryAdd(678, "Opera/9.51 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(679, "Opera/9.51 (Windows NT 5.1; U; da)");
            UseragentsDictionary.TryAdd(680, "Opera/9.51 (Macintosh; Intel Mac OS X; U; en)");
            UseragentsDictionary.TryAdd(681,
                "Mozilla/5.0 (X11; Linux i686; U; en; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.51");
            UseragentsDictionary.TryAdd(682,
                "Mozilla/5.0 (Windows NT 6.0; U; en; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.51");
            UseragentsDictionary.TryAdd(683,
                "Mozilla/5.0 (Windows NT 5.1; U; en; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.51");
            UseragentsDictionary.TryAdd(684,
                "Mozilla/5.0 (Windows NT 5.1; U; en-GB; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.51");
            UseragentsDictionary.TryAdd(685,
                "Mozilla/5.0 (Windows NT 5.1; U; de; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.51");
            UseragentsDictionary.TryAdd(686, "Opera/9.50 (X11; Linux x86_64; U; pl)");
            UseragentsDictionary.TryAdd(687, "Opera/9.50 (X11; Linux x86_64; U; nb)");
            UseragentsDictionary.TryAdd(688, "Opera/9.50 (X11; Linux ppc; U; en)");
            UseragentsDictionary.TryAdd(689, "Opera/9.50 (X11; Linux i686; U; es-ES)");
            UseragentsDictionary.TryAdd(690, "Opera/9.50 (Windows NT 5.2; U; it)");
            UseragentsDictionary.TryAdd(691, "Opera/9.50 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(692, "Opera/9.50 (Windows NT 5.1; U; nn)");
            UseragentsDictionary.TryAdd(693, "Opera/9.50 (Windows NT 5.1; U; nl)");
            UseragentsDictionary.TryAdd(694, "Opera/9.50 (Windows NT 5.1; U; it)");
            UseragentsDictionary.TryAdd(695, "Opera/9.50 (Windows NT 5.1; U; es-ES)");
            UseragentsDictionary.TryAdd(696, "Opera/9.50 (Macintosh; Intel Mac OS X; U; en)");
            UseragentsDictionary.TryAdd(697, "Opera/9.50 (Macintosh; Intel Mac OS X; U; de)");
            UseragentsDictionary.TryAdd(698,
                "Mozilla/5.0 (Windows NT 5.1; U; zh-cn; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.50");
            UseragentsDictionary.TryAdd(699, "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux x86_64; en) Opera 9.50");
            UseragentsDictionary.TryAdd(700, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 6.0; en) Opera 9.50");
            UseragentsDictionary.TryAdd(701, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; en) Opera 9.50");
            UseragentsDictionary.TryAdd(702, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; de) Opera 9.50");
            UseragentsDictionary.TryAdd(703, "Opera/9.5 (Windows NT 6.0; U; en)");
            UseragentsDictionary.TryAdd(704, "Opera/9.5 (Windows NT 5.1; U; fr)");
            UseragentsDictionary.TryAdd(705,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; de; rv:1.9b3) Gecko/2008020514 Opera 9.5");
            UseragentsDictionary.TryAdd(706, "Opera 9.4 (Windows NT 6.1; U; en)");
            UseragentsDictionary.TryAdd(707, "Opera 9.4 (Windows NT 5.3; U; en)");
            UseragentsDictionary.TryAdd(708, "Opera/9.30 (Nintendo Wii; U; ; 2071; Wii Shop Channel/1.0; en)");
            UseragentsDictionary.TryAdd(709, "Opera/9.30 (Nintendo Wii; U; ; 2047-7;pt-br)");
            UseragentsDictionary.TryAdd(710, "Opera/9.30 (Nintendo Wii; U; ; 2047-7;es)");
            UseragentsDictionary.TryAdd(711, "Opera/9.30 (Nintendo Wii; U; ; 2047-7;en)");
            UseragentsDictionary.TryAdd(712, "Opera/9.30 (Nintendo Wii; U; ; 2047-7; fr)");
            UseragentsDictionary.TryAdd(713, "Opera/9.30 (Nintendo Wii; U; ; 2047-7; de)");
            UseragentsDictionary.TryAdd(714, "Opera/9.27 (X11; Linux i686; U; fr)");
            UseragentsDictionary.TryAdd(715, "Opera/9.27 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(716, "Opera/9.27 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(717, "Opera/9.27 (Windows NT 5.1; U; ja)");
            UseragentsDictionary.TryAdd(718, "Opera/9.27 (Macintosh; Intel Mac OS X; U; sv)");
            UseragentsDictionary.TryAdd(719,
                "Mozilla/5.0 (Windows NT 5.2; U; en; rv:1.8.0) Gecko/20060728 Firefox/1.5.0 Opera 9.27");
            UseragentsDictionary.TryAdd(720,
                "Mozilla/5.0 (Windows NT 5.1; U; es-la; rv:1.8.0) Gecko/20060728 Firefox/1.5.0 Opera 9.27");
            UseragentsDictionary.TryAdd(721,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X; U; en; rv:1.8.0) Gecko/20060728 Firefox/1.5.0 Opera 9.27");
            UseragentsDictionary.TryAdd(722, "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686; en) Opera 9.27");
            UseragentsDictionary.TryAdd(723, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; en) Opera 9.27");
            UseragentsDictionary.TryAdd(724, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; es-la) Opera 9.27");
            UseragentsDictionary.TryAdd(725, "Opera/9.26 (Windows NT 5.1; U; zh-cn)");
            UseragentsDictionary.TryAdd(726, "Opera/9.26 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(727, "Opera/9.26 (Windows NT 5.1; U; nl)");
            UseragentsDictionary.TryAdd(728, "Opera/9.26 (Windows NT 5.1; U; MEGAUPLOAD 2.0; en)");
            UseragentsDictionary.TryAdd(729, "Opera/9.26 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(730, "Opera/9.26 (Macintosh; PPC Mac OS X; U; en)");
            UseragentsDictionary.TryAdd(731,
                "Mozilla/5.0 (Windows NT 5.1; U; en; rv:1.8.0) Gecko/20060728 Firefox/1.5.0 Opera 9.26");
            UseragentsDictionary.TryAdd(732, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 6.0; en) Opera 9.26");
            UseragentsDictionary.TryAdd(733, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; en) Opera 9.26");
            UseragentsDictionary.TryAdd(734, "Opera/9.25 (X11; Linux i686; U; fr-ca)");
            UseragentsDictionary.TryAdd(735, "Opera/9.25 (X11; Linux i686; U; fr)");
            UseragentsDictionary.TryAdd(736, "Opera/9.25 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(737, "Opera/9.25 (Windows NT 6.0; U; SV1; MEGAUPLOAD 2.0; ru)");
            UseragentsDictionary.TryAdd(738, "Opera/9.25 (Windows NT 6.0; U; sv)");
            UseragentsDictionary.TryAdd(739, "Opera/9.25 (Windows NT 6.0; U; ru)");
            UseragentsDictionary.TryAdd(740, "Opera/9.25 (Windows NT 6.0; U; MEGAUPLOAD 1.0; ru)");
            UseragentsDictionary.TryAdd(741, "Opera/9.25 (Windows NT 6.0; U; en-US)");
            UseragentsDictionary.TryAdd(742, "Opera/9.25 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(743, "Opera/9.25 (Windows NT 5.1; U; zh-cn)");
            UseragentsDictionary.TryAdd(744, "Opera/9.25 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(745, "Opera/9.25 (Windows NT 5.1; U; MEGAUPLOAD 1.0; pt-br)");
            UseragentsDictionary.TryAdd(746, "Opera/9.25 (Windows NT 5.1; U; lt)");
            UseragentsDictionary.TryAdd(747, "Opera/9.25 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(748, "Opera/9.25 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(749, "Opera/9.25 (Windows NT 5.0; U; cs)");
            UseragentsDictionary.TryAdd(750, "Opera/9.25 (Windows NT 4.0; U; en)");
            UseragentsDictionary.TryAdd(751, "Opera/9.25 (OpenSolaris; U; en)");
            UseragentsDictionary.TryAdd(752, "Opera/9.25 (Macintosh; PPC Mac OS X; U; en)");
            UseragentsDictionary.TryAdd(753, "Opera/9.25 (Macintosh; Intel Mac OS X; U; en)");
            UseragentsDictionary.TryAdd(754, "Opera/9.24 (X11; SunOS i86pc; U; en)");
            UseragentsDictionary.TryAdd(755, "Opera/9.24 (X11; Linux i686; U; de)");
            UseragentsDictionary.TryAdd(756, "Opera/9.24 (Windows NT 5.1; U; tr)");
            UseragentsDictionary.TryAdd(757, "Opera/9.24 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(758, "Opera/9.24 (Windows NT 5.0; U; ru)");
            UseragentsDictionary.TryAdd(759, "Opera/9.24 (Macintosh; PPC Mac OS X; U; en)");
            UseragentsDictionary.TryAdd(760,
                "Mozilla/5.0 (Windows NT 5.1; U; en; rv:1.8.0) Gecko/20060728 Firefox/1.5.0 Opera 9.24");
            UseragentsDictionary.TryAdd(761, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; en) Opera 9.24");
            UseragentsDictionary.TryAdd(762, "Mozilla/4.0 (compatible; MSIE 6.0; Mac_PowerPC; en) Opera 9.24");
            UseragentsDictionary.TryAdd(763, "Opera/9.23 (X11; Linux x86_64; U; en)");
            UseragentsDictionary.TryAdd(764, "Opera/9.23 (X11; Linux i686; U; es-es)");
            UseragentsDictionary.TryAdd(765, "Opera/9.23 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(766, "Opera/9.23 (Windows NT 6.0; U; de)");
            UseragentsDictionary.TryAdd(767, "Opera/9.23 (Windows NT 5.1; U; zh-cn)");
            UseragentsDictionary.TryAdd(768, "Opera/9.23 (Windows NT 5.1; U; SV1; MEGAUPLOAD 1.0; ru)");
            UseragentsDictionary.TryAdd(769, "Opera/9.23 (Windows NT 5.1; U; pt)");
            UseragentsDictionary.TryAdd(770, "Opera/9.23 (Windows NT 5.1; U; ja)");
            UseragentsDictionary.TryAdd(771, "Opera/9.23 (Windows NT 5.1; U; it)");
            UseragentsDictionary.TryAdd(772, "Opera/9.23 (Windows NT 5.1; U; fi)");
            UseragentsDictionary.TryAdd(773, "Opera/9.23 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(774, "Opera/9.23 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(775, "Opera/9.23 (Windows NT 5.1; U; da)");
            UseragentsDictionary.TryAdd(776, "Opera/9.23 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(777, "Opera/9.23 (Windows NT 5.0; U; de)");
            UseragentsDictionary.TryAdd(778, "Opera/9.23 (Nintendo Wii; U; ; 1038-58; Wii Internet Channel/1.0; en)");
            UseragentsDictionary.TryAdd(779, "Opera/9.23 (Macintosh; Intel Mac OS X; U; ja)");
            UseragentsDictionary.TryAdd(780, "Opera/9.23 (Mac OS X; ru)");
            UseragentsDictionary.TryAdd(781, "Opera/9.23 (Mac OS X; fr)");
            UseragentsDictionary.TryAdd(782,
                "Mozilla/5.0 (X11; Linux i686; U; en; rv:1.8.0) Gecko/20060728 Firefox/1.5.0 Opera 9.23");
            UseragentsDictionary.TryAdd(783, "Opera/9.22 (X11; OpenBSD i386; U; en)");
            UseragentsDictionary.TryAdd(784, "Opera/9.22 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(785, "Opera/9.22 (X11; Linux i686; U; de)");
            UseragentsDictionary.TryAdd(786, "Opera/9.22 (Windows NT 6.0; U; ru)");
            UseragentsDictionary.TryAdd(787, "Opera/9.22 (Windows NT 6.0; U; en)");
            UseragentsDictionary.TryAdd(788, "Opera/9.22 (Windows NT 5.1; U; SV1; MEGAUPLOAD 2.0; ru)");
            UseragentsDictionary.TryAdd(789, "Opera/9.22 (Windows NT 5.1; U; SV1; MEGAUPLOAD 1.0; ru)");
            UseragentsDictionary.TryAdd(790, "Opera/9.22 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(791, "Opera/9.22 (Windows NT 5.1; U; fr)");
            UseragentsDictionary.TryAdd(792, "Opera/9.22 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(793,
                "Mozilla/5.0 (Windows NT 5.1; U; en; rv:1.8.0) Gecko/20060728 Firefox/1.5.0 Opera 9.22");
            UseragentsDictionary.TryAdd(794, "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686; en) Opera 9.22");
            UseragentsDictionary.TryAdd(795, "Opera/9.21 (X11; Linux x86_64; U; en)");
            UseragentsDictionary.TryAdd(796, "Opera/9.21 (X11; Linux i686; U; es-es)");
            UseragentsDictionary.TryAdd(797, "Opera/9.21 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(798, "Opera/9.21 (X11; Linux i686; U; de)");
            UseragentsDictionary.TryAdd(799, "Opera/9.21 (Windows NT 6.0; U; nb)");
            UseragentsDictionary.TryAdd(800, "Opera/9.21 (Windows NT 6.0; U; en)");
            UseragentsDictionary.TryAdd(801, "Opera/9.21 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(802, "Opera/9.21 (Windows NT 5.1; U; SV1; MEGAUPLOAD 1.0; ru)");
            UseragentsDictionary.TryAdd(803, "Opera/9.21 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(804, "Opera/9.21 (Windows NT 5.1; U; pt-br)");
            UseragentsDictionary.TryAdd(805, "Opera/9.21 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(806, "Opera/9.21 (Windows NT 5.1; U; nl)");
            UseragentsDictionary.TryAdd(807, "Opera/9.21 (Windows NT 5.1; U; MEGAUPLOAD 1.0; en)");
            UseragentsDictionary.TryAdd(808, "Opera/9.21 (Windows NT 5.1; U; fr)");
            UseragentsDictionary.TryAdd(809, "Opera/9.21 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(810, "Opera/9.21 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(811, "Opera/9.21 (Windows NT 5.0; U; de)");
            UseragentsDictionary.TryAdd(812, "Opera/9.21 (Windows 98; U; en)");
            UseragentsDictionary.TryAdd(813, "Opera/9.21 (Macintosh; PPC Mac OS X; U; en)");
            UseragentsDictionary.TryAdd(814, "Opera/9.21 (Macintosh; Intel Mac OS X; U; en)");
            UseragentsDictionary.TryAdd(815, "Opera/9.20(Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(816, "Opera/9.20 (X11; Linux x86_64; U; en)");
            UseragentsDictionary.TryAdd(817, "Opera/9.20 (X11; Linux ppc; U; en)");
            UseragentsDictionary.TryAdd(818, "Opera/9.20 (X11; Linux i686; U; tr)");
            UseragentsDictionary.TryAdd(819, "Opera/9.20 (X11; Linux i686; U; ru)");
            UseragentsDictionary.TryAdd(820, "Opera/9.20 (X11; Linux i686; U; pl)");
            UseragentsDictionary.TryAdd(821, "Opera/9.20 (X11; Linux i686; U; es-es)");
            UseragentsDictionary.TryAdd(822, "Opera/9.20 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(823, "Opera/9.20 (X11; Linux i586; U; en)");
            UseragentsDictionary.TryAdd(824, "Opera/9.20 (Windows NT 6.0; U; es-es)");
            UseragentsDictionary.TryAdd(825, "Opera/9.20 (Windows NT 6.0; U; en)");
            UseragentsDictionary.TryAdd(826, "Opera/9.20 (Windows NT 6.0; U; de)");
            UseragentsDictionary.TryAdd(827, "Opera/9.20 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(828, "Opera/9.20 (Windows NT 5.1; U; zh-tw)");
            UseragentsDictionary.TryAdd(829, "Opera/9.20 (Windows NT 5.1; U; nb)");
            UseragentsDictionary.TryAdd(830, "Opera/9.20 (Windows NT 5.1; U; MEGAUPLOAD=1.0; es-es)");
            UseragentsDictionary.TryAdd(831, "Opera/9.20 (Windows NT 5.1; U; it)");
            UseragentsDictionary.TryAdd(832, "Opera/9.20 (Windows NT 5.1; U; es-es)");
            UseragentsDictionary.TryAdd(833, "Opera/9.20 (Windows NT 5.1; U; es-AR)");
            UseragentsDictionary.TryAdd(834, "Opera/9.20 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(835, "Opera/9.12 (X11; Linux i686; U; en) (Ubuntu)");
            UseragentsDictionary.TryAdd(836, "Opera/9.12 (Windows NT 5.0; U; ru)");
            UseragentsDictionary.TryAdd(837, "Opera/9.12 (Windows NT 5.0; U)");
            UseragentsDictionary.TryAdd(838, "Opera/9.10 (X11; Linux; U; en)");
            UseragentsDictionary.TryAdd(839, "Opera/9.10 (X11; Linux x86_64; U; en)");
            UseragentsDictionary.TryAdd(840, "Opera/9.10 (X11; Linux i686; U; pl)");
            UseragentsDictionary.TryAdd(841, "Opera/9.10 (X11; Linux i686; U; kubuntu;pl)");
            UseragentsDictionary.TryAdd(842, "Opera/9.10 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(843, "Opera/9.10 (X11; Linux i386; U; en)");
            UseragentsDictionary.TryAdd(844, "Opera/9.10 (Windows NT 6.0; U; it-IT)");
            UseragentsDictionary.TryAdd(845, "Opera/9.10 (Windows NT 6.0; U; en)");
            UseragentsDictionary.TryAdd(846, "Opera/9.10 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(847, "Opera/9.10 (Windows NT 5.2; U; de)");
            UseragentsDictionary.TryAdd(848, "Opera/9.10 (Windows NT 5.1; U; zh-tw)");
            UseragentsDictionary.TryAdd(849, "Opera/9.10 (Windows NT 5.1; U; sv)");
            UseragentsDictionary.TryAdd(850, "Opera/9.10 (Windows NT 5.1; U; pt)");
            UseragentsDictionary.TryAdd(851, "Opera/9.10 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(852, "Opera/9.10 (Windows NT 5.1; U; nl)");
            UseragentsDictionary.TryAdd(853, "Opera/9.10 (Windows NT 5.1; U; MEGAUPLOAD 1.0; pl)");
            UseragentsDictionary.TryAdd(854, "Opera/9.10 (Windows NT 5.1; U; it)");
            UseragentsDictionary.TryAdd(855, "Opera/9.10 (Windows NT 5.1; U; hu)");
            UseragentsDictionary.TryAdd(856, "Opera/9.10 (Windows NT 5.1; U; fi)");
            UseragentsDictionary.TryAdd(857, "Opera/9.10 (Windows NT 5.1; U; es-es)");
            UseragentsDictionary.TryAdd(858, "Opera/9.02 (X11; Linux i686; U; pl)");
            UseragentsDictionary.TryAdd(859, "Opera/9.02 (X11; Linux i686; U; hu)");
            UseragentsDictionary.TryAdd(860, "Opera/9.02 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(861, "Opera/9.02 (X11; Linux i686; U; de)");
            UseragentsDictionary.TryAdd(862, "Opera/9.02 (Windows; U; nl)");
            UseragentsDictionary.TryAdd(863, "Opera/9.02 (Windows XP; U; ru)");
            UseragentsDictionary.TryAdd(864, "Opera/9.02 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(865, "Opera/9.02 (Windows NT 5.2; U; de)");
            UseragentsDictionary.TryAdd(866, "Opera/9.02 (Windows NT 5.1; U; zh-cn)");
            UseragentsDictionary.TryAdd(867, "Opera/9.02 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(868, "Opera/9.02 (Windows NT 5.1; U; pt-br)");
            UseragentsDictionary.TryAdd(869, "Opera/9.02 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(870, "Opera/9.02 (Windows NT 5.1; U; nb)");
            UseragentsDictionary.TryAdd(871, "Opera/9.02 (Windows NT 5.1; U; ja)");
            UseragentsDictionary.TryAdd(872, "Opera/9.02 (Windows NT 5.1; U; fi)");
            UseragentsDictionary.TryAdd(873, "Opera/9.02 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(874, "Opera/9.02 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(875, "Opera/9.02 (Windows NT 5.0; U; sv)");
            UseragentsDictionary.TryAdd(876, "Opera/9.02 (Windows NT 5.0; U; pl)");
            UseragentsDictionary.TryAdd(877, "Opera/9.02 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(878, "Opera/9.01 (X11; OpenBSD i386; U; en)");
            UseragentsDictionary.TryAdd(879, "Opera/9.01 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(880, "Opera/9.01 (X11; FreeBSD 6 i386; U;pl)");
            UseragentsDictionary.TryAdd(881, "Opera/9.01 (X11; FreeBSD 6 i386; U; en)");
            UseragentsDictionary.TryAdd(882, "Opera/9.01 (Windows NT 5.2; U; ru)");
            UseragentsDictionary.TryAdd(883, "Opera/9.01 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(884, "Opera/9.01 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(885, "Opera/9.01 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(886, "Opera/9.01 (Windows NT 5.1; U; ja)");
            UseragentsDictionary.TryAdd(887, "Opera/9.01 (Windows NT 5.1; U; es-es)");
            UseragentsDictionary.TryAdd(888, "Opera/9.01 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(889, "Opera/9.01 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(890, "Opera/9.01 (Windows NT 5.1; U; da)");
            UseragentsDictionary.TryAdd(891, "Opera/9.01 (Windows NT 5.1; U; cs)");
            UseragentsDictionary.TryAdd(892, "Opera/9.01 (Windows NT 5.1; U; bg)");
            UseragentsDictionary.TryAdd(893, "Opera/9.01 (Windows NT 5.1)");
            UseragentsDictionary.TryAdd(894, "Opera/9.01 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(895, "Opera/9.01 (Windows NT 5.0; U; de)");
            UseragentsDictionary.TryAdd(896, "Opera/9.01 (Macintosh; PPC Mac OS X; U; it)");
            UseragentsDictionary.TryAdd(897, "Opera/9.01 (Macintosh; PPC Mac OS X; U; en)");
            UseragentsDictionary.TryAdd(898, "Opera/9.00 (X11; Linux i686; U; pl)");
            UseragentsDictionary.TryAdd(899, "Opera/9.00 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(900, "Opera/9.00 (X11; Linux i686; U; de)");
            UseragentsDictionary.TryAdd(901, "Opera/9.00 (Windows; U)");
            UseragentsDictionary.TryAdd(902, "Opera/9.00 (Windows NT 5.2; U; ru)");
            UseragentsDictionary.TryAdd(903, "Opera/9.00 (Windows NT 5.2; U; pl)");
            UseragentsDictionary.TryAdd(904, "Opera/9.00 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(905, "Opera/9.00 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(906, "Opera/9.00 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(907, "Opera/9.00 (Windows NT 5.1; U; nl)");
            UseragentsDictionary.TryAdd(908, "Opera/9.00 (Windows NT 5.1; U; ja)");
            UseragentsDictionary.TryAdd(909, "Opera/9.00 (Windows NT 5.1; U; it)");
            UseragentsDictionary.TryAdd(910, "Opera/9.00 (Windows NT 5.1; U; fr)");
            UseragentsDictionary.TryAdd(911, "Opera/9.00 (Windows NT 5.1; U; fi)");
            UseragentsDictionary.TryAdd(912, "Opera/9.00 (Windows NT 5.1; U; es-es)");
            UseragentsDictionary.TryAdd(913, "Opera/9.00 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(914, "Opera/9.00 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(915, "Opera/9.00 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(916, "Opera/9.00 (Nintendo Wii; U; ; 1038-58; Wii Internet Channel/1.0; en)");
            UseragentsDictionary.TryAdd(917, "Opera/9.00 (Macintosh; PPC Mac OS X; U; es)");
            UseragentsDictionary.TryAdd(918, "Mozilla/5.0 (compatible; MSIE 6.0; Windows NT 5.1; zh-cn) Opera 8.65");
            UseragentsDictionary.TryAdd(919, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; zh-cn) Opera 8.65");
            UseragentsDictionary.TryAdd(920, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) Opera 8.65 [en]");
            UseragentsDictionary.TryAdd(921,
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; Sprint:PPC-6700) Opera 8.65 [en]");
            UseragentsDictionary.TryAdd(922,
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; PPC; 320x320)Opera 8.65 [en]");
            UseragentsDictionary.TryAdd(923,
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; PPC; 320x320) Opera 8.65 [en]");
            UseragentsDictionary.TryAdd(924,
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; PPC; 240x320) Opera 8.65 [zh-cn]");
            UseragentsDictionary.TryAdd(925,
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; PPC; 240x320) Opera 8.65 [nl]");
            UseragentsDictionary.TryAdd(926,
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; PPC; 240x320) Opera 8.65 [de]");
            UseragentsDictionary.TryAdd(927,
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; PPC; 240x240) Opera 8.65 [en]");
            UseragentsDictionary.TryAdd(928, "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; PPC) Opera 8.65 [en]");
            UseragentsDictionary.TryAdd(929, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) Opera 8.60 [en]");
            UseragentsDictionary.TryAdd(930,
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; PPC; 240x320) Opera 8.60 [en]");
            UseragentsDictionary.TryAdd(931,
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; PPC; 240x240) Opera 8.60 [en]");
            UseragentsDictionary.TryAdd(932, "Opera/8.54 (X11; Linux i686; U; pl)");
            UseragentsDictionary.TryAdd(933, "Opera/8.54 (X11; Linux i686; U; de)");
            UseragentsDictionary.TryAdd(934, "Opera/8.54 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(935, "Opera/8.54 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(936, "Opera/8.54 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(937, "Opera/8.54 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(938, "Opera/8.54 (Windows NT 5.0; U; de)");
            UseragentsDictionary.TryAdd(939, "Opera/8.54 (Windows NT 4.0; U; zh-cn)");
            UseragentsDictionary.TryAdd(940, "Opera/8.54 (Windows 98; U; en)");
            UseragentsDictionary.TryAdd(941, "Mozilla/5.0 (Windows NT 5.1; U; pl) Opera 8.54");
            UseragentsDictionary.TryAdd(942, "Mozilla/5.0 (Windows 98; U; en) Opera 8.54");
            UseragentsDictionary.TryAdd(943, "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686; en) Opera 8.54");
            UseragentsDictionary.TryAdd(944, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; ru) Opera 8.54");
            UseragentsDictionary.TryAdd(945, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; pl) Opera 8.54");
            UseragentsDictionary.TryAdd(946, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; fr) Opera 8.54");
            UseragentsDictionary.TryAdd(947, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; en) Opera 8.54");
            UseragentsDictionary.TryAdd(948, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; de) Opera 8.54");
            UseragentsDictionary.TryAdd(949, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; da) Opera 8.54");
            UseragentsDictionary.TryAdd(950, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0; pl) Opera 8.54");
            UseragentsDictionary.TryAdd(951, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0; en) Opera 8.54");
            UseragentsDictionary.TryAdd(952, "Opera/8.53 (Windows NT 5.2; U; en)");
            UseragentsDictionary.TryAdd(953, "Opera/8.53 (Windows NT 5.1; U; pt)");
            UseragentsDictionary.TryAdd(954, "Opera/8.53 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(955, "Opera/8.53 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(956, "Opera/8.53 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(957, "Opera/8.53 (Windows 98; U; en)");
            UseragentsDictionary.TryAdd(958, "Mozilla/5.0 (Windows NT 5.1; U; en) Opera 8.53");
            UseragentsDictionary.TryAdd(959, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; sv) Opera 8.53");
            UseragentsDictionary.TryAdd(960, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; ru) Opera 8.53");
            UseragentsDictionary.TryAdd(961, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; en) Opera 8.53");
            UseragentsDictionary.TryAdd(962, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0; en) Opera 8.53");
            UseragentsDictionary.TryAdd(963, "Mozilla/4.0 (compatible; MSIE 6.0; Windows 98; en) Opera 8.53");
            UseragentsDictionary.TryAdd(964, "Opera/8.52 (X11; Linux x86_64; U; en)");
            UseragentsDictionary.TryAdd(965, "Opera/8.52 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(966, "Opera/8.52 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(967, "Opera/8.52 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(968, "Opera/8.52 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(969, "Opera/8.52 (Windows ME; U; en)");
            UseragentsDictionary.TryAdd(970, "Mozilla/5.0 (X11; Linux i686; U; en) Opera 8.52");
            UseragentsDictionary.TryAdd(971, "Mozilla/5.0 (Windows NT 5.1; U; en) Opera 8.52");
            UseragentsDictionary.TryAdd(972, "Mozilla/5.0 (Windows NT 5.1; U; de) Opera 8.52");
            UseragentsDictionary.TryAdd(973, "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686; en) Opera 8.52");
            UseragentsDictionary.TryAdd(974, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; pl) Opera 8.52");
            UseragentsDictionary.TryAdd(975, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; en) Opera 8.52");
            UseragentsDictionary.TryAdd(976, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; de) Opera 8.52");
            UseragentsDictionary.TryAdd(977, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0; en) Opera 8.52");
            UseragentsDictionary.TryAdd(978, "Mozilla/4.0 (compatible; MSIE 6.0; Windows 98; en) Opera 8.52");
            UseragentsDictionary.TryAdd(979, "Opera/8.51 (X11; U; Linux i686; en-US; rv:1.8)");
            UseragentsDictionary.TryAdd(980, "Opera/8.51 (X11; Linux x86_64; U; en)");
            UseragentsDictionary.TryAdd(981, "Opera/8.51 (X11; Linux i686; U; en)");
            UseragentsDictionary.TryAdd(982, "Opera/8.51 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(983, "Opera/8.51 (Windows NT 5.1; U; nb)");
            UseragentsDictionary.TryAdd(984, "Opera/8.51 (Windows NT 5.1; U; fr)");
            UseragentsDictionary.TryAdd(985, "Opera/8.51 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(986, "Opera/8.51 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(987, "Opera/8.51 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(988, "Opera/8.51 (Windows 98; U; en)");
            UseragentsDictionary.TryAdd(989, "Opera/8.51 (Macintosh; PPC Mac OS X; U; de)");
            UseragentsDictionary.TryAdd(990, "Opera/8.51 (FreeBSD 5.1; U; en)");
            UseragentsDictionary.TryAdd(991, "Mozilla/5.0 (Windows NT 5.1; U; ru) Opera 8.51");
            UseragentsDictionary.TryAdd(992, "Mozilla/5.0 (Windows NT 5.1; U; fr) Opera 8.51");
            UseragentsDictionary.TryAdd(993, "Mozilla/5.0 (Windows NT 5.1; U; en) Opera 8.51");
            UseragentsDictionary.TryAdd(994, "Mozilla/5.0 (Windows ME; U; en) Opera 8.51");
            UseragentsDictionary.TryAdd(995, "Mozilla/5.0 (Macintosh; PPC Mac OS X; U; en) Opera 8.51");
            UseragentsDictionary.TryAdd(996, "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686; ru) Opera 8.51");
            UseragentsDictionary.TryAdd(997, "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686; en) Opera 8.51");
            UseragentsDictionary.TryAdd(998, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; sv) Opera 8.51");
            UseragentsDictionary.TryAdd(999, "Opera/8.50 (Windows NT 5.1; U; ru)");
            UseragentsDictionary.TryAdd(1000, "Opera/8.50 (Windows NT 5.1; U; pl)");
            UseragentsDictionary.TryAdd(1001, "Opera/8.50 (Windows NT 5.1; U; fr)");
            UseragentsDictionary.TryAdd(1002, "Opera/8.50 (Windows NT 5.1; U; es-ES)");
            UseragentsDictionary.TryAdd(1003, "Opera/8.50 (Windows NT 5.1; U; en)");
            UseragentsDictionary.TryAdd(1004, "Opera/8.50 (Windows NT 5.1; U; de)");
            UseragentsDictionary.TryAdd(1005, "Opera/8.50 (Windows NT 5.0; U; fr)");
            UseragentsDictionary.TryAdd(1006, "Opera/8.50 (Windows NT 5.0; U; en)");
            UseragentsDictionary.TryAdd(1007, "Opera/8.50 (Windows NT 5.0; U; de)");
            UseragentsDictionary.TryAdd(1008, "Opera/8.50 (Windows NT 4.0; U; zh-cn)");
            UseragentsDictionary.TryAdd(1009, "Opera/8.50 (Windows ME; U; en)");
            UseragentsDictionary.TryAdd(1010, "Opera/8.50 (Windows 98; U; ru)");
            UseragentsDictionary.TryAdd(1011, "Opera/8.50 (Windows 98; U; en)");
            UseragentsDictionary.TryAdd(1012, "Mozilla/5.0 (Windows NT 5.1; U; en) Opera 8.50");
            UseragentsDictionary.TryAdd(1013, "Mozilla/5.0 (Windows NT 5.1; U; de) Opera 8.50");
            UseragentsDictionary.TryAdd(1014, "Mozilla/5.0 (Windows NT 5.0; U; de) Opera 8.50");
            UseragentsDictionary.TryAdd(1015, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; ru) Opera 8.50");
            UseragentsDictionary.TryAdd(1016, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; en) Opera 8.50");
            UseragentsDictionary.TryAdd(1017, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; tr) Opera 8.50");
            UseragentsDictionary.TryAdd(1018, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; sv) Opera 8.50");
            UseragentsDictionary.TryAdd(1019,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_8; de-at) AppleWebKit/533.21.1 (KHTML, like Gecko) Version/5.0.5 Safari/533.21.1");
            UseragentsDictionary.TryAdd(1020,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_7; da-dk) AppleWebKit/533.21.1 (KHTML, like Gecko) Version/5.0.5 Safari/533.21.1");
            UseragentsDictionary.TryAdd(1021,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; tr-TR) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1022,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ko-KR) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1023,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; fr-FR) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1024,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1025,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; cs-CZ) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1026,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; ja-JP) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1027,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1028,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_5_8; zh-cn) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1029,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_5_8; ja-jp) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1030,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_7; ja-jp) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1031,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; zh-cn) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1032,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; sv-se) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1033,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; ko-kr) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1034,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; ja-jp) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1035,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; it-it) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1036,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; fr-fr) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1037,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; es-es) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1038,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; en-us) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1039,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; en-gb) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1040,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; de-de) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.4 Safari/533.20.27");
            UseragentsDictionary.TryAdd(1041,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; sv-SE) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1042,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ja-JP) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1043,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; de-DE) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1044,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; hu-HU) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1045,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1046,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; de-DE) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1047,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ru-RU) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1048,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ja-JP) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1049,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; it-IT) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1050,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/533.20.25 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1051,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_7; en-us) AppleWebKit/534.16+ (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1052,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; fr-ch) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1053,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_5; de-de) AppleWebKit/534.15+ (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1054,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_5; ar) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1055,
                "Mozilla/5.0 (Android 2.2; Windows; U; Windows NT 6.1; en-US) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.3 Safari/533.19.4");
            UseragentsDictionary.TryAdd(1056,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-HK) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UseragentsDictionary.TryAdd(1057,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UseragentsDictionary.TryAdd(1058,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; tr-TR) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UseragentsDictionary.TryAdd(1059,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; nb-NO) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UseragentsDictionary.TryAdd(1060,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; fr-FR) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UseragentsDictionary.TryAdd(1061,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-TW) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UseragentsDictionary.TryAdd(1062,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ru-RU) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UseragentsDictionary.TryAdd(1063,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; zh-cn) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UseragentsDictionary.TryAdd(1064,
                "Mozilla/5.0 (iPod; U; CPU iPhone OS 4_3_3 like Mac OS X; ja-jp) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8J2 Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1065,
                "Mozilla/5.0 (iPod; U; CPU iPhone OS 4_3_1 like Mac OS X; zh-cn) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8G4 Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1066,
                "Mozilla/5.0 (iPod; U; CPU iPhone OS 4_2_1 like Mac OS X; he-il) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8C148 Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1067,
                "Mozilla/5.0 (iPhone; U; fr; CPU iPhone OS 4_2_1 like Mac OS X; fr) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8C148a Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1068,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_3_1 like Mac OS X; zh-tw) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8G4 Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1069,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_3 like Mac OS X; pl-pl) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8F190 Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1070,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_3 like Mac OS X; fr-fr) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8F190 Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1071,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_3 like Mac OS X; en-gb) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8F190 Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1072,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_2_1 like Mac OS X; ru-ru) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8C148 Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1073,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_2_1 like Mac OS X; nb-no) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8C148a Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1074,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_2_1 like Mac OS X; it-it) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8C148a Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1075,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_2_1 like Mac OS X; fr) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8C148a Safari/6533.18.5");
            UseragentsDictionary.TryAdd(1076,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/533.17.8 (KHTML, like Gecko) Version/5.0.1 Safari/533.17.8");
            UseragentsDictionary.TryAdd(1077,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; th-th) AppleWebKit/533.17.8 (KHTML, like Gecko) Version/5.0.1 Safari/533.17.8");
            UseragentsDictionary.TryAdd(1078,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-us) AppleWebKit/531.2+ (KHTML, like Gecko) Version/5.0 Safari/531.2+");
            UseragentsDictionary.TryAdd(1079,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-ca) AppleWebKit/531.2+ (KHTML, like Gecko) Version/5.0 Safari/531.2+");
            UseragentsDictionary.TryAdd(1080,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ja-JP) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1081,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1082,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1083,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; ja-JP) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1084,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_5_8; ja-jp) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1085,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_4_11; fr) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1086,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; zh-cn) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1087,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; ru-ru) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1088,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; ko-kr) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1089,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; it-it) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1090,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; HTC-P715a; en-ca) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1091,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-us) AppleWebKit/534.1+ (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1092,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-au) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1093,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; el-gr) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1094,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; ca-es) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1095,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; zh-tw) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1096,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; ja-jp) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1097,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; it-it) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16");
            UseragentsDictionary.TryAdd(1098,
                "Mozilla/5.0 (Windows; U; Windows NT 5.0; en-en) AppleWebKit/533.16 (KHTML, like Gecko) Version/4.1 Safari/533.16");
            UseragentsDictionary.TryAdd(1099,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_4_11; nl-nl) AppleWebKit/533.16 (KHTML, like Gecko) Version/4.1 Safari/533.16");
            UseragentsDictionary.TryAdd(1100,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_4_11; ja-jp) AppleWebKit/533.16 (KHTML, like Gecko) Version/4.1 Safari/533.16");
            UseragentsDictionary.TryAdd(1101,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_4_11; de-de) AppleWebKit/533.16 (KHTML, like Gecko) Version/4.1 Safari/533.16");
            UseragentsDictionary.TryAdd(1102,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_7; en-us) AppleWebKit/533.4 (KHTML, like Gecko) Version/4.1 Safari/533.4");
            UseragentsDictionary.TryAdd(1103,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en) AppleWebKit/526.9 (KHTML, like Gecko) Version/4.0dp1 Safari/526.8");
            UseragentsDictionary.TryAdd(1104,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_4_11; tr) AppleWebKit/528.4+ (KHTML, like Gecko) Version/4.0dp1 Safari/526.11.2");
            UseragentsDictionary.TryAdd(1105,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_4_11; en) AppleWebKit/528.4+ (KHTML, like Gecko) Version/4.0dp1 Safari/526.11.2");
            UseragentsDictionary.TryAdd(1106,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_4_11; de) AppleWebKit/528.4+ (KHTML, like Gecko) Version/4.0dp1 Safari/526.11.2");
            UseragentsDictionary.TryAdd(1107,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10.5; en-US; rv:1.9.1b3pre) Gecko/20081212 Mozilla/5.0 (Windows; U; Windows NT 5.1; en) AppleWebKit/526.9 (KHTML, like Gecko) Version/4.0dp1 Safari/526.8");
            UseragentsDictionary.TryAdd(1108,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_6; en-gb) AppleWebKit/528.10+ (KHTML, like Gecko) Version/4.0dp1 Safari/526.11.2");
            UseragentsDictionary.TryAdd(1109,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_4; en-us) AppleWebKit/528.4+ (KHTML, like Gecko) Version/4.0dp1 Safari/526.11.2");
            UseragentsDictionary.TryAdd(1110,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_4; en-gb) AppleWebKit/528.4+ (KHTML, like Gecko) Version/4.0dp1 Safari/526.11.2");
            UseragentsDictionary.TryAdd(1111,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1112,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1113,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1114,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-gb) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1115,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; cs-CZ) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1116,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_5_8; en-us) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1117,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_4_11; da-dk) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1118,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; ja-jp) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1119,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-us) AppleWebKit/533.4+ (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1120,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-us) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1121,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; de-de) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1122,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_2; ja-jp) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1123,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; nl-nl) AppleWebKit/531.22.7 (KHTML, like Gecko) Version/4.0.5 Safari/531.22.7");
            UseragentsDictionary.TryAdd(1124,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_1 like Mac OS X; en-us) AppleWebKit/532.9 (KHTML, like Gecko) Version/4.0.5 Mobile/8B5097d Safari/6531.22.7");
            UseragentsDictionary.TryAdd(1125,
                "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_1 like Mac OS X; en-us) AppleWebKit/532.9 (KHTML, like Gecko) Version/4.0.5 Mobile/8B117 Safari/6531.22.7");
            UseragentsDictionary.TryAdd(1126,
                "Mozilla/5.0(iPad; U; CPU iPhone OS 3_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B314 Safari/531.21.10gin_lib.cc");
            UseragentsDictionary.TryAdd(1127,
                "Mozilla/5.0(iPad; U; CPU iPhone OS 3_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B314 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1128,
                "Mozilla/5.0(iPad; U; CPU iPhone OS 3_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B314 Safari/123");
            UseragentsDictionary.TryAdd(1129,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-TW) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1130,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ko-KR) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1131,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1132,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1133,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; de-DE) AppleWebKit/532+ (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1134,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_4_11; hu-hu) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1135,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-us) AppleWebKit/531.21.11 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1136,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_2; ru-ru) AppleWebKit/533.2+ (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1137,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_2; en-us) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1138,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_2; de-at) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1139,
                "Mozilla/5.0 (iPhone; U; CPU OS 3_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B334b Safari/531.21.10");
            UseragentsDictionary.TryAdd(1140,
                "Mozilla/5.0 (iPhone Simulator; U; CPU iPhone OS 3_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7D11 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1141,
                "Mozilla/5.0 (iPad;U;CPU OS 3_2_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B500 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1142,
                "Mozilla/5.0 (iPad; U; CPU OS 3_2_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B500 Safari/53");
            UseragentsDictionary.TryAdd(1143,
                "Mozilla/5.0 (iPad; U; CPU OS 3_2 like Mac OS X; es-es) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B367 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1144,
                "Mozilla/5.0 (iPad; U; CPU OS 3_2 like Mac OS X; es-es) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B360 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1145,
                "Mozilla/5.0 (iPad; U; CPU OS 3_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B334b Safari/531.21.1021.10gin_lib.cc");
            UseragentsDictionary.TryAdd(1146,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; fr-ch) AppleWebKit/531.9 (KHTML, like Gecko) Version/4.0.3 Safari/531.9");
            UseragentsDictionary.TryAdd(1147,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-us) AppleWebKit/531.9 (KHTML, like Gecko) Version/4.0.3 Safari/531.9");
            UseragentsDictionary.TryAdd(1148,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_5_8; en-us) AppleWebKit/532.0+ (KHTML, like Gecko) Version/4.0.3 Safari/531.9.2009");
            UseragentsDictionary.TryAdd(1149,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_5_8; en-us) AppleWebKit/532.0+ (KHTML, like Gecko) Version/4.0.3 Safari/531.9");
            UseragentsDictionary.TryAdd(1150,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_1; nl-nl) AppleWebKit/532.3+ (KHTML, like Gecko) Version/4.0.3 Safari/531.9");
            UseragentsDictionary.TryAdd(1151,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; fi-fi) AppleWebKit/531.9 (KHTML, like Gecko) Version/4.0.3 Safari/531.9");
            UseragentsDictionary.TryAdd(1152,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; en-us) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.3 Safari/531.21.10");
            UseragentsDictionary.TryAdd(1153,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6) AppleWebKit/531.4 (KHTML, like Gecko) Version/4.0.3 Safari/531.4");
            UseragentsDictionary.TryAdd(1154,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/532+ (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1155,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1156,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-TW) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1157,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; pl-PL) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1158,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; ja-JP) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1159,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; fr-FR) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1160,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1161,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; de-DE) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1162,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1163,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19.1");
            UseragentsDictionary.TryAdd(1164,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_5_7; en-us) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19");
            UseragentsDictionary.TryAdd(1165,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_7; en-us) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.2 Safari/530.19");
            UseragentsDictionary.TryAdd(1166,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_7; en-us) AppleWebKit/531.2+ (KHTML, like Gecko) Version/4.0.1 Safari/530.18");
            UseragentsDictionary.TryAdd(1167,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_7; en-us) AppleWebKit/530.19.2 (KHTML, like Gecko) Version/4.0.1 Safari/530.18");
            UseragentsDictionary.TryAdd(1168,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; ru-RU) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1169,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; ja-JP) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1170,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; hu-HU) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1171,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; he-IL) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1172,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; he-IL) AppleWebKit/528+ (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1173,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; fr-FR) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1174,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; es-es) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1175,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1176,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1177,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; de-DE) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1178,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-TW) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1179,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1180,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; sv-SE) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1181,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ru-RU) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1182,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1183,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-BR) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1184,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; nb-NO) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1185,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; hu-HU) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1186,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr-FR) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1187,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fi-FI) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16");
            UseragentsDictionary.TryAdd(1188,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.1 (KHTML, like Gecko) Ubuntu/11.04 Chromium/14.0.825.0 Chrome/14.0.825.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1189,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.824.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1190,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.815.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1191,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.1 (KHTML, like Gecko) Ubuntu/11.04 Chromium/14.0.814.0 Chrome/14.0.814.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1192,
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.814.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1193,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.1 (KHTML, like Gecko) Ubuntu/10.04 Chromium/14.0.813.0 Chrome/14.0.813.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1194,
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.813.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1195,
                "Mozilla/5.0 (Windows NT 5.2) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.813.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1196,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.813.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1197,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_7) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.813.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1198,
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.812.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1199,
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.811.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1200,
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.810.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1201,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.810.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1202,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.809.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1203,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/535.1 (KHTML, like Gecko) Ubuntu/10.10 Chromium/14.0.808.0 Chrome/14.0.808.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1204,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.1 (KHTML, like Gecko) Ubuntu/10.04 Chromium/14.0.808.0 Chrome/14.0.808.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1205,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.1 (KHTML, like Gecko) Ubuntu/10.04 Chromium/14.0.804.0 Chrome/14.0.804.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1206,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.803.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1207,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.1 (KHTML, like Gecko) Ubuntu/11.04 Chromium/14.0.803.0 Chrome/14.0.803.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1208,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.803.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1209,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_7_0) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.803.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1210,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_7) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.803.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1211,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_5_8) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.803.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1212,
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.801.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1213,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_5_8) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.801.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1214,
                "Mozilla/5.0 (Windows NT 5.2) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.794.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1215,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_7_0) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.794.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1216,
                "Mozilla/5.0 (Windows NT 6.0) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.792.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1217,
                "Mozilla/5.0 (Windows NT 5.2) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.792.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1218,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.792.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1219,
                "Mozilla/5.0 (Macintosh; PPC Mac OS X 10_6_7) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.790.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1220,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_7) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.790.0 Safari/535.1");
            UseragentsDictionary.TryAdd(1221,
                "Mozilla/5.0 (X11; CrOS i686 13.587.48) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.43 Safari/535.1");
            UseragentsDictionary.TryAdd(1222,
                "Mozilla/5.0 Slackware/13.37 (X11; U; Linux x86_64; en-US) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41");
            UseragentsDictionary.TryAdd(1223,
                "Mozilla/5.0 ArchLinux (X11; Linux x86_64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1224,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/535.1 (KHTML, like Gecko) Ubuntu/11.04 Chromium/13.0.782.41 Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1225,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1226,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1227,
                "Mozilla/5.0 (Windows NT 6.0; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1228,
                "Mozilla/5.0 (Windows NT 6.0) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1229,
                "Mozilla/5.0 (Windows NT 5.2; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1230,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1231,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_7) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1232,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_3) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1233,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_2) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1");
            UseragentsDictionary.TryAdd(1234,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_3) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.32 Safari/535.1");
            UseragentsDictionary.TryAdd(1235,
                "Mozilla/5.0 (X11; Linux amd64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.24 Safari/535.1");
            UseragentsDictionary.TryAdd(1236,
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.24 Safari/535.1");
            UseragentsDictionary.TryAdd(1237,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_8) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.24 Safari/535.1");
            UseragentsDictionary.TryAdd(1238,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.20 Safari/535.1");
            UseragentsDictionary.TryAdd(1239,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.20 Safari/535.1");
            UseragentsDictionary.TryAdd(1240,
                "Mozilla/5.0 (Windows NT 6.0) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.20 Safari/535.1");
            UseragentsDictionary.TryAdd(1241,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.20 Safari/535.1");
            UseragentsDictionary.TryAdd(1242,
                "Mozilla/5.0 (X11; CrOS i686 0.13.587) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.14 Safari/535.1");
            UseragentsDictionary.TryAdd(1243,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/534.36 (KHTML, like Gecko) Chrome/13.0.766.0 Safari/534.36");
            UseragentsDictionary.TryAdd(1244,
                "Mozilla/5.0 (X11; Linux amd64) AppleWebKit/534.36 (KHTML, like Gecko) Chrome/13.0.766.0 Safari/534.36");
            UseragentsDictionary.TryAdd(1245,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.35 (KHTML, like Gecko) Ubuntu/10.10 Chromium/13.0.764.0 Chrome/13.0.764.0 Safari/534.35");
            UseragentsDictionary.TryAdd(1246,
                "Mozilla/5.0 (X11; CrOS i686 0.13.507) AppleWebKit/534.35 (KHTML, like Gecko) Chrome/13.0.763.0 Safari/534.35");
            UseragentsDictionary.TryAdd(1247,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_5_8) AppleWebKit/534.31 (KHTML, like Gecko) Chrome/13.0.748.0 Safari/534.31");
            UseragentsDictionary.TryAdd(1248,
                "Mozilla/5.0 (Windows NT 6.1; en-US) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.750.0 Safari/534.30");
            UseragentsDictionary.TryAdd(1249,
                "Mozilla/5.0 (X11; CrOS i686 12.433.109) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.93 Safari/534.30");
            UseragentsDictionary.TryAdd(1250,
                "Mozilla/5.0 (X11; CrOS i686 12.0.742.91) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.93 Safari/534.30");
            UseragentsDictionary.TryAdd(1251,
                "Mozilla/5.0 Slackware/13.37 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/12.0.742.91");
            UseragentsDictionary.TryAdd(1252,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.91 Chromium/12.0.742.91 Safari/534.30");
            UseragentsDictionary.TryAdd(1253,
                "Mozilla/5.0 ArchLinux (X11; U; Linux x86_64; en-US) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.60 Safari/534.30");
            UseragentsDictionary.TryAdd(1254,
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.53 Safari/534.30");
            UseragentsDictionary.TryAdd(1255,
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.113 Safari/534.30");
            UseragentsDictionary.TryAdd(1256,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/534.30 (KHTML, like Gecko) Ubuntu/11.04 Chromium/12.0.742.112 Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1257,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/534.30 (KHTML, like Gecko) Ubuntu/10.10 Chromium/12.0.742.112 Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1258,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/534.30 (KHTML, like Gecko) Ubuntu/10.04 Chromium/12.0.742.112 Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1259,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.30 (KHTML, like Gecko) Ubuntu/11.04 Chromium/12.0.742.112 Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1260,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.30 (KHTML, like Gecko) Ubuntu/10.10 Chromium/12.0.742.112 Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1261,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.30 (KHTML, like Gecko) Ubuntu/10.04 Chromium/12.0.742.112 Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1262,
                "Mozilla/5.0 (Windows NT 7.1) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1263,
                "Mozilla/5.0 (Windows NT 5.2) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1264,
                "Mozilla/5.0 (Windows 8) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1265,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_6) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1266,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_4) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.112 Safari/534.30");
            UseragentsDictionary.TryAdd(1267,
                "Mozilla/5.0 (X11; CrOS i686 12.433.216) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.105 Safari/534.30");
            UseragentsDictionary.TryAdd(1268,
                "Mozilla/5.0 ArchLinux (X11; U; Linux x86_64; en-US) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.100 Safari/534.30");
            UseragentsDictionary.TryAdd(1269,
                "Mozilla/5.0 ArchLinux (X11; U; Linux x86_64; en-US) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.100");
            UseragentsDictionary.TryAdd(1270,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.30 (KHTML, like Gecko) Slackware/Chrome/12.0.742.100 Safari/534.30");
            UseragentsDictionary.TryAdd(1271,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.100 Safari/534.30");
            UseragentsDictionary.TryAdd(1272,
                "Mozilla/5.0 (Windows NT 6.0) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.100 Safari/534.30");
            UseragentsDictionary.TryAdd(1273,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_7_0) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.100 Safari/534.30");
            UseragentsDictionary.TryAdd(1274,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_4) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.100 Safari/534.30");
            UseragentsDictionary.TryAdd(1275,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.724.100 Safari/534.30");
            UseragentsDictionary.TryAdd(1276,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/534.25 (KHTML, like Gecko) Chrome/12.0.706.0 Safari/534.25");
            UseragentsDictionary.TryAdd(1277,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/534.24 (KHTML, like Gecko) Ubuntu/10.10 Chromium/12.0.703.0 Chrome/12.0.703.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1278,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.24 (KHTML, like Gecko) Ubuntu/10.10 Chromium/12.0.702.0 Chrome/12.0.702.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1279,
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/12.0.702.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1280,
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/12.0.702.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1281,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.700.3 Safari/534.24");
            UseragentsDictionary.TryAdd(1282,
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.699.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1283,
                "Mozilla/5.0 (Windows NT 6.0; WOW64) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.699.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1284,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_6) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.698.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1285,
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.697.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1286,
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.68 Safari/534.24");
            UseragentsDictionary.TryAdd(1287,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_7) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.68 Safari/534.24");
            UseragentsDictionary.TryAdd(1288,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_5_8) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.68 Safari/534.24");
            UseragentsDictionary.TryAdd(1289,
                "Mozilla/5.0 Slackware/13.37 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/11.0.696.50");
            UseragentsDictionary.TryAdd(1290,
                "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.43 Safari/534.24");
            UseragentsDictionary.TryAdd(1291,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.34 Safari/534.24");
            UseragentsDictionary.TryAdd(1292,
                "Mozilla/5.0 (Windows NT 6.0; WOW64) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.34 Safari/534.24");
            UseragentsDictionary.TryAdd(1293,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.3 Safari/534.24");
            UseragentsDictionary.TryAdd(1294,
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.3 Safari/534.24");
            UseragentsDictionary.TryAdd(1295,
                "Mozilla/5.0 (Windows NT 6.0) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.3 Safari/534.24");
            UseragentsDictionary.TryAdd(1296,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.14 Safari/534.24");
            UseragentsDictionary.TryAdd(1297,
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.12 Safari/534.24");
            UseragentsDictionary.TryAdd(1298,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_6) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.12 Safari/534.24");
            UseragentsDictionary.TryAdd(1299,
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/534.24 (KHTML, like Gecko) Ubuntu/10.04 Chromium/11.0.696.0 Chrome/11.0.696.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1300,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_7_0) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.696.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1301,
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.24 (KHTML, like Gecko) Chrome/11.0.694.0 Safari/534.24");
            UseragentsDictionary.TryAdd(1302,
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.23 (KHTML, like Gecko) Chrome/11.0.686.3 Safari/534.23");
            UseragentsDictionary.TryAdd(1303,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.21 (KHTML, like Gecko) Chrome/11.0.682.0 Safari/534.21");
            UseragentsDictionary.TryAdd(1304,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.21 (KHTML, like Gecko) Chrome/11.0.678.0 Safari/534.21");
            UseragentsDictionary.TryAdd(1305,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_7_0; en-US) AppleWebKit/534.21 (KHTML, like Gecko) Chrome/11.0.678.0 Safari/534.21");
            UseragentsDictionary.TryAdd(1306,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.20 (KHTML, like Gecko) Chrome/11.0.672.2 Safari/534.20");
            UseragentsDictionary.TryAdd(1307,
                "Mozilla/5.0 (Windows NT) AppleWebKit/534.20 (KHTML, like Gecko) Chrome/11.0.672.2 Safari/534.20");
            UseragentsDictionary.TryAdd(1308,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; en-US) AppleWebKit/534.20 (KHTML, like Gecko) Chrome/11.0.672.2 Safari/534.20");
            UseragentsDictionary.TryAdd(1309,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.20 (KHTML, like Gecko) Chrome/11.0.669.0 Safari/534.20");
            UseragentsDictionary.TryAdd(1310,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.19 (KHTML, like Gecko) Chrome/11.0.661.0 Safari/534.19");
            UseragentsDictionary.TryAdd(1311,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.18 (KHTML, like Gecko) Chrome/11.0.661.0 Safari/534.18");
            UseragentsDictionary.TryAdd(1312,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; en-US) AppleWebKit/534.18 (KHTML, like Gecko) Chrome/11.0.660.0 Safari/534.18");
            UseragentsDictionary.TryAdd(1313,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.17 (KHTML, like Gecko) Chrome/11.0.655.0 Safari/534.17");
            UseragentsDictionary.TryAdd(1314,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.17 (KHTML, like Gecko) Chrome/11.0.655.0 Safari/534.17");
            UseragentsDictionary.TryAdd(1315,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.17 (KHTML, like Gecko) Chrome/11.0.654.0 Safari/534.17");
            UseragentsDictionary.TryAdd(1316,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.17 (KHTML, like Gecko) Chrome/11.0.652.0 Safari/534.17");
            UseragentsDictionary.TryAdd(1317,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.17 (KHTML, like Gecko) Chrome/10.0.649.0 Safari/534.17");
            UseragentsDictionary.TryAdd(1318,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; de-DE) AppleWebKit/534.17 (KHTML, like Gecko) Chrome/10.0.649.0 Safari/534.17");
            UseragentsDictionary.TryAdd(1319,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.82 Safari/534.16");
            UseragentsDictionary.TryAdd(1320,
                "Mozilla/5.0 (X11; U; Linux armv7l; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.204 Safari/534.16");
            UseragentsDictionary.TryAdd(1321,
                "Mozilla/5.0 (X11; U; FreeBSD x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.204 Safari/534.16");
            UseragentsDictionary.TryAdd(1322,
                "Mozilla/5.0 (X11; U; FreeBSD i386; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.204 Safari/534.16");
            UseragentsDictionary.TryAdd(1323,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_5; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.204");
            UseragentsDictionary.TryAdd(1324,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.134 Safari/534.16");
            UseragentsDictionary.TryAdd(1325,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.134 Safari/534.16");
            UseragentsDictionary.TryAdd(1326,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.134 Safari/534.16");
            UseragentsDictionary.TryAdd(1327,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.134 Safari/534.16");
            UseragentsDictionary.TryAdd(1328,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Ubuntu/10.10 Chromium/10.0.648.133 Chrome/10.0.648.133 Safari/534.16");
            UseragentsDictionary.TryAdd(1329,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.133 Safari/534.16");
            UseragentsDictionary.TryAdd(1330,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Ubuntu/10.10 Chromium/10.0.648.133 Chrome/10.0.648.133 Safari/534.16");
            UseragentsDictionary.TryAdd(1331,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.133 Safari/534.16");
            UseragentsDictionary.TryAdd(1332,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.133 Safari/534.16");
            UseragentsDictionary.TryAdd(1333,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.133 Safari/534.16");
            UseragentsDictionary.TryAdd(1334,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_2; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.133 Safari/534.16");
            UseragentsDictionary.TryAdd(1335,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Ubuntu/10.10 Chromium/10.0.648.127 Chrome/10.0.648.127 Safari/534.16");
            UseragentsDictionary.TryAdd(1336,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.127 Safari/534.16");
            UseragentsDictionary.TryAdd(1337,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.127 Safari/534.16");
            UseragentsDictionary.TryAdd(1338,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.127 Safari/534.16");
            UseragentsDictionary.TryAdd(1339,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.11 Safari/534.16");
            UseragentsDictionary.TryAdd(1340,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru-RU) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.11 Safari/534.16");
            UseragentsDictionary.TryAdd(1341,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.11 Safari/534.16");
            UseragentsDictionary.TryAdd(1342,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Ubuntu/10.10 Chromium/10.0.648.0 Chrome/10.0.648.0 Safari/534.16");
            UseragentsDictionary.TryAdd(1343,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Ubuntu/10.10 Chromium/10.0.648.0 Chrome/10.0.648.0 Safari/534.16");
            UseragentsDictionary.TryAdd(1344,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.0 Safari/534.16");
            UseragentsDictionary.TryAdd(1345,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Ubuntu/10.10 Chromium/10.0.642.0 Chrome/10.0.642.0 Safari/534.16");
            UseragentsDictionary.TryAdd(1346,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_5; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.639.0 Safari/534.16");
            UseragentsDictionary.TryAdd(1347,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.638.0 Safari/534.16");
            UseragentsDictionary.TryAdd(1348,
                "Mozilla/5.0 (X11; U; Linux i686 (x86_64); en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.634.0 Safari/534.16");
            UseragentsDictionary.TryAdd(1349,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.634.0 Safari/534.16");
            UseragentsDictionary.TryAdd(1350,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.16 SUSE/10.0.626.0 (KHTML, like Gecko) Chrome/10.0.626.0 Safari/534.16");
            UseragentsDictionary.TryAdd(1351,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.15 (KHTML, like Gecko) Chrome/10.0.613.0 Safari/534.15");
            UseragentsDictionary.TryAdd(1352,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.15 (KHTML, like Gecko) Ubuntu/10.10 Chromium/10.0.613.0 Chrome/10.0.613.0 Safari/534.15");
            UseragentsDictionary.TryAdd(1353,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.15 (KHTML, like Gecko) Ubuntu/10.04 Chromium/10.0.612.3 Chrome/10.0.612.3 Safari/534.15");
            UseragentsDictionary.TryAdd(1354,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.15 (KHTML, like Gecko) Chrome/10.0.612.1 Safari/534.15");
            UseragentsDictionary.TryAdd(1355,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.15 (KHTML, like Gecko) Ubuntu/10.10 Chromium/10.0.611.0 Chrome/10.0.611.0 Safari/534.15");
            UseragentsDictionary.TryAdd(1356,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Chrome/10.0.602.0 Safari/534.14");
            UseragentsDictionary.TryAdd(1357,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Chrome/10.0.601.0 Safari/534.14");
            UseragentsDictionary.TryAdd(1358,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Chrome/10.0.601.0 Safari/534.14");
            UseragentsDictionary.TryAdd(1359,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/540.0 (KHTML,like Gecko) Chrome/9.1.0.0 Safari/540.0");
            UseragentsDictionary.TryAdd(1360,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/540.0 (KHTML, like Gecko) Ubuntu/10.10 Chrome/9.1.0.0 Safari/540.0");
            UseragentsDictionary.TryAdd(1361,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Chrome/9.0.601.0 Safari/534.14");
            UseragentsDictionary.TryAdd(1362,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Ubuntu/10.10 Chromium/9.0.600.0 Chrome/9.0.600.0 Safari/534.14");
            UseragentsDictionary.TryAdd(1363,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Chrome/9.0.600.0 Safari/534.14");
            UseragentsDictionary.TryAdd(1364,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.599.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1365,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.84 Safari/534.13");
            UseragentsDictionary.TryAdd(1366,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.44 Safari/534.13");
            UseragentsDictionary.TryAdd(1367,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.19 Safari/534.13");
            UseragentsDictionary.TryAdd(1368,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.15 Safari/534.13");
            UseragentsDictionary.TryAdd(1369,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_5; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.15 Safari/534.13");
            UseragentsDictionary.TryAdd(1370,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1371,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1372,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1373,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1374,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_5; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1375,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1376,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.596.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1377,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Ubuntu/10.04 Chromium/9.0.595.0 Chrome/9.0.595.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1378,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Ubuntu/9.10 Chromium/9.0.592.0 Chrome/9.0.592.0 Safari/534.13");
            UseragentsDictionary.TryAdd(1379,
                "Mozilla/5.0 (X11; U; Windows NT 6; en-US) AppleWebKit/534.12 (KHTML, like Gecko) Chrome/9.0.587.0 Safari/534.12");
            UseragentsDictionary.TryAdd(1380,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.12 (KHTML, like Gecko) Chrome/9.0.579.0 Safari/534.12");
            UseragentsDictionary.TryAdd(1381,
                "Mozilla/5.0 (X11; U; Linux i686 (x86_64); en-US) AppleWebKit/534.12 (KHTML, like Gecko) Chrome/9.0.576.0 Safari/534.12");
            UseragentsDictionary.TryAdd(1382,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/540.0 (KHTML, like Gecko) Ubuntu/10.10 Chrome/8.1.0.0 Safari/540.0");
            UseragentsDictionary.TryAdd(1383,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.558.0 Safari/534.10");
            UseragentsDictionary.TryAdd(1384,
                "Mozilla/5.0 (X11; U; CrOS i686 0.9.130; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.344 Safari/534.10");
            UseragentsDictionary.TryAdd(1385,
                "Mozilla/5.0 (X11; U; CrOS i686 0.9.128; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.343 Safari/534.10");
            UseragentsDictionary.TryAdd(1386,
                "Mozilla/5.0 (X11; U; CrOS i686 0.9.128; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.341 Safari/534.10");
            UseragentsDictionary.TryAdd(1387,
                "Mozilla/5.0 (X11; U; CrOS i686 0.9.128; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.339 Safari/534.10");
            UseragentsDictionary.TryAdd(1388,
                "Mozilla/5.0 (X11; U; CrOS i686 0.9.128; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.339");
            UseragentsDictionary.TryAdd(1389,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Ubuntu/10.10 Chromium/8.0.552.237 Chrome/8.0.552.237 Safari/534.10");
            UseragentsDictionary.TryAdd(1390,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; de-DE) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.224 Safari/534.10");
            UseragentsDictionary.TryAdd(1391,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/533.3 (KHTML, like Gecko) Chrome/8.0.552.224 Safari/533.3");
            UseragentsDictionary.TryAdd(1392,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.224 Safari/534.10");
            UseragentsDictionary.TryAdd(1393,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.215 Safari/534.10");
            UseragentsDictionary.TryAdd(1394,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.215 Safari/534.10");
            UseragentsDictionary.TryAdd(1395,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.215 Safari/534.10");
            UseragentsDictionary.TryAdd(1396,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.210 Safari/534.10");
            UseragentsDictionary.TryAdd(1397,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.200 Safari/534.10");
            UseragentsDictionary.TryAdd(1398,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.551.0 Safari/534.10");
            UseragentsDictionary.TryAdd(1399,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/7.0.548.0 Safari/534.10");
            UseragentsDictionary.TryAdd(1400,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/7.0.544.0 Safari/534.10");
            UseragentsDictionary.TryAdd(1401,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.1.15) Gecko/20101027 Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/7.0.540.0 Safari/534.10");
            UseragentsDictionary.TryAdd(1402,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/7.0.540.0 Safari/534.10");
            UseragentsDictionary.TryAdd(1403,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; de-DE) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/7.0.540.0 Safari/534.10");
            UseragentsDictionary.TryAdd(1404,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/7.0.540.0 Safari/534.10");
            UseragentsDictionary.TryAdd(1405,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.9 (KHTML, like Gecko) Chrome/7.0.531.0 Safari/534.9");
            UseragentsDictionary.TryAdd(1406,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.8 (KHTML, like Gecko) Chrome/7.0.521.0 Safari/534.8");
            UseragentsDictionary.TryAdd(1407,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Chrome/7.0.517.24 Safari/534.7");
            UseragentsDictionary.TryAdd(1408,
                "Mozilla/5.0 (X11; U; Linux x86_64; fr-FR) AppleWebKit/534.7 (KHTML, like Gecko) Chrome/7.0.514.0 Safari/534.7");
            UseragentsDictionary.TryAdd(1409,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Chrome/7.0.514.0 Safari/534.7");
            UseragentsDictionary.TryAdd(1410,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Chrome/7.0.514.0 Safari/534.7");
            UseragentsDictionary.TryAdd(1411,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.6 (KHTML, like Gecko) Chrome/7.0.500.0 Safari/534.6");
            UseragentsDictionary.TryAdd(1412,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.6 (KHTML, like Gecko) Chrome/7.0.498.0 Safari/534.6");
            UseragentsDictionary.TryAdd(1413,
                "Mozilla/5.0 (ipad Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.6 (KHTML, like Gecko) Chrome/7.0.498.0 Safari/534.6");
            UseragentsDictionary.TryAdd(1414,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/525.13 (KHTML, like Gecko) Chrome/7.0.0 Safari/700.13");
            UseragentsDictionary.TryAdd(1415,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.4 (KHTML, like Gecko) Chrome/6.0.481.0 Safari/534.4");
            UseragentsDictionary.TryAdd(1416,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_1; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.472.63 Safari/534.3");
            UseragentsDictionary.TryAdd(1417,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.472.53 Safari/534.3");
            UseragentsDictionary.TryAdd(1418,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.472.33 Safari/534.3");
            UseragentsDictionary.TryAdd(1419,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.470.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1420,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.464.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1421,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.464.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1422,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.463.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1423,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.462.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1424,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.462.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1425,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.461.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1426,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.461.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1427,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.461.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1428,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.460.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1429,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.460.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1430,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.460.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1431,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.459.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1432,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.458.1 Safari/534.3");
            UseragentsDictionary.TryAdd(1433,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.458.1 Safari/534.3");
            UseragentsDictionary.TryAdd(1434,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.458.1 Safari/534.3");
            UseragentsDictionary.TryAdd(1435,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.458.1 Safari/534.3");
            UseragentsDictionary.TryAdd(1436,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.458.1 Safari/534.3");
            UseragentsDictionary.TryAdd(1437,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.458.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1438,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.458.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1439,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.457.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1440,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/534.3 (KHTML, like Gecko) Chrome/6.0.456.0 Safari/534.3");
            UseragentsDictionary.TryAdd(1441,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.2 (KHTML, like Gecko) Chrome/6.0.454.0 Safari/534.2");
            UseragentsDictionary.TryAdd(1442,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.2 (KHTML, like Gecko) Chrome/6.0.454.0 Safari/534.2");
            UseragentsDictionary.TryAdd(1443,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.2 (KHTML, like Gecko) Chrome/6.0.453.1 Safari/534.2");
            UseragentsDictionary.TryAdd(1444,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/534.2 (KHTML, like Gecko) Chrome/6.0.453.1 Safari/534.2");
            UseragentsDictionary.TryAdd(1445,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; en-US) AppleWebKit/534.2 (KHTML, like Gecko) Chrome/6.0.453.1 Safari/534.2");
            UseragentsDictionary.TryAdd(1446,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.2 (KHTML, like Gecko) Chrome/6.0.451.0 Safari/534.2");
            UseragentsDictionary.TryAdd(1447,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.1 SUSE/6.0.428.0 (KHTML, like Gecko) Chrome/6.0.428.0 Safari/534.1");
            UseragentsDictionary.TryAdd(1448,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.1 (KHTML, like Gecko) Chrome/6.0.428.0 Safari/534.1");
            UseragentsDictionary.TryAdd(1449,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB) AppleWebKit/534.1 (KHTML, like Gecko) Chrome/6.0.428.0 Safari/534.1");
            UseragentsDictionary.TryAdd(1450,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/534.1 (KHTML, like Gecko) Chrome/6.0.428.0 Safari/534.1");
            UseragentsDictionary.TryAdd(1451,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.1 (KHTML, like Gecko) Chrome/6.0.427.0 Safari/534.1");
            UseragentsDictionary.TryAdd(1452,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; en-US) AppleWebKit/534.1 (KHTML, like Gecko) Chrome/6.0.422.0 Safari/534.1");
            UseragentsDictionary.TryAdd(1453,
                "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.1 (KHTML, like Gecko) Chrome/6.0.417.0 Safari/534.1");
            UseragentsDictionary.TryAdd(1454,
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.1 (KHTML, like Gecko) Chrome/6.0.416.0 Safari/534.1");
            UseragentsDictionary.TryAdd(1455,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_4; en-US) AppleWebKit/534.1 (KHTML, like Gecko) Chrome/6.0.414.0 Safari/534.1");
            UseragentsDictionary.TryAdd(1456,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/533.9 (KHTML, like Gecko) Chrome/6.0.400.0 Safari/533.9");
            UseragentsDictionary.TryAdd(1457,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/533.8 (KHTML, like Gecko) Chrome/6.0.397.0 Safari/533.8");
            UseragentsDictionary.TryAdd(1458,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/533.2 (KHTML, like Gecko) Chrome/6.0");
            UseragentsDictionary.TryAdd(1459,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/532.2 (KHTML, like Gecko) ChromePlus/4.0.222.3 Chrome/4.0.222.3 Safari/532.2");
            UseragentsDictionary.TryAdd(1460,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/525.28.3 (KHTML, like Gecko) Version/3.2.3 ChromePlus/4.0.222.3 Chrome/4.0.222.3 Safari/525.28.3");
            UseragentsDictionary.TryAdd(1461,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.98 Safari/534.13 ChromePlus/1.6.0.0");
            UseragentsDictionary.TryAdd(1462,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Chrome/9.0.597.98 Safari/534.13 ChromePlus/1.5.3.0alpha4");
            UseragentsDictionary.TryAdd(1463,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.224 Safari/534.10 ChromePlus/1.5.2.0alpha1");
            UseragentsDictionary.TryAdd(1464,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.224 Safari/534.10 ChromePlus/1.5.2.0");
            UseragentsDictionary.TryAdd(1465,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.224 Safari/534.10 ChromePlus/1.5.2.0");
            UseragentsDictionary.TryAdd(1466,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.224 Safari/534.10 ChromePlus/1.5.2.0");
            UseragentsDictionary.TryAdd(1467,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.215 Safari/534.10 ChromePlus/1.5.1.1");
            UseragentsDictionary.TryAdd(1468,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.215 Safari/534.10 ChromePlus/1.5.1.1");
            UseragentsDictionary.TryAdd(1469,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.215 Safari/534.10 ChromePlus/1.5.1.1");
            UseragentsDictionary.TryAdd(1470,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.215 Safari/534.10 ChromePlus/1.5.1.1");
            UseragentsDictionary.TryAdd(1471,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.5001; Windows NT 5.1; Trident/4.0)");
            UseragentsDictionary.TryAdd(1472,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.5000; Windows NT 5.1; Trident/4.0; FunWebProducts)");
            UseragentsDictionary.TryAdd(1473,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.5000; Windows NT 5.1; Trident/4.0; .NET4.0C; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(1474,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.27; Windows NT 5.1; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(1475,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.27; Windows NT 5.1; Trident/4.0; .NET CLR 1.0.3705; .NET CLR 1.1.4322; Media Center PC 4.0; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; InfoPath.2)");
            UseragentsDictionary.TryAdd(1476,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.17; Windows NT 5.1; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(1477,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.168; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.3; MS-RTC LM 8)");
            UseragentsDictionary.TryAdd(1478,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.130; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UseragentsDictionary.TryAdd(1479,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.130; Windows NT 5.1; Trident/4.0; FunWebProducts; GTB6.6; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; yie8)");
            UseragentsDictionary.TryAdd(1480,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.12; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)");
            UseragentsDictionary.TryAdd(1481,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.12; Windows NT 5.1; Trident/4.0; GTB6.3)");
            UseragentsDictionary.TryAdd(1482,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.124; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)");
            UseragentsDictionary.TryAdd(1483,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.122; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.3; MS-RTC LM 8)");
            UseragentsDictionary.TryAdd(1484,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.122; Windows NT 5.1; Trident/4.0; FunWebProducts)");
            UseragentsDictionary.TryAdd(1485,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.111; Windows NT 5.1; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET4.0C; .NET4.0E)");
            UseragentsDictionary.TryAdd(1486,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.110; Windows NT 5.1; Trident/4.0; .NET CLR 1.0.3705; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET4.0C)");
            UseragentsDictionary.TryAdd(1487,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.104; Windows NT 5.1; Trident/4.0; .NET CLR 2.0.50727; .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(1488,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.6; AOLBuild 4340.128; Windows NT 5.1; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)");
            UseragentsDictionary.TryAdd(1489,
                "Mozilla/4.0 (compatible; MSIE 6.0; AOL 9.6; AOLBuild 4340.12; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(1490,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.5; AOLBuild 4337.43; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.21022; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UseragentsDictionary.TryAdd(1491,
                "Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.5; AOLBuild 4337.29; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.21022; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UseragentsDictionary.TryAdd(1492,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.93; Windows NT 5.1; Trident/4.0; DigExt; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(1493,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.89; Windows NT 6.0; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.0.04506)");
            UseragentsDictionary.TryAdd(1494,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.81; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UseragentsDictionary.TryAdd(1495,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.81; Windows NT 6.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UseragentsDictionary.TryAdd(1496,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.80; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)");
            UseragentsDictionary.TryAdd(1497,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.53; Windows NT 6.0; FunWebProducts; GTB6; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.0.04506; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(1498,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.43; Windows NT 6.0; WOW64; GTB5; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UseragentsDictionary.TryAdd(1499,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.43; Windows NT 5.1; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(1500,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.43; Windows NT 5.1; .NET CLR 1.0.3705; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
            UseragentsDictionary.TryAdd(1501,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.42; Windows NT 5.1; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(1502,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.40; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UseragentsDictionary.TryAdd(1503,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.40; Windows NT 6.0; FunWebProducts; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.0.04506; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(1504,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.40; Windows NT 5.1; Trident/4.0; GTB6; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(1505,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.40; Windows NT 5.1; Trident/4.0; .NET CLR 2.0.50727; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(1506,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.36; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.0.30618; .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(1507,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.36; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30618; .NET CLR 1.1.4322)");
            UseragentsDictionary.TryAdd(1508,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.36; Windows NT 6.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UseragentsDictionary.TryAdd(1509,
                "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.5; AOLBuild 4337.35; Windows NT 6.0; WOW64; GTB5; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UseragentsDictionary.TryAdd(1510,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pl-PL; rv:1.8.1.24pre) Gecko/20100228 K-Meleon/1.5.4");
            UseragentsDictionary.TryAdd(1511,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ja-JA; rv:1.8.1.24pre) Gecko/20100228 K-Meleon/1.5.4");
            UseragentsDictionary.TryAdd(1512,
                "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.24pre) Gecko/20091010 K-Meleon/1.5.4");
            UseragentsDictionary.TryAdd(1513,
                "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.24) Gecko/20100228 K-Meleon/1.5.4");
            UseragentsDictionary.TryAdd(1514,
                "Mozilla/5.0 (Windows; U; Win98; de-DE; rv:1.8.1.24) Gecko/20100228 K-Meleon/1.5.4");
            UseragentsDictionary.TryAdd(1515,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1516,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.1.7pre) Gecko K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1517,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1518,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1519,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; fr-FR; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1520,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1521,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pl-PL; rv:1.8.1.22) Gecko/20090623 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1522,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; hu-HU; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1523,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr-FR; rv:1.8.1.23) Gecko/20090825 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1524,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr-FR; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1525,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; es-ES; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1526,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.22) Gecko/20090623 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1527,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1528,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; de-DE; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1529,
                "Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1530,
                "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1531,
                "Mozilla/5.0 (Windows; U; Win 9x 4.90; de-DE; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            UseragentsDictionary.TryAdd(1532,
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1533,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1534,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1535,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; de-DE; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1536,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.8.1.21) Gecko/20090303 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1537,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-BR; rv:1.8.1.21) Gecko/20090403 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1538,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-BR; rv:1.8.1.21) Gecko/20090303 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1539,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; pl-PL; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1540,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; es-ES; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1541,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.22pre) Gecko/20090502 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1542,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.21) Gecko/20090403 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1543,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1544,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-GB; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1545,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; de-DE; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1546,
                "Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1547,
                "Mozilla/5.0 (Windows; U; Windows NT 5.0; de-DE; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1548,
                "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.19) Gecko/20081217 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1549,
                "Mozilla/5.0 (Darwin; FreeBSD 5.6; en-GB; rv:1.9.1b3pre)Gecko/20081211 K-Meleon/1.5.2");
            UseragentsDictionary.TryAdd(1550,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.8.1.17) Gecko/20080919 K-Meleon/1.5.1");
            UseragentsDictionary.TryAdd(1551,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; ru-RU; rv:1.8.1.17) Gecko/20080919 K-Meleon/1.5.1");
            UseragentsDictionary.TryAdd(1552,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr-FR; rv:1.8.1.17) Gecko/20080919 K-Meleon/1.5.1");
            UseragentsDictionary.TryAdd(1553,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.17) Gecko/20080919 K-Meleon/1.5.1");
            UseragentsDictionary.TryAdd(1554,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; de-DE; rv:1.8.1.17) Gecko/20080919 K-Meleon/1.5.1");
            UseragentsDictionary.TryAdd(1555,
                "Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.8.1.17) Gecko/20080919 K-Meleon/1.5.1");
            UseragentsDictionary.TryAdd(1556,
                "Mozilla/5.0 (Windows; U; Windows NT 5.0; de-DE; rv:1.8.1.17) Gecko/20080919 K-Meleon/1.5.1");
            UseragentsDictionary.TryAdd(1557,
                "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.17) Gecko/20080919 K-Meleon/1.5.1");
            UseragentsDictionary.TryAdd(1558,
                "Mozilla/5.0 (Windows; U; Win 9x 4.90; SG; rv:1.9.2.4) Gecko/20101104 Netscape/9.1.0285");
            UseragentsDictionary.TryAdd(1559,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.8.1.8pre) Gecko/20070928 Firefox/2.0.0.7 Navigator/9.0RC1");
            UseragentsDictionary.TryAdd(1560,
                "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.8pre) Gecko/20070928 Firefox/2.0.0.7 Navigator/9.0RC1");
            UseragentsDictionary.TryAdd(1561,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en-US; rv:1.8.1.8pre) Gecko/20071001 Firefox/2.0.0.7 Navigator/9.0RC1");
            UseragentsDictionary.TryAdd(1562,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.7pre) Gecko/20070815 Firefox/2.0.0.6 Navigator/9.0b3");
            UseragentsDictionary.TryAdd(1563,
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US; rv:1.8.1.7pre) Gecko/20070815 Firefox/2.0.0.6 Navigator/9.0b3");
            UseragentsDictionary.TryAdd(1564,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.7pre) Gecko/20070815 Firefox/2.0.0.6 Navigator/9.0b3");
            UseragentsDictionary.TryAdd(1565,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en-US; rv:1.8.1.7pre) Gecko/20070815 Firefox/2.0.0.6 Navigator/9.0b3");
            UseragentsDictionary.TryAdd(1566,
                "Mozilla/5.0 (Windows; U; Windows 98; en-US; rv:1.8.1.5pre) Gecko/20070710 Firefox/2.0.0.4 Navigator/9.0b2");
            UseragentsDictionary.TryAdd(1567,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en-US; rv:1.8.1.5pre) Gecko/20070710 Firefox/2.0.0.4 Navigator/9.0b2");
            UseragentsDictionary.TryAdd(1568,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.12) Gecko/20080219 Firefox/2.0.0.12 Navigator/9.0.0.6");
            UseragentsDictionary.TryAdd(1569,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.8.1.12) Gecko/20080219 Firefox/2.0.0.12 Navigator/9.0.0.6");
            UseragentsDictionary.TryAdd(1570,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.12) Gecko/20080219 Firefox/2.0.0.12 Navigator/9.0.0.6");
            UseragentsDictionary.TryAdd(1571,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en-US; rv:1.8.1.12) Gecko/20080219 Firefox/2.0.0.12 Navigator/9.0.0.6");
            UseragentsDictionary.TryAdd(1572,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.11pre) Gecko/20071206 Firefox/2.0.0.11 Navigator/9.0.0.5");
            UseragentsDictionary.TryAdd(1573,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.11pre) Gecko/20071206 Firefox/2.0.0.11 Navigator/9.0.0.5 GTB5");
            UseragentsDictionary.TryAdd(1574,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.11pre) Gecko/20071206 Firefox/2.0.0.11 Navigator/9.0.0.5");
            UseragentsDictionary.TryAdd(1575,
                "Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.8.1.11pre) Gecko/20071206 Firefox/2.0.0.11 Navigator/9.0.0.5");
            UseragentsDictionary.TryAdd(1576,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en-US; rv:1.8.1.11pre) Gecko/20071206 Firefox/2.0.0.11 Navigator/9.0.0.5");
            UseragentsDictionary.TryAdd(1577,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en-US; rv:1.8.1.11pre) Gecko/20071206 Firefox/2.0.0.11 Navigator/9.0.0.5");
            UseragentsDictionary.TryAdd(1578,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en-US; rv:1.8.1.10pre) Gecko/20071127 Firefox/2.0.0.10 Navigator/9.0.0.4");
            UseragentsDictionary.TryAdd(1579,
                "Mozilla/5.0 (X11; U; Linux i586; en-US; rv:1.8.1.9pre) Gecko/20071102 Firefox/2.0.0.9 Navigator/9.0.0.3");
            UseragentsDictionary.TryAdd(1580,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.9pre) Gecko/20071102 Firefox/2.0.0.9 Navigator/9.0.0.3");
            UseragentsDictionary.TryAdd(1581,
                "Mozilla/5.0 (Windows; U; Windows NT 5.0; fr; rv:1.8.1.9pre) Gecko/20071102 Firefox/2.0.0.9 Navigator/9.0.0.3");
            UseragentsDictionary.TryAdd(1582,
                "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.9pre) Gecko/20071102 Firefox/2.0.0.9 Navigator/9.0.0.3");
            UseragentsDictionary.TryAdd(1583,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en-US; rv:1.8.1.9pre) Gecko/20071102 Firefox/2.0.0.9 Navigator/9.0.0.3");
            UseragentsDictionary.TryAdd(1584,
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.8.1.8pre) Gecko/20071019 Firefox/2.0.0.8 Navigator/9.0.0.1");
            UseragentsDictionary.TryAdd(1585,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.8pre) Gecko/20071019 Firefox/2.0.0.8 Navigator/9.0.0.1");
            UseragentsDictionary.TryAdd(1586,
                "Mozilla/5.0 (Windows; U; Windows 98; en-US; rv:1.8.1.8pre) Gecko/20071019 Firefox/2.0.0.8 Navigator/9.0.0.1");
            UseragentsDictionary.TryAdd(1587,
                "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.8pre) Gecko/20071019 Firefox/2.0.0.8 Navigator/9.0.0.1");
            UseragentsDictionary.TryAdd(1588,
                "Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en-US; rv:1.8.1.8pre) Gecko/20071019 Firefox/2.0.0.8 Navigator/9.0.0.1");
            UseragentsDictionary.TryAdd(1589,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.8pre) Gecko/20071015 Firefox/2.0.0.7 Navigator/9.0");
            UseragentsDictionary.TryAdd(1590,
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.7.5) Gecko/20070321 Netscape/9.0");
            UseragentsDictionary.TryAdd(1591,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.8pre) Gecko/20071015 Firefox/2.0.0.7 Navigator/9.0");
            UseragentsDictionary.TryAdd(1592,
                "Mozilla/5.0 (Windows; U; Win 9x 4.90; en-US; rv:1.8.1.8pre) Gecko/20071015 Firefox/2.0.0.7 Navigator/9.0");
            UseragentsDictionary.TryAdd(1593,
                "Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en-US; rv:1.8.1.8pre) Gecko/20071015 Firefox/2.0.0.7 Navigator/9.0");
            UseragentsDictionary.TryAdd(1594,
                "Mozilla/5.0 (Linux; U; Android 2.3; en-us) AppleWebKit/999+ (KHTML, like Gecko) Safari/999.9");
            UseragentsDictionary.TryAdd(1595,
                "Mozilla/5.0 (Linux; U; Android 2.3.4; fr-fr; HTC Desire Build/GRJ22) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1596,
                "Mozilla/5.0 (Linux; U; Android 2.3.3; zh-tw; HTC_Pyramid Build/GRI40) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1597,
                "Mozilla/5.0 (Linux; U; Android 2.3.3; zh-tw; HTC_Pyramid Build/GRI40) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari");
            UseragentsDictionary.TryAdd(1598,
                "Mozilla/5.0 (Linux; U; Android 2.3.3; zh-tw; HTC Pyramid Build/GRI40) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1599,
                "Mozilla/5.0 (Linux; U; Android 2.3.3; ko-kr; LG-LU3000 Build/GRI40) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1600,
                "Mozilla/5.0 (Linux; U; Android 2.3.3; en-us; HTC_DesireS_S510e Build/GRI40) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1601,
                "Mozilla/5.0 (Linux; U; Android 2.3.3; de-de; HTC Desire Build/GRI40) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1602,
                "Mozilla/5.0 (Linux; U; Android 2.3.3; de-ch; HTC Desire Build/FRF91) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1603,
                "Mozilla/5.0 (Linux; U; Android 2.2; fr-lu; HTC Legend Build/FRF91) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1604,
                "Mozilla/5.0 (Linux; U; Android 2.2; en-sa; HTC_DesireHD_A9191 Build/FRF91) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1605,
                "Mozilla/5.0 (Linux; U; Android 2.2.1; fr-fr; HTC_DesireZ_A7272 Build/FRG83D) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1606,
                "Mozilla/5.0 (Linux; U; Android 2.2.1; en-gb; HTC_DesireZ_A7272 Build/FRG83D) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1607,
                "Mozilla/5.0 (Linux; U; Android 2.2.1; en-ca; LG-P505R Build/FRG83) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1608,
                "Mozilla/5.0 (Linux; U; Android 2.2.1; de-de; HTC_Wildfire_A3333 Build/FRG83D) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            UseragentsDictionary.TryAdd(1609,
                "Mozilla/5.0 (Linux; U; Android 1.6; ar-us; SonyEricssonX10i Build/R2BA026) AppleWebKit/528.5+ (KHTML, like Gecko) Version/3.1.2 Mobile Safari/525.20.1");
            UseragentsDictionary.TryAdd(1610,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9850; en-US) AppleWebKit/534.11+ (KHTML, like Gecko) Version/7.0.0.115 Mobile Safari/534.11+");
            UseragentsDictionary.TryAdd(1611,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; zh-TW) AppleWebKit/534.8+ (KHTML, like Gecko) Version/6.0.0.448 Mobile Safari/534.8+");
            UseragentsDictionary.TryAdd(1612,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; zh-TW) AppleWebKit/534.1+ (KHTML, like Gecko) Version/6.0.0.246 Mobile Safari/534.1+");
            UseragentsDictionary.TryAdd(1613,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; tr) AppleWebKit/534.1+ (KHTML, like Gecko) Version/6.0.0.246 Mobile Safari/534.1+");
            UseragentsDictionary.TryAdd(1614,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; fr) AppleWebKit/534.1+ (KHTML, like Gecko) Version/6.0.0.246 Mobile Safari/534.1+");
            UseragentsDictionary.TryAdd(1615,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en-US) AppleWebKit/534.8+ (KHTML, like Gecko) Version/6.0.0.466 Mobile Safari/534.8+");
            UseragentsDictionary.TryAdd(1616,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en-US) AppleWebKit/534.8+ (KHTML, like Gecko) Version/6.0.0.450 Mobile Safari/534.8+");
            UseragentsDictionary.TryAdd(1617,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en-US) AppleWebKit/534.8+ (KHTML, like Gecko) Version/6.0.0.448 Mobile Safari/534.8+");
            UseragentsDictionary.TryAdd(1618,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en-US) AppleWebKit/534.8+ (KHTML, like Gecko) Version/6.0.0.446 Mobile Safari/534.8+");
            UseragentsDictionary.TryAdd(1619,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en-US) AppleWebKit/534.1+ (KHTML, like Gecko) Version/6.0.0.201 Mobile Safari/534.1+");
            UseragentsDictionary.TryAdd(1620,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en-US) AppleWebKit/534.1+ (KHTML, like Gecko)");
            UseragentsDictionary.TryAdd(1621,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en-GB) AppleWebKit/534.1+ (KHTML, like Gecko) Version/6.0.0.337 Mobile Safari/534.1+");
            UseragentsDictionary.TryAdd(1622,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en) AppleWebKit/534.8+ (KHTML, like Gecko) Version/6.0.0.448 Mobile Safari/534.8+");
            UseragentsDictionary.TryAdd(1623,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9700; pt) AppleWebKit/534.8+ (KHTML, like Gecko) Version/6.0.0.546 Mobile Safari/534.8+");
            UseragentsDictionary.TryAdd(1624,
                "Mozilla/5.0 (BlackBerry; U; BlackBerry 9700; en-US) AppleWebKit/534.8+ (KHTML, like Gecko) Version/6.0.0.546 Mobile Safari/534.8+");
            UseragentsDictionary.TryAdd(1625,
                "BlackBerry9800/5.0.0.862 Profile/MIDP-2.1 Configuration/CLDC-1.1 VendorID/331 UNTRUSTED/1.0 3gpp-gba");
            UseragentsDictionary.TryAdd(1626,
                "BlackBerry9700/5.0.0.862 Profile/MIDP-2.1 Configuration/CLDC-1.1 VendorID/331 UNTRUSTED/1.0 3gpp-gba");
            UseragentsDictionary.TryAdd(1627,
                "BlackBerry9700/5.0.0.862 Profile/MIDP-2.1 Configuration/CLDC-1.1 VendorID/331");
            UseragentsDictionary.TryAdd(1628,
                "BlackBerry9700/5.0.0.862 Profile/MIDP-2.1 Configuration/CLDC-1.1 VendorID/167");
            UseragentsDictionary.TryAdd(1629,
                "BlackBerry9700/5.0.0.862 Profile/MIDP-2.1 Configuration/CLDC-1.1 VendorID/120");
            UseragentsDictionary.TryAdd(1630,
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:7.0a1) Gecko/20110623 Firefox/7.0a1 Fennec/7.0a1");
            UseragentsDictionary.TryAdd(1631,
                "Mozilla/5.0 (Maemo; Linux armv7l; rv:6.0a1) Gecko/20110526 Firefox/6.0a1 Fennec/6.0a1");
            UseragentsDictionary.TryAdd(1632,
                "Mozilla/5.0 (Maemo; Linux armv7l; rv:6.0a1) Gecko/20110522 Firefox/6.0a1 Fennec/6.0a1");
            UseragentsDictionary.TryAdd(1633,
                "Mozilla/5.0 (Maemo; Linux armv7l; rv:6.0a1) Gecko/20110518 Firefox/6.0a1 Fennec/6.0a1");
            UseragentsDictionary.TryAdd(1634,
                "Mozilla/5.0 (Maemo; Linux armv7l; rv:6.0a1) Gecko/20110510 Firefox/6.0a1 Fennec/6.0a1");
            UseragentsDictionary.TryAdd(1635,
                "Mozilla/5.0 (Maemo; Linux armv7l; rv:5.0) Gecko/20110615 Firefox/5.0 Fennec/5.0");
            UseragentsDictionary.TryAdd(1636,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:5.0) Gecko/20110517 Firefox/5.0 Fennec/5.0");
            UseragentsDictionary.TryAdd(1637,
                "Mozilla/5.0 (Android; WOW64; Linux armv7l;rv:5.0) Gecko/20110603 Firefox/5.0 Fennec/5.0");
            UseragentsDictionary.TryAdd(1638,
                "Mozilla/5.0 (Android; Linux armv7l;rv:5.0) Gecko/20110603 Firefox/5.0 Fennec/5.0");
            UseragentsDictionary.TryAdd(1639,
                "Mozilla/5.0 (Android; Linux armv7l; rv:5.0) Gecko/20110615 Firefox/5.0 Fennec/5.0");
            UseragentsDictionary.TryAdd(1640,
                "Mozilla/5.0 (Android; Linux armv7l; rv:5.0) Gecko/20110614 Firefox/5.0 Fennec/5.0");
            UseragentsDictionary.TryAdd(1641,
                "Mozilla/5.0 (Android; Linux armv7l; rv:5.0) Gecko/20110517 Firefox/5.0 Fennec/5.0");
            UseragentsDictionary.TryAdd(1642, "Mozilla/5.0 (Android; Linux armv71; rv:5.0) Gecko/20110615 Fennec/5.0");
            UseragentsDictionary.TryAdd(1643,
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.2a1pre) Gecko/20110331 Firefox/4.2a1pre Fennec/4.1a1pre");
            UseragentsDictionary.TryAdd(1644,
                "Mozilla/5.0 (Android; Linux armv7l; rv:2.2a1pre) Gecko/20110403 Firefox/4.2a1pre Fennec/4.1a1pre");
            UseragentsDictionary.TryAdd(1645,
                "Mozilla/5.0 (Android; Linux armv7l; rv:2.2a1pre) Gecko/20110402 Firefox/4.2a1pre Fennec/4.1a1pre");
            UseragentsDictionary.TryAdd(1646,
                "Mozilla/5.0 (Maemo; Linux armv7l; rv:2.0b13pre) Gecko/20110315 Firefox/4.0b13pre Fennec/4.0b6pre");
            UseragentsDictionary.TryAdd(1647,
                "Mozilla/5.0 (Android; Linux armv7l; rv:2.0b9pre) Gecko/20110103 Firefox/4.0b9pre Fennec/4.0b4pre");
            UseragentsDictionary.TryAdd(1648,
                "Mozilla/5.0 (Maemo; Linux armv7l; rv:2.0b8pre) Gecko/20110328 Firefox/4.0b8pre Fennec/4.0b3pre");
            UseragentsDictionary.TryAdd(1649,
                "Mozilla/5.0 (X11; Linux x86_64; rv:2.0) Gecko/20110402 Firefox/4.0 Fennec/4.0b3");
            UseragentsDictionary.TryAdd(1650,
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b8) Gecko/20101221 Firefox/4.0b8 Fennec/4.0b3");
            UseragentsDictionary.TryAdd(1651,
                "Mozilla/5.0 (X11; Linux i686; rv:2.0b7pre) Gecko/20101103 Firefox/4.0b8pre Fennec/4.0b2");
            UseragentsDictionary.TryAdd(1652,
                "Mozilla/5.0 (X11; Linux i686; rv:2.1.1) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1653,
                "Mozilla/5.0 (X11; Linux i686 on x86_64; rv:2.1.1) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1654,
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.1.1) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1655,
                "Mozilla/5.0 (Windows NT 6.1; rv:2.1.1) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1656,
                "Mozilla/5.0 (Windows NT 6.0; rv:2.1.1) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1657,
                "Mozilla/5.0 (Windows NT 5.1; rv:2.1.1) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1658,
                "Mozilla/5.0 (Linux; U; Android 2.2; en-us; T-Mobile HTC_G2 Build/FRF91) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1659,
                "Mozilla/5.0 (Android; Linux armv7l; rv:2.1.1) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1660,
                "Mozilla/5.0 (Android; Linux armv7l; rv:2.1.1) Gecko/20110415 Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1661,
                "Mozilla/5.0 (Android; Linux arm7l; rv:2.1.1) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1662,
                "Mozilla/5.0 (Android; Linux arm71; rv:2.1.1) Gecko/20110415 Firefox/4.0.2pre Fennec/4.0.1");
            UseragentsDictionary.TryAdd(1663,
                "Mozilla/5.0 (X11; Linux i686; rv:2.1) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0");
            UseragentsDictionary.TryAdd(1664,
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2.13) Gecko/20101203 Mozilla/5.O(Android;Linux armv7l;rv:2.1) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0 ( .NET CLR 3.5.30729)");
            UseragentsDictionary.TryAdd(1665,
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.1) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0");
            UseragentsDictionary.TryAdd(1666,
                "Mozilla/5.0 (Windows NT 6.1; rv:2.1) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0");
            UseragentsDictionary.TryAdd(1667,
                "Mozilla/5.0 (Windows NT 5.1; rv:2.1) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0");
            UseragentsDictionary.TryAdd(1668,
                "Mozilla/5.0 (Maemo; Linux armv7l; rv:2.1) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0");
            UseragentsDictionary.TryAdd(1669,
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.1) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0");
            UseragentsDictionary.TryAdd(1670, "Mozilla/5.0 (Linux arm) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0");
            UseragentsDictionary.TryAdd(1671,
                "Mozilla/5.0 (Android; Linux armv7l; rv:2.1) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0");
            UseragentsDictionary.TryAdd(1672,
                "Mozilla/5.0 (Android; Linux armv7l; rv:2.0) Gecko/20110103 Firefox/4.0 Fennec/4.0");
            UseragentsDictionary.TryAdd(1673,
                "Mozilla/5.0 (Android; Linux armv71; rv:2.1) Gecko/20110318 Firefox/4.0b13pre Fennec/4.0");
            UseragentsDictionary.TryAdd(1674, "Mozilla/5.0 (Android) Gecko/20110318 Firefox/4.0 Fennec/4.0");
            UseragentsDictionary.TryAdd(1675, "Mozilla/5.0 (Android) Gecko Firefox Fennec/4.0");
            UseragentsDictionary.TryAdd(1676,
                "Mozilla/5.0 (compatible; MSIE 9.0; Windows Phone OS 7.5; Trident/5.0; IEMobile/9.0)");
            UseragentsDictionary.TryAdd(1677,
                "HTC_Touch_3G Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; IEMobile 7.11)");
            UseragentsDictionary.TryAdd(1678,
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows Phone OS 7.0; Trident/3.1; IEMobile/7.0; Nokia;N70)");
            UseragentsDictionary.TryAdd(1679,
                "Mozilla/5.0 (X11; U; Linux armv7l; ru-RU; rv:1.9.2.3pre) Gecko/20100723 Firefox/3.5 Maemo Browser 1.7.4.8 RX-51 N900");
            UseragentsDictionary.TryAdd(1680,
                "Mozilla/5.0 (X11; U; Linux armv7l; pt-PT; rv:1.9.2.3pre) Gecko/20100723 Firefox/3.5 Maemo Browser 1.7.4.8 RX-51 N900");
            UseragentsDictionary.TryAdd(1681,
                "Mozilla/5.0 (X11; U; Linux armv7l; no-NO; rv:1.9.2.3pre) Gecko/20100723 Firefox/3.5 Maemo Browser 1.7.4.8 RX-51 N900");
            UseragentsDictionary.TryAdd(1682,
                "SAMSUNG-C5212/C5212XDIK1 NetFront/3.4 Profile/MIDP-2.0 Configuration/CLDC-1.1");
            UseragentsDictionary.TryAdd(1683,
                "MozillaMozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.5 (screen 824x1200;rotate)");
            UseragentsDictionary.TryAdd(1684,
                "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.5 (screen 824x1200;rotate)");
            UseragentsDictionary.TryAdd(1685,
                "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.5 (screen 824x1200; rotate)");
            UseragentsDictionary.TryAdd(1686,
                "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.5 (screen 600x800; rotate)");
            UseragentsDictionary.TryAdd(1687,
                "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.5 (screen 1200x824; rotate)");
            UseragentsDictionary.TryAdd(1688,
                "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.3 (screen 600x800; rotate)");
            UseragentsDictionary.TryAdd(1689,
                "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.3 (screen 1200x824; rotate)");
            UseragentsDictionary.TryAdd(1690,
                "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.1 (screen 824x1200; rotate)");
            UseragentsDictionary.TryAdd(1691,
                "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.0 (screen 824x1200; rotate)");
            UseragentsDictionary.TryAdd(1692,
                "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.0 (screen 600x800)");
            UseragentsDictionary.TryAdd(1693,
                "Mozilla/4.0 (compatible; Linux 2.6.10) NetFront/3.4 Kindle/1.0 (screen 600x800)");
            UseragentsDictionary.TryAdd(1694,
                "SonyEricssonK800c/R8BF Browser/NetFront/3.3 Profile/MIDP-2.0 Configuration/CLDC-1.1");
            UseragentsDictionary.TryAdd(1695,
                "SonyEricssonK530i/R6BA Browser/NetFront/3.3 Profile/MIDP-2.0 Configuration/CLDC-1.1");
            UseragentsDictionary.TryAdd(1696,
                "SonyEricssonK530c/R8BA Browser/NetFront/3.3 Profile/MIDP-2.0 Configuration/CLDC-1.1");
            UseragentsDictionary.TryAdd(1697,
                "SonyEricssonK510c/R4EA Browser/NetFront/3.3 Profile/MIDP-2.0 Configuration/CLDC-1.1");
            UseragentsDictionary.TryAdd(1698,
                "Mozilla/4.0 (compatible; Linux 2.6.10) NetFront/3.3 Kindle/1.0 (screen 600x800)");
            UseragentsDictionary.TryAdd(1699,
                "Opera/9.80 (J2ME/MIDP; Opera Mini/9.80 (S60; SymbOS; Opera Mobi/23.348; U; en) Presto/2.5.25 Version/10.54");
            UseragentsDictionary.TryAdd(1700,
                "Opera/9.80 (J2ME/MIDP; Opera Mini/9.80 (S60; SymbOS; Opera Mobi/23.334; U; id) Presto/2.5.25 Version/10.54");
            UseragentsDictionary.TryAdd(1701,
                "Opera/9.80 (J2ME/MIDP; Opera Mini/9.80 (J2ME/23.377; U; en) Presto/2.5.25 Version/10.54");
            UseragentsDictionary.TryAdd(1702,
                "Opera/9.80 (J2ME/MIDP; Opera Mini/9.80 (J2ME/22.478; U; en) Presto/2.5.25 Version/10.54");
            UseragentsDictionary.TryAdd(1703,
                "Opera/9.80 (J2ME/MIDP; Opera Mini/9 (Compatible; MSIE:9.0; iPhone; BlackBerry9700; AppleWebKit/24.746; U; en) Presto/2.5.25 Version/10.54");
            UseragentsDictionary.TryAdd(1704,
                "Opera/9.80 (Series 60; Opera Mini/6.24096/25.657; U; id) Presto/2.5.25 Version/10.54");
            UseragentsDictionary.TryAdd(1705,
                "Opera/9.80 (J2ME/MIDP; Opera Mini/6.24093/25.657; U; id) Presto/2.5.25 Version/10.54");
            UseragentsDictionary.TryAdd(1706,
                "Opera/9.80 (J2ME/MIDP; Opera Mini/6.1.25378/25.677; U; th) Presto/2.5.25 Version/10.54");
            UseragentsDictionary.TryAdd(1707,
                "Opera/9.80 (Android; Opera Mini/6.1.25375/25.657; U; es) Presto/2.5.25 Version/10.54");
            UseragentsDictionary.TryAdd(1708,
                "Opera/9.80 (Android;Opera Mini/6.0.24212/24.746 U;en) Presto/2.5.25 Version/10.5454");
            UseragentsDictionary.TryAdd(1709,
                "Opera/9.80 (Android 2.3.4; Linux; Opera Mobi/build-1107180945; U; en-GB) Presto/2.8.149 Version/11.10");
            UseragentsDictionary.TryAdd(1710,
                "Opera/9.80 (S60; SymbOS; Opera Mobi/SYB-1104061449; U; da) Presto/2.7.81 Version/11.00");
            UseragentsDictionary.TryAdd(1711,
                "Opera/9.80 (S60; SymbOS; Opera Mobi/SYB-1103211396; U; es-LA) Presto/2.7.81 Version/11.00");
            UseragentsDictionary.TryAdd(1712,
                "Opera/9.80 (Android; Linux; Opera Mobi/ADR-1012221546; U; pl) Presto/2.7.60 Version/10.5");
            UseragentsDictionary.TryAdd(1713,
                "Opera/9.80 (Android 2.2;;; Linux; Opera Mobi/ADR-1012291359; U; en) Presto/2.7.60 Version/10.5");
            UseragentsDictionary.TryAdd(1714,
                "Opera/9.80 (Android 2.2; Opera Mobi/ADR-2093533608; U; pl) Presto/2.7.60 Version/10.5");
            UseragentsDictionary.TryAdd(1715,
                "Opera/9.80 (Android 2.2; Opera Mobi/-2118645896; U; pl) Presto/2.7.60 Version/10.5");
            UseragentsDictionary.TryAdd(1716,
                "Opera/9.80 (Android 2.2; Linux; Opera Mobi/ADR-2093533312; U; pl) Presto/2.7.60 Version/10.5");
            UseragentsDictionary.TryAdd(1717,
                "Opera/9.80 (Android 2.2; Linux; Opera Mobi/ADR-2093533120; U; pl) Presto/2.7.60 Version/10.5");
            UseragentsDictionary.TryAdd(1718,
                "Opera/9.80 (Android 2.2; Linux; Opera Mobi/8745; U; en) Presto/2.7.60 Version/10.5");
            UseragentsDictionary.TryAdd(1719,
                "Opera/9.80 (S60; SymbOS; Opera Mobi/1209; U; sk) Presto/2.5.28 Version/10.1");
            UseragentsDictionary.TryAdd(1720,
                "Opera/9.80 (S60; SymbOS; Opera Mobi/1209; U; fr) Presto/2.5.28 Version/10.1");
            UseragentsDictionary.TryAdd(1721,
                "Opera/9.80 (S60; SymbOS; Opera Mobi/1181; U; en-GB) Presto/2.5.28 Version/10.1");
            UseragentsDictionary.TryAdd(1722,
                "Opera/9.80 (Android; Linux; Opera Mobi/ADR-1012211514; U; en) Presto/2.6.35 Version/10.1");
            UseragentsDictionary.TryAdd(1723,
                "Opera/9.80 (Android; Linux; Opera Mobi/ADR-1011151731; U; de) Presto/2.5.28 Version/10.1");
            UseragentsDictionary.TryAdd(1724,
                "Opera/9.80 (S60; SymbOS; Opera Mobi/498; U; sv) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1725,
                "Opera/9.80 (S60; SymbOS; Opera Mobi/447; U; en) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1726,
                "Mozilla/4.0 (compatible; Windows Mobile; WCE; Opera Mobi/WMD-50433; U; de) Presto/2.4.13 Version/10.00");
            UseragentsDictionary.TryAdd(1727,
                "Opera/9.80 (Android; Linux; Opera Mobi/ADR-1012272315; U; pl) Presto/2.7.60 Version/10.5");
            UseragentsDictionary.TryAdd(1728,
                "Opera/9.80 (Windows NT 6.1; Opera Mobi/49; U; en) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1729,
                "Opera/9.80 (Windows NT 6.0; Opera Mobi/49; U; en) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1730,
                "Opera/9.80 (Windows NT 5.1; Opera Mobi/49; U; en) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1731,
                "Opera/9.80 (Windows Mobile; WCE; Opera Mobi/49; U; en) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1732,
                "Opera/9.80 (Macintosh; Intel Mac OS X; Opera Mobi/3730; U; en) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1733,
                "Opera/9.80 (Macintosh; Intel Mac OS X; Opera Mobi/27; U; en) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1734,
                "Opera/9.80 (Linux i686; Opera Mobi/1040; U; en) Presto/2.5.24 Version/10.00");
            UseragentsDictionary.TryAdd(1735,
                "Opera/9.80 (Linux i686; Opera Mobi/1038; U; en) Presto/2.5.24 Version/10.00");
            UseragentsDictionary.TryAdd(1736,
                "Opera/9.80 (Android; Linux; Opera Mobi/49; U; en) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1737,
                "Opera/9.80 (Android; Linux; Opera Mobi/27; U; en) Presto/2.4.18 Version/10.00");
            UseragentsDictionary.TryAdd(1738,
                "Mozilla/5.0 (S60; SymbOS; Opera Mobi/SYB-1103211396; U; es-LA; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.00");
            UseragentsDictionary.TryAdd(1739,
                "Mozilla/5.0 (S60; SymbOS; Opera Mobi/1209; U; it; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.1");
            UseragentsDictionary.TryAdd(1740,
                "Mozilla/5.0 (S60; SymbOS; Opera Mobi/1181; U; en-GB; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.1");
            UseragentsDictionary.TryAdd(1741,
                "Mozilla/5.0 (Linux armv7l; Maemo; Opera Mobi/4; U; fr; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 10.1");
            UseragentsDictionary.TryAdd(1742,
                "Mozilla/5.0 (Linux armv6l; Maemo; Opera Mobi/8; U; en-GB; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.00");
            UseragentsDictionary.TryAdd(1743,
                "Mozilla/5.0 (Android 2.2.2; Linux; Opera Mobi/ADR-1103311355; U; en; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.00");
            UseragentsDictionary.TryAdd(1744,
                "Mozilla/4.0 (compatible; MSIE 8.0; Linux armv7l; Maemo; Opera Mobi/4; fr) Opera 10.1");
            UseragentsDictionary.TryAdd(1745,
                "Mozilla/4.0 (compatible; MSIE 8.0; Linux armv6l; Maemo; Opera Mobi/8; en-GB) Opera 11.00");
            UseragentsDictionary.TryAdd(1746,
                "Mozilla/4.0 (compatible; MSIE 8.0; Android 2.2.2; Linux; Opera Mobi/ADR-1103311355; en) Opera 11.00");
            UseragentsDictionary.TryAdd(1747,
                "Mozilla/4.0 (compatible; MSIE 6.0; S60; SymbOS; Opera Mobi/498; en) Opera 10.00");
            UseragentsDictionary.TryAdd(1748, "Mozilla/5.0 (PLAYSTATION 3; 3.55)");
            UseragentsDictionary.TryAdd(1749, "Mozilla/5.0 (PLAYSTATION 3; 2.00)");
            UseragentsDictionary.TryAdd(1750, "Mozilla/5.0 (PLAYSTATION 3; 1.90)");
            UseragentsDictionary.TryAdd(1751, "Mozilla/5.0 (PLAYSTATION 3; 1.70)");
            UseragentsDictionary.TryAdd(1752, "Mozilla/5.0 (PLAYSTATION 3; 1.5)");
            UseragentsDictionary.TryAdd(1753, "Mozilla/5.0 (PLAYSTATION 3; 1.10)");
            UseragentsDictionary.TryAdd(1754, "Mozilla/5.0 (PLAYSTATION 3; 1.00)");
            UseragentsDictionary.TryAdd(1755, "Mozilla/4.0 (PS3 (PlayStation 3); 1.00)");
            UseragentsDictionary.TryAdd(1756, "Mozilla/5.0 (PLAYSTATION 3; 1.0)");
            UseragentsDictionary.TryAdd(1757, "Mozilla/4.0 (PSP (PlayStation Portable); 2.00)");
        }

        public static string GetRandomUserAgent()
        {
            return UseragentsDictionary[new Random().Next(0, UseragentsDictionary.Count - 1)];
        }
    }
}