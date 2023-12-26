using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.RecordClasses
{
    public record class PremiereCustomer : Customer
    {
        public byte CustomerLevel { get; init; }

    }
}
