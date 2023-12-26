using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.StaticClasses
{
    public static class DynamicExample
    {
        public static void SomeMethod()
        {
            dynamic someVariable = new { FirstName = "Some", LastName = "Name" };
            try
            {
                Console.WriteLine(someVariable.Surname);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
