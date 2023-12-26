using CNET1.ConsoleApp.NET7.BaseClasses;
using CNET1.ConsoleApp.NET7.Enums;
using CNET1.ConsoleApp.NET7.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.Structs
{
    public struct Age
    {
        public Age()
        {
            BirthDate = DateTime.MinValue;
            YearsOld = 0;
        }
        public Age(DateTime birthDate, int yearsOld)
        {
            BirthDate = birthDate;
            YearsOld = yearsOld;
        }
        public DateTime BirthDate { get; set; }
        public int YearsOld { get; set; }
    }

    public class AgeTester : BaseCodeTester, ILaunchableProcess
    {
        public Process LaunchProcess()
        {
            RunTester();
            Console.WriteLine($"Tester result is: {testerResult}");
            return new Process();
        }

        public override void RunTester()
        {
            var age = new Age();
            int? years = null;
            age.YearsOld = years ?? 5;
            Console.WriteLine($"Age is {age.YearsOld}");
        }
    }
}
