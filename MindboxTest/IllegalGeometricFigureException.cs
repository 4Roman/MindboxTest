using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Triangle
{
    public abstract class IllegalGeometricFigureException : Exception
    {
        public IllegalGeometricFigureException(string message, Exception? innerException) : base(message, innerException)
        {
        }
    }
    
}
