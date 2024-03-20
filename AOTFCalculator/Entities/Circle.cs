using AOTFCalculator.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTFCalculator.Entities
{
    public class Circle : Shape
    {
        private readonly double _radius;
        public Circle(double radius)
        {
           _radius = Math.Abs(radius);
        }
        public override double AreaOfTheFigure()
        {
            return Math.Pow(_radius,2) * 3.14;
        }

        public override string ShapeName()
        {
            return "Круг";
        }
    }
}
