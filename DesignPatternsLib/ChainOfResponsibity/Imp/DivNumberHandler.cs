using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.ChainOfResponsibity.Imp
{
    public class DivNumberHandler : BaseHandler
    {
        public override object ProcessRequest(Request request)
        {
            CalculatorModel calculator = (CalculatorModel)request.Data;
            if (calculator.CalculationType == CalculationType.Div)
            {
                return calculator.FNumber / calculator.SNumber;
            }
            else
                return Handler.ProcessRequest(request);
        }
    }

}
