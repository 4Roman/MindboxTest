using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Triangle
{
    public abstract class IllegalTriangleBaseException : IllegalGeometricFigureException
    {
        public IllegalTriangleBaseException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
    }
}
