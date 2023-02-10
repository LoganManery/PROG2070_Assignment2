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

        }

        [TestFixture]
        public class InvalidTest
        {

        }
    }
}
