using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips.SOLID.LiskovSubstitutionPrinciple.Solution
{
    public class Solution
    {
        public static void Run()
        {
            var square = new Retancgle(9,8);

            GetParallelogramArea(square);
        }

        private static void GetParallelogramArea(Parallelogram retancgle)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Paralelograma");
            Console.WriteLine();
            Console.WriteLine(retancgle.Heigth + " * " + retancgle.Width);
            Console.WriteLine();
            Console.WriteLine(retancgle.Area);
            Console.ReadKey();
        }
    }

    public class Parallelogram
    {
        protected Parallelogram(int heigth, int width)
        {
            Heigth = heigth;
            Width = width;
        }

        public double Heigth { get; private set; }
        public double Width { get; private set; }
        public double Area { get { return Heigth * Width; } }
    }

    public class Retancgle : Parallelogram
    {
        public Retancgle(int heigth, int width)
            : base(heigth, width)
        {

        }
    }

    public class Square : Parallelogram
    {
        public Square(int heigth, int width)
            : base(heigth, width)
        {
            if (width != heigth)
                throw new ArgumentException("Both side need are equal");
        }
    }
}
