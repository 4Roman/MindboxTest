using Geometry;
using Geometry.Triangle;
using NUnit.Framework;
using System;
using static Geometry.Calculations;

namespace GeometryTests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(1.0, 1.0, 1.0, 0.433)]
        [TestCase(5.0, 3.0, 4.0, 6.0)]
        [TestCase(7.0, 8.0, 5.0, 17.321)]
        [TestCase(2.0, 1.0, 1.5, 0.726)]
        public void CalcSquare_Triangle_1_1_1_ShouldReturn_0_433(double a, double b, double c, double d)
        {
            // Arrange
            var triangle = Triangle.CreateInstance(a, b, c);

            // Act
            var result = triangle.CalcSquare();

            // Assert
            Assert.AreEqual(d, result, EpsilonD);
        }

        [TestCase(-1.0, 1.0, 1.0)]
        [TestCase(1.0, -1.0, 1.0)]
        [TestCase(1.0, 1.0, -1.0)]
        [TestCase(0.0, 0.0, 0.0)]
        public void CalcSquare_Triangle_ShouldThrowAllSidesMustBeMoreThenZeroException(double a, double b, double c)
        {
            // Assert
            Assert.Throws<Geometry.Triangle.IllegalTriangleAllSidesMustBeMoreThenZeroException>(() =>
            {
                var triangle = Triangle.CreateInstance(a, b, c);
                var result = triangle.CalcSquare();
            });
        }

        [TestCase(1.0, 1.0, 2.0)]
        [TestCase(3.0, 5.0, 1.0)]
        [TestCase(11.0, 0.5, 10.0)]
        [TestCase(7.0, 4.0, 2.0)]
        public void CalcSquare_Triangle_ShouldThrowOneSideMustBeLessThenSumOfOtherSidesException(double a, double b, double c)
        {            
            // Assert
            Assert.Throws<Geometry.Triangle.IllegalTriangleOneSideMustBeLessThenSumOfOtherSidesException>(() =>
            {
                var triangle = Triangle.CreateInstance(a, b, c);
                var result = triangle.CalcSquare();
            });
        }

        [TestCase(3.0, 4.0, 2.0)]
        [TestCase(3.0, 5.0, 4.5)]
        [TestCase(10.0, 1.0, 10.0)]
        [TestCase(7.0, 4.0, 5.0)]
        public void IsRightTriangle_ShouldReturnFalse(double a, double b, double c)
        {

            // Arrange
            var triangle = Triangle.CreateInstance(a, b, c);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(result);
        }

        [TestCase(3.0, 4.0, 5.0)]
        [TestCase(1.0, 2.0, 2.236)]
        [TestCase(3.0, 2.0, 3.60555127)]
        [TestCase(5.0, 7.0, 8.60232526)]
        public void IsRightTriangle_ShouldReturnTrue(double a, double b, double c)
        {

            // Arrange
            var triangle = Triangle.CreateInstance(a, b, c);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
