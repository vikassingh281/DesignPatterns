using DesignPatternsLib.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Singleton
{
    [TestClass]
    public class Program
    {
        static readonly StringHelper _stringHelper;
        static Program()
        {
            _stringHelper = StringHelper.Instance;
        }

        [TestMethod]
        public void AppendStringTest()
        {
            _stringHelper.Append("Hello");
            Assert.AreEqual(expected: "Hello",
                            actual: _stringHelper.Value);

            _stringHelper.Append("World");
            Assert.AreEqual(expected: "Hello World",
                            actual: _stringHelper.Value);
        }

        [TestMethod]
        public void FlushStringTest()
        {
            _stringHelper.Flush();
            Assert.AreEqual(expected: string.Empty,
                            actual: _stringHelper.Value);
        }
    }
}
