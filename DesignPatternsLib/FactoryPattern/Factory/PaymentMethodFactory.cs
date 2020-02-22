using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.FactoryPattern.Factory
{
    public abstract class PaymentMethodFactory
    {
        public abstract PaymentMethodType PaymentMethodType { get; }

        public string GetPaymentMethodType()
        {
            return $"'{PaymentMethodType}' payment method selected.";
        }
    }
}
