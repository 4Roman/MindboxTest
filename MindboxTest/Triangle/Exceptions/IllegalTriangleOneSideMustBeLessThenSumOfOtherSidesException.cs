using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Triangle
{
    public class IllegalTriangleOneSideMustBeLessThenSumOfOtherSidesException : IllegalTriangleBaseException
    {
        public IllegalTriangleOneSideMustBeLessThenSumOfOtherSidesException(string message, Exception? innerException, double sideA, double sideB, double sideC) : base(message, innerException)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}
