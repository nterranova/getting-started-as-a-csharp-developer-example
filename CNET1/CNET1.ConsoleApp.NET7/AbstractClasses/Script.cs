// Ignore Spelling: App CNET

using CNET1.ConsoleApp.NET7.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.AbstractClasses
{
    public abstract class Script : ILaunchableProcess
    {
        public DateTime StartTime { get; set; }

        public Process LaunchProcess()
        {
            Console.WriteLine("Process started");
            StartTime = DateTime.Now;
            return new Process();
        }

        public virtual DateTime EndTime { get; set; }

        public abstract string ScriptName { get; }

        public abstract void Run();

        public virtual void Terminate()
        {
            Console.WriteLine("Script terminated before completing.");
            EndTime = DateTime.Now;
        }

        public bool IsActive()
        {
            Console.WriteLine("Checking if script is currently running...");
            return true;
        }
    }
}
