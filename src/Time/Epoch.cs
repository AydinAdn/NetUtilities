using System;
using System.Globalization;

namespace Utilities.Time
{
    public class Epoch
    {
        public static string Get()
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var span = (DateTime.UtcNow - epoch);
            return ((int)span.TotalSeconds / 7800).ToString(CultureInfo.InvariantCulture);
        }
    }
}
