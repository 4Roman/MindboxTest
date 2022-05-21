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
            // TODO: proverkki

            return new Circle(r);
        }

        public double CalcSquare()
        {
            throw new NotImplementedException();
        }
    }
}
