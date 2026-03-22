using System;

namespace SolidCalculator.Operations
{
    public class Division : IOperation
    {
        public double Calculate(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Can't Divide by zero");
            }

            return a / b;
        }
    }
}
