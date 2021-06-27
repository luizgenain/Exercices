using System;

namespace cond01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("NÚMERO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÚMERO NÃO NEGATIVO");
            }
        }
    }
    
}
