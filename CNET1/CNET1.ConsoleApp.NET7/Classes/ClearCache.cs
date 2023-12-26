using CNET1.ConsoleApp.NET7.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.Classes
{
    public class ClearCache : Script
    {
        public override string ScriptName { get => "Script - Clear Cache"; }

        public override void Run()
        {
            Console.WriteLine($"Running: {ScriptName}");
        }
        public new bool IsActive()
        {
            Console.WriteLine("I am running.");
            return true;
        }
    }
}
