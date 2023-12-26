using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.RecordStructs
{
    public record struct Order
    {
        public int OrderId { get; set; }
        public DateOnly OrderDate { get; set; }
    }
}
