using System;

namespace CSharp_Tips.Comparations
{
    public static class ConvertParse
    {
        /// <summary>
        /// O método Convert é usado para converter um valor para outro tipo de dados, 
        /// onde o valor de entrada pode ser nulo ou vazio, sem gerar exceções. 
        /// Se o valor de entrada for nulo, o método Convert retornará um valor padrão do tipo de dados de destino.
        /// O código converte o valor da string em um valor inteiro usando o método Convert.ToInt32. 
        /// Se o valor da string for nulo, o método retornará 0 (valor padrão para inteiros).
        /// </summary>
        public static int UsingConvert(string valorString)
        {
            int valorInteiro = Convert.ToInt32(valorString);
            return valorInteiro;
        }
        
        /// <summary>
        /// o método Parse é usado para converter uma string em outro tipo de dados, 
        /// mas o valor de entrada não pode ser nulo, caso contrário, uma exceção será gerada.
        /// O código converte o valor da string em um valor inteiro usando o método int.Parse. 
        /// Se o valor da string for nulo, uma exceção será gerada.
        /// </summary>
        public static int UsingParse(string valorString)
        {
            int valorInteiro = int.Parse(valorString);
            return valorInteiro;
        }

        /*
         Em resumo, o método Convert é usado para converter um valor de um tipo de dados para outro, 
        e pode lidar com valores nulos ou vazios sem gerar exceções, enquanto o método Parse é usado para converter uma string em outro tipo de dados, 
        mas exige que o valor de entrada não seja nulo ou vazio.
        Para aplicar esses métodos, basta chamar o método correspondente e passar o valor que se deseja converter como parâmetro. 
        Se o tipo de dados de origem não for compatível com o tipo de destino, uma exceção será gerada. 
        Por isso, é importante verificar se os dados de entrada estão corretos antes de chamar esses métodos, para evitar exceções desnecessárias.
         */


        /*
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
         */
    }
}
