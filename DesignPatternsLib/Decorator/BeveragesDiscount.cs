using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.Decorator
{
    public class BeveragesDiscount : AddonDecorator
    {
        Beverages _beverages;
        public BeveragesDiscount(Beverages beverages)
        {
            _beverages = beverages;
        }

        public override double Cost()
        {
            return _beverages.Cost() - _beverages.Cost() / 10;
        }
    }

}
