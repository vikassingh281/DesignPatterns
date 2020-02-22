using DesignPatternsLib.ChainOfResponsibity;
using DesignPatternsLib.ChainOfResponsibity.Imp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.ChainOfResponsibity
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void AddNumbersTest()
        {
            Request request = new Request(new CalculatorModel(10, 20, CalculationType.Add));
            AddNumberHandler addNumbersHandler = new AddNumberHandler();
            SubNumberHandler subNumbersHandler = new SubNumberHandler();
            MulNumberHandler mulNumbersHandler = new MulNumberHandler();
            DivNumberHandler divNumbersHandler = new DivNumberHandler();

            addNumbersHandler.SetHandler(subNumbersHandler);
            subNumbersHandler.SetHandler(mulNumbersHandler);
            mulNumbersHandler.SetHandler(divNumbersHandler);

            Assert.AreEqual(expected: 30, actual: (double)addNumbersHandler.ProcessRequest(request));
        }

        [TestMethod]
        public void SubNumbersTest()
        {
            Request request = new Request(new CalculatorModel(10, 20, CalculationType.Sub));
            AddNumberHandler addNumbersHandler = new AddNumberHandler();
            SubNumberHandler subNumbersHandler = new SubNumberHandler();
            MulNumberHandler mulNumbersHandler = new MulNumberHandler();
            DivNumberHandler divNumbersHandler = new DivNumberHandler();

            addNumbersHandler.SetHandler(subNumbersHandler);
            subNumbersHandler.SetHandler(mulNumbersHandler);
            mulNumbersHandler.SetHandler(divNumbersHandler);

            Assert.AreEqual(expected: -10, actual: (double)addNumbersHandler.ProcessRequest(request));
        }

        [TestMethod]
        public void MulNumbersTest()
        {
            Request request = new Request(new CalculatorModel(10, 20, CalculationType.Mul));
            AddNumberHandler addNumbersHandler = new AddNumberHandler();
            SubNumberHandler subNumbersHandler = new SubNumberHandler();
            MulNumberHandler mulNumbersHandler = new MulNumberHandler();
            DivNumberHandler divNumbersHandler = new DivNumberHandler();

            addNumbersHandler.SetHandler(subNumbersHandler);
            subNumbersHandler.SetHandler(mulNumbersHandler);
            mulNumbersHandler.SetHandler(divNumbersHandler);

            Assert.AreEqual(expected: 200, actual: (double)addNumbersHandler.ProcessRequest(request));
        }

        [TestMethod]
        public void DivNumbersTest()
        {
            Request request = new Request(new CalculatorModel(10, 20, CalculationType.Div));
            AddNumberHandler addNumbersHandler = new AddNumberHandler();
            SubNumberHandler subNumbersHandler = new SubNumberHandler();
            MulNumberHandler mulNumbersHandler = new MulNumberHandler();
            DivNumberHandler divNumbersHandler = new DivNumberHandler();

            addNumbersHandler.SetHandler(subNumbersHandler);
            subNumbersHandler.SetHandler(mulNumbersHandler);
            mulNumbersHandler.SetHandler(divNumbersHandler);

            Assert.AreEqual(expected: 0.5, (double)addNumbersHandler.ProcessRequest(request));
        }
    }
}
