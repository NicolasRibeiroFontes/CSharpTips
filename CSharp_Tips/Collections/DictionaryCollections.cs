using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips.Collections
{
    public class DictionaryCollections
    {
        public void Start()
        {
            //Numbers();
            //Countries();
            Do("+");
            Do("*");
            Do("/");
        }

        private void Numbers()
        {
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(10, "Ten");
            numberNames.Add(20, "Twenty");
            numberNames.Add(30, "Thirty");
            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }

        private void Countries()
        {
            var continents = new Dictionary<string, string>(){
                {"America", "Brazil, Chile, Argentina"},
                {"Europe", "Ireland, Italy, Spain"},
                {"Asia", "China, Japan, Thailand"}
            };
            Console.WriteLine(continents["Europe"]);

            continents.Remove("Asia"); // removes Asia 

            if (continents.ContainsKey("America"))
            {
                Console.WriteLine(continents["America"]);
            }

            if (continents.TryGetValue("Europee", out string result))
            {
                Console.WriteLine(result);
            }
        }

        private void Do(string parameter)
        {
            var actions = new Dictionary<string, Action<int, int>>(){
            {"+", Somar},
            {"-", Subtrair},
            {"/", Dividir},
            {"*", Multiplicar}
        };
            actions[parameter].Invoke(10, 5);
        }

        private void Somar(int valueA, int valueB)
        {
            Console.WriteLine("Somando.." + (valueA + valueB));
        }

        private void Subtrair(int valueA, int valueB)
        {
            Console.WriteLine("Subtraindo..." + (valueA - valueB));
        }

        private void Dividir(int valueA, int valueB)
        {
            Console.WriteLine("Dividindo.." + (valueA / valueB));
        }

        private void Multiplicar(int valueA, int valueB)
        {
            Console.WriteLine("Multiplicando.." + (valueA * valueB));
        }
    }
}
