using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolver.Tests
{
    [TestFixture]
    public class TriangleTestings

    {
        // One Valid Equilateral Triangle ~ Testing

        [Test]
        public void Is_Equilateral()
        {
            // Arrange
            int firstSide = 4, secondSide = 4, thirdSide = 4;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is an EQUILATERAL"));
        }

        // Three Valid Isosceles Triangle ~ Testing

        [Test]
        public void Is_Isosceles1()
        {
            // Arrange
            int firstSide = 6, secondSide = 7, thirdSide = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is an ISOSCELES"));
        }

        [Test]
        public void Is_Isosceles2()
        {
            // Arrange
            int firstSide = 7, secondSide =7, thirdSide = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is an ISOSCELES"));
        }

        [Test]
        public void Is_Isosceles3()
        {
            // Arrange
            int firstSide = 7, secondSide = 6, thirdSide = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is an ISOSCELES"));
        }




    }
}

