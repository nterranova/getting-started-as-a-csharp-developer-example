using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.Structs
{
    public struct SPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static bool operator ==(SPoint left, SPoint right) => left.X == right.X && left.Y == right.Y;
        public static bool operator !=(SPoint left, SPoint right) => left.X != right.X || left.Y != right.Y;

        public override bool Equals(object? obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
