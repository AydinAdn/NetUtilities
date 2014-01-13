using System.Security.Cryptography;
using System.Text;
using Utilities.Extension;

namespace Utilities.Crypt
{
    public static class Hash512
    {
        public static string Create(string value)
        {
            var sha512 = SHA512.Create();
            var valueBytes = Encoding.UTF8.GetBytes(value);
            valueBytes = sha512.ComputeHash(valueBytes);

            return valueBytes.ConvertToString();
        }
    }
}
