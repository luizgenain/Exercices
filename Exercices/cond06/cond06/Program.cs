using System;

namespace cond06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            double n = double.Parse(Console.ReadLine());

            if (n < 0 || n > 100)
            {
                Console.WriteLine("Fora do intervalo");
            }
            else if (n <= 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (n <= 50)
            {
                Console.WriteLine("Intervalo ( 25, 50]");
            }
            else if (n <= 75)
            {
                Console.WriteLine("Intervalo (50, 75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75, 100]");
            }
        }
    }
}
