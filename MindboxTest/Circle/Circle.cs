using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Circle
{
    public class Circle : IGeometricFigure
    {
        private readonly double _r;

        private Circle(double r)
        {
            this._r = r;
        }

        /// <summary>
        /// Creates an object of class Circle.
        /// </summary>
        /// <returns>
        /// Object of class Circle.
        /// </returns>
        /// <exception cref="Geometry.Circle.IllegalCircleRadiusMustNotBeLessThanOrEqualToZeroException">
        /// Thrown when parameter is equal to or less than zero.
        /// </exception>
        public static Circle CreateInstance(double r)
        {
            if (r <=0)
            {
                throw new IllegalCircleRadiusMustNotBeLessThanOrEqualToZeroException("Radius cannot be less or  zero.",null,r);
            }
            return new Circle(r);
        }

        /// <summary>
        /// Сalculates the area of a Circle
        /// </summary>
        /// <returns>
        /// Area of a Circle
        /// </returns>  
        public double CalcSquare()
        {
            double S = Math.PI * _r*_r;
            return S;
        }
    }
}
