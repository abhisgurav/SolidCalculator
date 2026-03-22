using System;

namespace SolidCalculator.Operations
{
    public class Multiplication : IOperation
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}
