using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.ChainOfResponsibity
{
    public class CalculatorModel
    {
        public readonly double FNumber;
        public readonly double SNumber;
        public readonly CalculationType CalculationType;

        public CalculatorModel(double fNumber, double sNumber, CalculationType calculateType)
        {
            FNumber = fNumber;
            SNumber = sNumber;
            CalculationType = calculateType;
        }
    }
}
