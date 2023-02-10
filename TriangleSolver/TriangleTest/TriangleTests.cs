using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Text.RegularExpressions;
using TriangleSolver;


namespace TriangleTest
{
    public class TriangleTests
    {
        [TestFixture]
        public class EquilateralTest
        {
            [Test]
            public void AnalyzeTriangle_ValidEquilateral_3_3_3()
            {
                // Arrange
                var triangle = new Triangle(3, 3, 3);

                // Act
                string equilateralRegex = @"EQUILATERAL$";
                Regex re = new Regex(equilateralRegex);
                bool isEquilateral = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isEquilateral);
            }

            [Test]
            public void AnalyzeTriangle_ValidEquilateral_5_5_5()
            {
                // Arrange
                var triangle = new Triangle(5, 5, 5);

                // Act
                string equilateralRegex = @"EQUILATERAL$";
                Regex re = new Regex(equilateralRegex);
                bool isEquilateral = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isEquilateral);
            }

            [Test]
            public void AnalyzeTriangle_ValidEquilateral_12_12_12()
            {
                // Arrange
                var triangle = new Triangle(12, 12, 12);

                // Act
                string equilateralRegex = @"EQUILATERAL$";
                Regex re = new Regex(equilateralRegex);
                bool isEquilateral = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isEquilateral);
            }
        }

        [TestFixture]
        public class IsoscelesTest
        {
            [Test]
            public void AnalyzeTriangle_ValidIsosceles_2_2_3()
            {
                // Arrange
                var triangle = new Triangle(2, 2, 3);

                // Act
                string isoscelesRegex = @"ISOSCELES$";
                Regex re = new Regex(isoscelesRegex);
                bool isIsosceles = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isIsosceles);
            }

            [Test]
            public void AnalyzeTriangle_ValidIsosceles_3_3_5()
            {
                // Arrange
                var triangle = new Triangle(3, 3, 5);

                // Act
                string isoscelesRegex = @"ISOSCELES$";
                Regex re = new Regex(isoscelesRegex);
                bool isIsosceles = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isIsosceles);
            }

            [Test]
            public void AnalyzeTriangle_ValidIsosceles_4_4_6()
            {
                // Arrange
                var triangle = new Triangle(4, 4, 6);

                // Act
                string isoscelesRegex = @"ISOSCELES$";
                Regex re = new Regex(isoscelesRegex);
                bool isIsosceles = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isIsosceles);
            }
        }

        [TestFixture]
        public class ScaleneTest
        {
            [Test]
            public void AnalyzeTriangle_ValidScalene_3_4_5()
            {
                // Arrange
                var triangle = new Triangle(3, 4, 5);

                // Act
                string scaleneRegex = @"SCALENE$";
                Regex re = new Regex(scaleneRegex);
                bool isScalene = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isScalene);
            }

            [Test]
            public void AnalyzeTriangle_ValidScalene_5_12_13() 
            {
                // Arrange
                var triangle = new Triangle(5, 12, 13);

                // Act
                string scaleneRegex = @"SCALENE$";
                Regex re = new Regex(scaleneRegex);
                bool isScalene = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isScalene);
            }

            [Test]
            public void AnalyzeTriangle_ValidScalene_8_15_17()
            {
                // Arrange
                var triangle = new Triangle(8, 15, 17);

                // Act
                string scaleneRegex = @"SCALENE$";
                Regex re = new Regex(scaleneRegex);
                bool isScalene = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isScalene);
            }

            [Test]
            public void AnalyzeTriangle_ValidScalene_7_24_25()
            {
                // Arrange
                var triangle = new Triangle(7, 24, 25);

                // Act
                string scaleneRegex = @"SCALENE$";
                Regex re = new Regex(scaleneRegex);
                bool isScalene = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isScalene);
            }

            [Test]
            public void AnalyzeTriangle_ValidScalene_10_24_26()
            {
                // Arrange
                var triangle = new Triangle(10, 24, 26);

                // Act
                string scaleneRegex = @"SCALENE$";
                Regex re = new Regex(scaleneRegex);
                bool isScalene = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isScalene);
            }
        }

        [TestFixture]
        public class ZeroTest
        {
            [Test]
            public void AnalyzeTriangle_ZeroLengthSideA_ReturnsInvalid()
            {
                // Arrange
                var triangle = new Triangle(0, 3, 4);

                // Act
                string invalidRegex = @"invalid$";
                Regex re = new Regex(invalidRegex);
                bool isInvalid = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isInvalid);
            }

            [Test]
            public void AnalyzeTriangle_ZeroLengthSideB_ReturnsInvalid()
            {
                // Arrange
                var triangle = new Triangle(2, 0, 4);

                // Act
                string invalidRegex = @"invalid$";
                Regex re = new Regex(invalidRegex);
                bool isInvalid = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isInvalid);
            }

            [Test]
            public void AnalyzeTriangle_ZeroLengthSideC_ReturnsInvalid()
            {
                // Arrange
                var triangle = new Triangle(2, 3, 0);

                // Act
                string invalidRegex = @"INVALID$";
                Regex re = new Regex(invalidRegex);
                bool isInvalid = re.IsMatch(triangle.AnalyzeTriangle());

                // Assert
                Assert.IsTrue(isInvalid);
            }
        }

        [TestFixture]
        public class InvalidTest
        {

        }
    }
}
