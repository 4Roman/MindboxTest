using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Triangle
{
    public class IllegalTriangleAllSidesMustBeMoreThenZeroException : Exception
    {
        public IllegalTriangleAllSidesMustBeMoreThenZeroException(string message, Exception? innerException, double sideA, double sideB, double sideC) : base(message, innerException)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
    
    }
}
