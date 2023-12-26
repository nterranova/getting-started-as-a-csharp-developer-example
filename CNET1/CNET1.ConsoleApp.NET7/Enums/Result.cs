using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.Enums
{
    public enum Result
    {
        Success = 1,
        Failed = 2,
        NotCompleted = 4,
        InProgress = 8,
        Unknown = 16,
        None = 32
    }
}
