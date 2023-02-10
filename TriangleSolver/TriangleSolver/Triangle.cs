using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
    public class Triangle
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public string AnalyzeTriangle()
        {
            string output;
            if ((_sideA == 0) || (_sideB == 0) || (_sideC == 0))
            {
                output = "At least one side of your triangle has a zero length and is thus invalid";
                return output;
            }

                if (((_sideA + _sideB) > _sideC) && ((_sideA + _sideC) > _sideB) && ((_sideB + _sideC) > _sideA))
                {
                    if ((_sideA == _sideB) && (_sideA == _sideC) && (_sideB == _sideC))
                    {
                        output = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
                    }

                    else if ((_sideA == _sideB) || (_sideB == _sideC) || (_sideC == _sideA))
                    {
                        output = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                    }

                    else
                    {
                        output = "Based on all three sides being different, the type of triangle is a SCALENE";

                    }
                }
                else
                {
                    output = "Based on the values entered, the triangle is INVALID";
                }

            
            return output;
        }
    }
}
