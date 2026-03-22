using System;


namespace SolidCalculator
{
    public class Calculator
    {
        public double Execute(IOperation operation, double a, double b)
        {
            return operation.Calculate(a, b);
        }
    }
}
