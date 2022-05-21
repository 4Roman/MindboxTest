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

        public static Circle CreateInstance(double r)
        {
            if (r < 0)
            {
                throw new IllegalCircleRadiusMustNotBeLessThanZeroException("Radius cannot be less than zero.",null,r);
            }
            return new Circle(r);
        }

        public double CalcSquare()
        {
            double S = Math.PI * _r*_r;
            return S;
        }
    }
}
