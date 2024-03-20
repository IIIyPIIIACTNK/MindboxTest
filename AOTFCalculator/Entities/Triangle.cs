using AOTFCalculator.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTFCalculator.Entities
{
    public class Triangle : Shape
    {

        public Triangle(double[] values) : base(values) 
        {
        }
        public override double AreaOfTheFigure()
        {
            double halfPerimeter = (base._values[0] + base._values[1] + base._values[2]) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - base._values[0]) * (halfPerimeter - base._values[1]) * (halfPerimeter - base._values[2]));
        }

        public override string ShapeName()
        {
            return "Треугольник";
        }
    }
}
