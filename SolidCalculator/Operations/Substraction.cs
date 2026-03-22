using System;

namespace SolidCalculator.Operations
{
    public class Subtraction : IOperation
    {
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}
