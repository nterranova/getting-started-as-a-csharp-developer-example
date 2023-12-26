using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.StaticClasses
{
    public static class Constants
    {
        public static string connectionString;
        public static readonly string CONFIG_SERVER_NAME = "TargetServer";
        public const string CONFIG_DB_NAME = "db";

        public static DateTime GetDateTimeFromDateOnly(DateOnly dateOnly)
        {
            return new DateTime(dateOnly.Year, dateOnly.Month, dateOnly.Day);
        }
        static Constants()
        {
            connectionString = string.Empty;
        }
    }
}
