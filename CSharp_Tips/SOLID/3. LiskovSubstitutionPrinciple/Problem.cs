using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips.SOLID.LiskovSubstitutionPrinciple.Problem
{
    public class Problem
    {
        public static void Run()
        {
            var quad = new Square()
            {
                Heigth = 10,
                Width = 5
            };

            GetRetancgleArea(quad);
        }

        private static void GetRetancgleArea(Retancgle retancgle)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(retancgle.Heigth + " * " + retancgle.Width);
            Console.WriteLine();
            Console.WriteLine(retancgle.Area);
            Console.ReadKey();
        }
    }

    public class Retancgle
    {
        public virtual double Heigth { get; set; }
        public virtual double Width { get; set; }
        public double Area { get { return Heigth * Width; } }
    }

    public class Square : Retancgle
    {
        public override double Heigth
        {
            set { base.Heigth = base.Width = value; }
        }

        public override double Width
        {
            set { base.Heigth = base.Width = value; }
        }
    }
}
