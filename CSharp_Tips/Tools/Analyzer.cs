using System;
using System.Globalization;

namespace CSharp_Tips.Tools
{
    public static class Analyzer
    {
        private static readonly CultureInfo cultureInfo = new CultureInfo("pt-BR");
        public static void Start()
        {
            User user = new User
            {
                ID = 1,
                Name = "Nicolas Fontes"
            };

            Converting(1);

            Console.WriteLine(string.Concat("Analyzer Running: ", user.Name));
        }

        private static void Converting(int a)
        {
            string numberA = a.ToString(cultureInfo);
            int numberAA = int.Parse(numberA, cultureInfo);
            double numberDouble = double.Parse(numberA, cultureInfo);
            Console.WriteLine(numberAA);
            Console.WriteLine(numberDouble.ToString(cultureInfo));
        }
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}