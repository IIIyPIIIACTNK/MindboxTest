using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTFCalculator.Entities.Base
{
    public abstract class Shape : IShape
    {
        protected double[] _values;
        protected Shape(params double[] values)
        {
            _values = values;
            AbsValues();
        }
        public abstract double AreaOfTheFigure();
        private void AbsValues() 
        {
            for(int i = 0; i < _values.Length; i++)
            {
                _values[i] = Math.Abs(_values[i]);
            }
        }

        public abstract string ShapeName();
    }
}
