using DesignPatternsLib.FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.FactoryPattern.PaymentMethod
{
    public class CodPaymentMethod : PaymentMethodFactory
    {
        public override PaymentMethodType PaymentMethodType => PaymentMethodType.CashOnDelivery;
    }
}
