using NUnit.Framework;
using Geometry.Circle;
using System;

namespace GeometryTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CalcSquare_Circle_0_ShouldReturn_0()
        {
            // Arrange
            var circle = Circle.CreateInstance(0);

            // Act
            var result = circle.CalcSquare();

            // Assert
            Assert.AreEqual(0.0, result, 0.001);
        }

        [Test]
        public void CalcSquare_Circle_1_ShouldReturn_Pi()
        {
            // Arrange
            var circle = Circle.CreateInstance(1);

            // Act
            var result = circle.CalcSquare();

            // Assert
            Assert.AreEqual(Math.PI, result, 0.001);
        }

        [Test]
        public void CalcSquare_Circle_3_ShouldReturn_9Pi()
        {
            // Arrange
            var circle = Circle.CreateInstance(3);

            // Act
            var result = circle.CalcSquare();

            // Assert
            Assert.AreEqual(9*Math.PI, result, 0.001);
        }

        [Test]
        public void CalcSquare_Circle_minus_1_ShouldReturn_IllegalCircleRadiusMustNotBeLessThanZeroException()
        {
            // Assert
            Assert.Throws<Geometry.Circle.IllegalCircleRadiusMustNotBeLessThanZeroException>(() =>
            {
                var triangle = Circle.CreateInstance(-1);
                var result = triangle.CalcSquare();
            });
        }




    }
}
