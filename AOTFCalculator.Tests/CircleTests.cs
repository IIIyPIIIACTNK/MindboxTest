using AOTFCalculator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTFCalculator.Tests
{
    public class CircleTests
    {

        [Fact]
        public void CorrectValuesShouldResturn_True()
        {
            var circle = new Circle(2);

            var result = circle.AreaOfTheFigure();

            Assert.Equal(12.56, result);
        }

        [Fact]
        public void NegativeValuesShouldReturn_True()
        {
            var circle = new Circle(-2);

            var result = circle.AreaOfTheFigure();

            Assert.Equal(12.56, result);
        }
        [Fact]
        public void FractionNumbersShouldReturn_True_WithRoundingToWholeNumbers()
        {
            var circle = new Circle(2.14);

            var result = circle.AreaOfTheFigure();

            Assert.Equal(14.379944, result);
        }

    }
}
