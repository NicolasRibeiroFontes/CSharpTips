using CSharp_Tips.Collections;
using CSharp_Tips.SOLID.InterfaceSegregationPrinciple.Problem;
using CSharp_Tips.SOLID.InterfaceSegregationPrinciple.Solution;
using CSharp_Tips.Tools;
using System;

namespace CSharp_Tips
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            DifferenceBetweenLists diff = new DifferenceBetweenLists();
            diff.Start();

            Console.WriteLine("End Program");
            Console.ReadKey();
        }
    }

    

    
}
