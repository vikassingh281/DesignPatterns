using DesignPatternsLib.Decorator;
using DesignPatternsLib.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Decorator
{
    [TestClass]
    public class Program
    {
        private ColdCoffee coldCoffee = null;
        static Program()
        {
        }

        [TestMethod]
        public void GetBeveragesCostTest()
        {
            coldCoffee = new ColdCoffee(cost: 200);
            Assert.AreEqual(expected: 200, actual: coldCoffee.Cost());
        }

        [TestMethod]
        public void GetDiscountedBeveragesCostTest()
        {
            coldCoffee = new ColdCoffee(cost: 200);
            BeveragesDiscount beveragesDiscount = new BeveragesDiscount(coldCoffee);
            Assert.AreEqual(expected: 180, actual: beveragesDiscount.Cost());
        }
    }
}
