using AOTFCalculator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTFCalculator.Tests
{
    public class TriangleTests
    {

        [Fact]
        public void CorrectValuesShouldReturn_True()
        {
            var triangle = new Triangle(new double[] {25,25,48});

            var result = triangle.AreaOfTheFigure();

            Assert.Equal(168, result);
        }
        [Theory]
        [InlineData(25,25,-48)]
        [InlineData(25, -25, -48)]
        [InlineData(-25, -25, -48)]
        [InlineData(-25, -25, 48)]
        [InlineData(-25, 25, 48)]
        [InlineData(25, -25, 48)]
        [InlineData(-25, 25, -48)]
        public void NegativeValuesShoudReturn_True(double valueOne, double valueTwo, double valueThree)
        {
            var triangle = new Triangle(new double[] {valueOne,valueTwo,valueThree});

            var result = triangle.AreaOfTheFigure();

            Assert.Equal(168, result);
        }
        [Theory]
        [InlineData(10.5, 10.5, 10.5)]
        public void FractionNumbersShouldReturn_True_WithRoundingToWholeNumbers(double valueOne, double valueTwo, double valueThree)
        {
            var triangle = new Triangle(new double[] { valueOne, valueTwo, valueThree });

            var result = Math.Round(triangle.AreaOfTheFigure());

            Assert.Equal(48, result);
        }
    }
}
