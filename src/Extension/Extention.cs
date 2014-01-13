using System;

namespace Utilities.Extension
{
    public static class Extension
    {
        public static string ConvertToString(this Byte[] array)
        {
            var str = "";
            int i;
            for (i = 0; i < array.Length; i++)
            {
                str += String.Format("{0:X2}", array[i]);
            }
            return str;
        }
    }
}
