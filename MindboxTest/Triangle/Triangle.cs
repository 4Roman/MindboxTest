//Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
//Дополнительно к работоспособности оценим:
//Юнит-тесты
//Легкость добавления других фигур
//Вычисление площади фигуры без знания типа фигуры в compile-time
//Проверку на то, является ли треугольник прямоугольным

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

        public double CalcSquare()
        {               
            double p = (_a + _b + _c) / 2;
            double S = Math.Sqrt(p*(p-_a)*(p-_b)*(p-_c));
            return S;
        }
    }
}