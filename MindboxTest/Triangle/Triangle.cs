using static Geometry.Calculations;
namespace Geometry.Triangle
{
    public class Triangle : IGeometricFigure
    {
        
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        private Triangle(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        /// <summary>
        /// Creates an object of class Triangle.
        /// </summary>
        /// <returns>
        /// Object of class Triangle.
        /// </returns>
        /// <exception cref="Geometry.Triangle.IllegalTriangleOneSideMustBeLessThenSumOfOtherSidesException">
        /// Thrown when one parameter is equal to or greater than the sum of the other two.
        /// </exception>
        /// <exception cref="Geometry.Triangle.IllegalTriangleAllSidesMustBeMoreThenZeroException">
        /// Thrown when one parameter is equal to or less than zero.
        /// is greater than 0.
        /// </exception> 
        public static Triangle CreateInstance(double a, double b, double c)
        {
            // TODO: проверка больше 0
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new IllegalTriangleAllSidesMustBeMoreThenZeroException(message: "All sides must be more then zero.", null, a, b, c);
            }
            else if (a >= (b + c) || b >= (a + c) || c >= (b + a))
            {
                throw new IllegalTriangleOneSideMustBeLessThenSumOfOtherSidesException(message: "A triangle with such sides does not exist.", null, a, b, c);
            }
            else return new Triangle(a, b, c);
        }


        /// <summary>
        /// Сalculates the area of a Triangle
        /// </summary>
        /// <returns>
        /// Area of a Triangle
        /// </returns>     
        public double CalcSquare()
        {               
            double p = (_a + _b + _c) / 2;
            double S = Math.Sqrt(p*(p-_a)*(p-_b)*(p-_c));
            return S;
        }

        /// <summary>
        /// Checks if a triangle is right
        /// </summary>
        /// <returns>
        /// True, if triangle is right; False, if not
        /// </returns>   
        public bool IsRightTriangle()
        {
            if (EqualTo(_b * _b, _a * _a + _c * _c) || EqualTo(_c * _c, _b * _b + _a * _a) || EqualTo(_a * _a, _b * _b + _c * _c))
            {
                return true;
            }
            else return false;
        }
        
    }
}