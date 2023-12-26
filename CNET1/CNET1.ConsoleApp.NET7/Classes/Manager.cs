using CNET1.ConsoleApp.NET7.BaseClasses;
using CNET1.ConsoleApp.NET7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.Classes
{
    public class Manager : Employee, IPerson
    {
        public Manager() : base(firstName: "unknown first name", lastName: "unknown last name")
        {

        }
        public Manager(string firstName, string lastName) : base("unknown first name", "unknown last name")
        {

        }

        public int NumberOfDirectReports { get; set; }
    }
}
