using System;

namespace Timezone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow;
            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);
        }
    }
}


