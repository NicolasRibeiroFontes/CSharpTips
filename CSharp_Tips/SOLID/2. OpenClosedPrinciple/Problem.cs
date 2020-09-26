using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips.SOLID.OpenClosedPrinciple.Problem
{
    public class Problem
    {
        private readonly Calculator calculator = new Calculator();

        public void Start()
        {
            calculator.Execute(5, 3, Operation.Sum);
        }
    }

    public class Calculator
    {
        public int Execute(int value1, int value2, Operation operation)
        {
            int result = 0;

            if (operation == Operation.Sum)
                result = value1 + value2;

            if (operation == Operation.Subtract)
                result = value1 - value2;

            return result;
        }
    }

    public enum Operation
    {
        Sum,
        Subtract
    }
}
