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
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("Convert (10): " + ConvertParse.UsingConvert("10"));
            }
            stopwatch.Stop();
            Console.WriteLine("End Program" + stopwatch.Elapsed);
            Console.ReadKey();
        }
    }

    

    
}
