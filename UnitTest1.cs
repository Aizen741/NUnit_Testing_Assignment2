using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolver.Tests
{
    [TestFixture]
    public class TriangleTestings
    {
        // Valid Equilateral Triangle ~ Testing

        [Test]
        public void CheckTriangle_ValidEquilateral_ReturnEquilateral()
        {
            // Arrange
            int firstSide = 4, secondSide = 4, thirdSide = 4;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is an EQUILATERAL"));
        }

        // Valid Isosceles Triangles ~ Testing

        [Test]
        public void CheckTriangle_ValidIsosceles_ReturnIsosceles1()
        {
            // Arrange
            int firstSide = 6, secondSide = 7, thirdSide = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is an ISOSCELES"));
        }

        [Test]
        public void CheckTriangle_ValidIsosceles_ReturnIsosceles2()
        {
            // Arrange
            int firstSide = 7, secondSide = 7, thirdSide = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is an ISOSCELES"));
        }

        [Test]
        public void CheckTriangle_ValidIsosceles_ReturnIsosceles3()
        {
            // Arrange
            int firstSide = 7, secondSide = 6, thirdSide = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is an ISOSCELES"));
        }

        // Valid Scalene Triangles ~ Testing

        [Test]
        public void AnalyzeTriangle_ValidScalene1_ReturnsScalene()
        {
            // Arrange
            int firstSide = 3, secondSide = 4, thirdSide = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is a SCALENE"));
        }

        [Test]
        public void AnalyzeTriangle_ValidScalene2_ReturnsScalene()
        {
            // Arrange
            int firstSide = 5, secondSide = 6, thirdSide = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is a SCALENE"));
        }

        [Test]
        public void AnalyzeTriangle_ValidScalene3_ReturnsScalene()
        {
            // Arrange
            int firstSide = 8, secondSide = 15, thirdSide = 17;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is a SCALENE"));
        }

        [Test]
        public void AnalyzeTriangle_ValidScalene4_ReturnsScalene()
        {
            // Arrange
            int firstSide = 7, secondSide = 24, thirdSide = 25;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is a SCALENE"));
        }

        [Test]
        public void AnalyzeTriangle_ValidScalene5_ReturnsScalene()
        {
            // Arrange
            int firstSide = 9, secondSide = 40, thirdSide = 41;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is formed and it is a SCALENE"));
        }

        // Valid Zero Length Sides ~ Testing

        [Test]
        public void CheckTriangle_OneSideZero_ReturnInvalid()
        {
            // Arrange
            int firstSide = 0, secondSide = 5, thirdSide = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("INVALID triangle - a zero was entered"));
        }

        [Test]
        public void CheckTriangle_TwoSidesZero_ReturnInvalid()
        {
            // Arrange
            int firstSide = 0, secondSide = 0, thirdSide = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("INVALID triangle - a zero was entered"));
        }


        [Test]
        public void CheckTriangle_ThreeSidesZero_ReturnInvalid()
        {
            // Arrange
            int firstSide = 0, secondSide = 0, thirdSide = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("INVALID triangle - a zero was entered"));
        }


        // Invalid Triangles (not related to zero length)
        [Test]
        public void AnalyzeTriangle_InvalidTriangle1_ReturnsNotFormed()
        {
            // Arrange
            int firstSide = 1, secondSide = 2, thirdSide = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is not formed based on the input values"));
            
        }

        [Test]
        public void AnalyzeTriangle_InvalidTriangle2_ReturnsNotFormed()
        {
            // Arrange
            int firstSide = 10, secondSide = 2, thirdSide = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert

            Assert.That(result, Is.EqualTo("A triangle is not formed based on the input values"));
        }

        [Test]
        public void AnalyzeTriangle_InvalidTriangle3_ReturnsNotFormed()
        {
            // Arrange
            int firstSide = 3, secondSide = 5, thirdSide = 9;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("A triangle is not formed based on the input values"));
        }
    

    }
}
