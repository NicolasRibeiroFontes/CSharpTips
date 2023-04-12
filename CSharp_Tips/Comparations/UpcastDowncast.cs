using System;

namespace CSharp_Tips.Comparations
{
    /// <summary>
    /// Upcast e Downcast são termos usados em programação orientada a objetos que se referem à conversão de tipos de dados entre classes relacionadas por herança em .NET.
    /// Em resumo, upcast é a conversão de uma classe derivada para uma classe base, e downcast é a conversão de uma classe base para uma classe derivada.
    /// Ambos são usados para converter objetos entre classes relacionadas por herança em.NET.
    /// </summary>
    public static class UpcastDowncast
    {
        /// <summary>
        /// Upcast é a conversão de um objeto de uma classe derivada para um objeto de sua classe base. Isso é feito implicitamente pelo compilador, e não há perda de dados ou informações.
        /// No código abaixo, o objeto mamifero da classe derivada Mamifero é atribuído à variável animal da classe base Animal usando upcast implícito.
        /// Isso é possível porque Mamifero herda de Animal e, portanto, um objeto da classe derivada pode ser tratado como um objeto da classe base.
        /// </summary>
        public static void Upcast()
        {
            Mammal mammal = new Mammal() { Head = "Big", NumberOfPaws = 4, MammaryGlands = "Boobs" };

            Animal animal = mammal;

            Console.WriteLine(animal.Head);
        }

        /// <summary>
        /// Já o Downcast é a conversão de um objeto de uma classe base para um objeto de sua classe derivada. 
        /// Isso deve ser feito explicitamente pelo programador, pois pode haver perda de dados ou informações se o objeto não for da classe derivada esperada.
        /// No código abaixo, o objeto animal da classe base Animal é atribuído à variável mamifero da classe derivada Mamifero usando downcast explícito. 
        /// Isso é possível porque animal é na verdade um objeto da classe derivada Mamifero.No entanto, o downcast deve ser feito com cuidado, 
        /// pois se o objeto não for da classe derivada esperada, pode ocorrer uma exceção em tempo de execução.
        /// </summary>
        public static void Downcast()
        {
            Animal animal = new Mammal() { Head = "Big", NumberOfPaws = 4, MammaryGlands = "Boobs" };

            Mammal mammal = (Mammal)animal;

            Console.WriteLine(mammal.MammaryGlands);
        }

    }


    public class Animal
    {
        public string Head { get; set; }
        public int NumberOfPaws { get; set; }
    }

    public class Mammal : Animal
    {
        public string MammaryGlands { get; set; }
    }
}

