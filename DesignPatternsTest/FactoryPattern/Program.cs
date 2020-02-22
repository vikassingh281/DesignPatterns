using DesignPatterns.FactoryPattern;
using DesignPatterns.FactoryPattern.Factory;
using DesignPatterns.FactoryPattern.PaymentMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.FactoryPattern
{
    [TestClass]
    public class Program
    {
        private string expectedOutput = "'{0}' payment method selected.";

        public Program()
        {
        }

        [TestMethod]
        public void GooglePayMethodTest()
        {
            ExecuteFactory(PaymentMethodType.GooglePay);
        }

        [TestMethod]
        public void CodPaymentMethodTest()
        {
            ExecuteFactory(PaymentMethodType.CashOnDelivery);
        }

        [TestMethod]
        public void NetBankingMethodTest()
        {
            ExecuteFactory(PaymentMethodType.NetBanking);
        }

        [TestMethod]
        public void PhonePayMethodText()
        {
            ExecuteFactory(PaymentMethodType.PhonePay);
        }

        private void ExecuteFactory(PaymentMethodType methodType)
        {
            PaymentMethodFactory factory = null;
            if (methodType == PaymentMethodType.CashOnDelivery)
            {
                factory = new CodPaymentMethod();
            }
            else if (methodType == PaymentMethodType.GooglePay)
            {
                factory = new GooglePayPaymentMethod();
            }
            else if (methodType == PaymentMethodType.NetBanking)
            {
                factory = new NetBankingPaymentMethod();
            }
            else if (methodType == PaymentMethodType.PhonePay)
            {
                factory = new PhonePayPaymentMethod();
            }
            Assert.AreEqual(expected: string.Format(expectedOutput, methodType),
                            actual: factory.GetPaymentMethodType());
        }
    }
}
