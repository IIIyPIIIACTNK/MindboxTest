using AOTFCalculator.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTFCalculator
{
    public static class ShapeFactory
    {
        public static Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public static Triangle CreateTriangle(double sideOne,double sideTwo,double sideThree)
        {
            return new Triangle(new double[] { sideOne, sideTwo, sideThree });
        }
    }
}
