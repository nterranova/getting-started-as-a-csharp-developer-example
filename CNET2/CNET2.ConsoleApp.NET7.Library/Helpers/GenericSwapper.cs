using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET2.ConsoleApp.NET7.Library.Helpers
{
    public static class GenericSwapper
    {
        public static void SwapObjects<T>(ref T object1, ref T object2)
        {
            T tempObject = object1;
            object1 = object2;
            object2 = tempObject;
        }
    }
}
