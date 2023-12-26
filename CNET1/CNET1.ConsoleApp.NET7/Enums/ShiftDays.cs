using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.Enums
{
    [Flags]
    public enum ShiftDays : short
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Weekdays = 63,
        Saturday = 64,
        Weekend = 65,
        AllDays = 127
    }
}
