using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips.SOLID.OpenClosedPrinciple.Solution
{
    class Solution
    {
    }

    public abstract class Calculator
    {
        public abstract int Execute(int value1, int value2);
    }

    public class Subtract : Calculator
    {
        public override int Execute(int value1, int value2)
        {
            return value1 - value2;
        }
    }

    public class Sum : Calculator
    {
        public override int Execute(int value1, int value2)
        {
            return value1 + value2;
        }
    }

    public class Divide : Calculator
    {
        public override int Execute(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}
