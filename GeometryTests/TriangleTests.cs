﻿using Geometry;
using Geometry.Triangle;
using NUnit.Framework;

namespace GeometryTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void CalcSquare_Triangle_1_1_1_ShouldReturn_0_433()
        {
            // Arrange
            var triangle = Triangle.CreateInstance(1, 1, 1);

            // Act
            var result = triangle.CalcSquare();

            // Assert
            Assert.AreEqual(0.433, result, 0.001);
        }

        [Test]
        public void CalcSquare_Triangle_0_1_1_ShouldThrowException()
        {
            // Assert
            Assert.Throws<Geometry.Triangle.IllegalTriangleAllSidesMustBeMoreThenZeroException>(() =>
            {
                var triangle = Triangle.CreateInstance(0, 1, 1);
                var result = triangle.CalcSquare();
            });
        }
        [Test]
        public void CalcSquare_Triangle_1_2_3_ShouldThrowException()
        {            
            // Assert
            Assert.Throws<Geometry.Triangle.IllegalTriangleOneSideMustBeLessThenSumOfOtherSidesException>(() =>
            {
                var triangle = Triangle.CreateInstance(1, 2, 3);
                var result = triangle.CalcSquare();
            });
        }

        [Test]
        public void CheckForSquareness_Triangle_1_2_3_ShouldReturnFalse()
        {

            // Arrange
            var triangle = Triangle.CreateInstance(2, 3, 4);

            // Act
            var result = triangle.CheckForSquareness();

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckForSquareness_Triangle_3_4_5_ShouldReturnTrue()
        {

            // Arrange
            var triangle = Triangle.CreateInstance(3, 4, 5);

            // Act
            var result = triangle.CheckForSquareness();

            // Assert
            Assert.IsTrue(result);
        }


    }
}
