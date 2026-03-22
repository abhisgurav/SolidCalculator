using System;

namespace SolidCalculator.Operations
{
    public class Addition : IOperation
    {
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}
