using CNET1.ConsoleApp.NET7.Interfaces;
using CNET1.ConsoleApp.NET7.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.BaseClasses
{
    public class Employee : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }
        public int EmployeeId { get; set; }
        public DateOnly StartDate { get; set; }
        public TimeOnly ShiftStartTime { get; set; }
    }
}
