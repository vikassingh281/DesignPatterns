using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibity.Imp
{
    public class MulNumberHandler : BaseHandler
    {
        public override object ProcessRequest(Request request)
        {
            CalculatorModel calculator = (CalculatorModel)request.Data;
            if (calculator.CalculationType == CalculationType.Mul)
            {
                return calculator.FNumber * calculator.SNumber;
            }
            else
                return Handler.ProcessRequest(request);
        }
    }
}
