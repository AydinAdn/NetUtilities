using System;
using System.Linq;
using System.Security.Cryptography;

namespace Utilities.Crypt
{
    public static class RngStringProvider
    {
        private static readonly char[] Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToArray();

        /// <summary>
        ///     Generates a truly random string using RNGCryptoServiceProvider with alphanumeric characters 
        /// </summary>
        /// <param name="length">Length of the string to be created</param>
        /// <returns>Generated string</returns>
        public static string GenerateString(int length)
        {
            string chars = "";
            for (int i = 0; i < length; i++)
            {
                var rng = new RNGCryptoServiceProvider();
                var bits = new Byte[1];

                do { rng.GetNonZeroBytes(bits); } while (bits[0] > 248);

                chars += Characters[bits[0] % Characters.Length];
            }
            return chars;
        }

        /// <summary>
        ///      Generates a truly random string using RNGCryptoServiceProvider with alphanumeric characters 
        /// </summary>
        /// <param name="length">Length of the string to be created</param>
        /// <param name="characters">The characters to use while generating the string</param>
        /// <returns>Generated string</returns>
        public static string GenerateString(int length, char[] characters)
        {
            string chars = "";
            for (int i = 0; i < length; i++)
            {
                var rng = new RNGCryptoServiceProvider();
                var bits = new Byte[1];

                do { rng.GetNonZeroBytes(bits); } while (bits[0] > 248);

                chars += characters[bits[0] % characters.Length];
            }
            return chars;
        }
    }
}
