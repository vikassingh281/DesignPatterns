using DesignPatternsLib.FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.FactoryPattern.PaymentMethod
{
    public class GooglePayPaymentMethod : PaymentMethodFactory
    {
        public override PaymentMethodType PaymentMethodType => PaymentMethodType.GooglePay;
    }
}
