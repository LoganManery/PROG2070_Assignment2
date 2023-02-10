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

        }

        [TestFixture]
        public class ScaleneTest
        {
            [Test]
            public void TriangleWithThreeUnequalSides_IsScalene()
            {
                // Arrange
                var triangle = new Triangle(4, 5, 6);

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
