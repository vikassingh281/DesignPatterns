using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.Decorator
{
    public class ColdCoffee : Beverages
    {
        private readonly double _cost = 0;

        public ColdCoffee(double cost)
        {
            _cost = cost;
        }

        public override double Cost()
        {
            return _cost;
        }

    }
}
