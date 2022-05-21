using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Circle
{
    public class IllegalCircleRadiusMustNotBeLessThanZeroException : Exception
    {
        public IllegalCircleRadiusMustNotBeLessThanZeroException(string message, Exception? innerException, double radius) : base(message, innerException)
        {
            Radius = radius;
        }

        public double Radius { get; }
    
    }
}
