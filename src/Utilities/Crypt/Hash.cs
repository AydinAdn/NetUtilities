using System.Security.Cryptography;
using System.Text;
using Utilities.Extension;

namespace Utilities.Crypt
{
    /// <summary>
    ///     Calculates hash value of any given string
    /// </summary>
    public static class Hash
    {
        public static string CalculateSHA512(string value)
        {
            SHA512 sha512     = SHA512.Create();
            byte[] valueBytes = Encoding.UTF8.GetBytes(value);
            valueBytes        = sha512.ComputeHash(valueBytes);

            return valueBytes.ConvertToString();
        }

        public static string CalculateSHA384(string value)
        {
            SHA384 sha384     = SHA384.Create();
            byte[] valueBytes = Encoding.UTF8.GetBytes(value);
            valueBytes        = sha384.ComputeHash(valueBytes);

            return valueBytes.ConvertToString();
        }

        public static string CalculateSHA256(string value)
        {
            SHA256 sha256     = SHA256.Create();
            byte[] valueBytes = Encoding.UTF8.GetBytes(value);
            valueBytes        = sha256.ComputeHash(valueBytes);

            return valueBytes.ConvertToString();
        }

        public static string CalculateSHA1(string value)
        {
            SHA1 sha1         = SHA1.Create();
            byte[] valueBytes = Encoding.UTF8.GetBytes(value);
            valueBytes        = sha1.ComputeHash(valueBytes);

            return valueBytes.ConvertToString();
        }

        public static string CalculateSHA512(string value, Encoding encoding)
        {
            SHA512 sha512     = SHA512.Create();
            byte[] valueBytes = encoding.GetBytes(value);
            valueBytes        = sha512.ComputeHash(valueBytes);

            return valueBytes.ConvertToString();
        }

        public static string CalculateSHA384(string value, Encoding encoding)
        {
            SHA384 sha384     = SHA384.Create();
            byte[] valueBytes = encoding.GetBytes(value);
            valueBytes        = sha384.ComputeHash(valueBytes);

            return valueBytes.ConvertToString();
        }

        public static string CalculateSHA256(string value, Encoding encoding)
        {
            SHA256 sha256     = SHA256.Create();
            byte[] valueBytes = encoding.GetBytes(value);
            valueBytes        = sha256.ComputeHash(valueBytes);

            return valueBytes.ConvertToString();
        }

        public static string CalculateSHA1(string value, Encoding encoding)
        {
            SHA1 sha1         = SHA1.Create();
            byte[] valueBytes = encoding.GetBytes(value);
            valueBytes        = sha1.ComputeHash(valueBytes);

            return valueBytes.ConvertToString();
        }
    }
}