using CNET1.ConsoleApp.NET7.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.BaseClasses
{
    public abstract class BaseCodeTester
    {
        public virtual Result testerResult { get; set; }
        public abstract void RunTester();
        public virtual void SetTesterResult()
        {
            dynamic result = Result.InProgress;
            if (result == Result.InProgress)
            {
                try
                {
                    RunTester();
                    testerResult = Result.Success;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    testerResult = Result.Failed;
                }
            }
            testerResult = Result.Unknown;
        }

    }
}
