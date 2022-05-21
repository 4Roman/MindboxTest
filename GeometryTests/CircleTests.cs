using NUnit.Framework;
using Geometry.Circle;

namespace GeometryTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CalcSquare_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var circle = Circle.CreateInstance(0.0);

            // Act
            var result = circle.CalcSquare();

            // Assert
            Assert.Fail();
        }
    }
}
