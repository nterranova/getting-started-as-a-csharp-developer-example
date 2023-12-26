using CNET1.ConsoleApp.NET7.Interfaces;
using CNET1.ConsoleApp.NET7.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.RecordClasses
{
    public record class Customer : IPerson
    {
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }
        public string FirstName { get; set; }
    }
}
