using CSharp_Tips.Collections;
using CSharp_Tips.Comparations;
using CSharp_Tips.SOLID.InterfaceSegregationPrinciple.Problem;
using CSharp_Tips.SOLID.InterfaceSegregationPrinciple.Solution;
using CSharp_Tips.Tools;
using System;
using System.Diagnostics;

namespace CSharp_Tips
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            DifferenceBetweenRemovals.UsingRemove();
            DifferenceBetweenRemovals.UsingRemoveAll();
            DifferenceBetweenRemovals.UsingRemoveAt();
            DifferenceBetweenRemovals.UsingRemoveRange();

            Console.ReadKey();
        }
    }

    

    
}
