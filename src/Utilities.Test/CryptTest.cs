using System.Diagnostics;
using NUnit.Framework;
using Utilities.Crypt;

namespace Utilities.Test
{
    [TestFixture]
    public class CryptTest
    {
        [TestCase]
        public void Can_Encrypt()
        {
            Debug.Assert(
                Hash.CalculateSHA1("Example") == "0F01ED56A1E32A05E5EF96E4D779F34784AF9A96",
                "SHA1 hash value is incorrect");

            Debug.Assert(
                Hash.CalculateSHA256("Example") == "D029F87E3D80F8FD9B1BE67C7426B4CC1FF47B4A9D0A8461C826A59D8C5EB6CD",
                "SHA256 hash value is incorrect");

            Debug.Assert(
                Hash.CalculateSHA384("Example") ==
                "FE27713A5276ADEF1D34169ED04C52B299BB792BEF7C903127893A53C07D910D5FCAAE18DE99164882A200192B236B14",
                "SHA384 hash value is incorrect");

            Debug.Assert(
                Hash.CalculateSHA512("Example") ==
                "C6B0919C7FE628AE9056992C4A917E5DC035A9615D497F6EB2BD14063EAAD3E6508EFC8682FEC82823CA3F3DE311868A72990946166429F01B38F9F33D9CA610",
                "SHA512 hash value is incorrect");
        }

        [TestCase]
        public void Can_GenerateRandomString()
        {
            for (int i = 0; i < 100; i++)
            {
                string firstRandomString  = RngStringProvider.GenerateString(12);
                string secondRandomString = RngStringProvider.GenerateString(12);

                Debug.Assert(firstRandomString         != secondRandomString, "Strings are not random");
                Debug.Assert(firstRandomString.Length  == 12,                 "First string length is incorrect");
                Debug.Assert(secondRandomString.Length == 12,                 "Second string length is incorrect");
            }
        }
    }
}