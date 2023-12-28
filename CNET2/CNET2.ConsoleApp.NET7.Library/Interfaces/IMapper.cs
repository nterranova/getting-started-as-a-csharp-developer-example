using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET2.ConsoleApp.NET7.Library.Interfaces
{
    public interface IMapper<S, T>
    {
        T Map(S source);
    }
}
