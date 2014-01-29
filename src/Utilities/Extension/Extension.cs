using System;
using System.Text;

namespace Utilities.Extension
{
    public static class Extension
    {
        /// <summary>
        ///     Converts an array of bytes to a string
        /// </summary>
        public static string ConvertToString(this Byte[] array)
        {
            var stringBuilder = new StringBuilder();

            foreach (byte bite in array)
            {
                stringBuilder.Append(String.Format("{0:X2}", bite));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        ///     Converts the DateTime to Epoch time
        /// </summary>
        public static long ToUtcEpoch(this DateTime dateTime)
        {
            var epochBegan = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return (long) (DateTime.UtcNow - epochBegan).TotalSeconds;
        }

        /// <summary>
        ///     Converts epoch time to local date time
        /// </summary>
        public static DateTime ConvertEpochToLocalDateTime(this long seconds)
        {
            var epochBegan = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epochBegan.ToLocalTime().AddSeconds(seconds);
        }

        /// <summary>
        ///     Converts epoch time to UTC date time
        /// </summary>
        public static DateTime ConvertEpochToUtcDateTime(this long seconds)
        {
            var epochBegan = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epochBegan.AddSeconds(seconds);
        }
    }
}