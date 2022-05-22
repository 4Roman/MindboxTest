using NUnit.Framework;
using Geometry.Circle;
using System;
using static Geometry.Calculations;

namespace GeometryTests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(1.0,Math.PI)]
        [TestCase(0.5,0.25*Math.PI)]
        [TestCase(10.0,100*Math.PI)]
        [TestCase(3.0,9*Math.PI)]
        public void CalcSquare_Circle_ShouldReturn_True(double r, double S)
        {
            // Arrange
            var circle = Circle.CreateInstance(r);

            // Act
            var result = circle.CalcSquare();

            // Assert
            Assert.AreEqual(S, result, EpsilonD);
        }

        [TestCase(0.0)]
        [TestCase(-1.0)]
        [TestCase(-0.2)]
        [TestCase(-6.2)]
        [TestCase(-12.0)]        
        public void CalcSquare_Circle_ShouldThrow_IllegalCircleRadiusMustNotBeLessThanOrEqualToZeroException(double r)
        {
            // Assert
            Assert.Throws<Geometry.Circle.IllegalCircleRadiusMustNotBeLessThanOrEqualToZeroException>(() =>
            {
                var triangle = Circle.CreateInstance(r);
                var result = triangle.CalcSquare();
            });
        }




    }
}
