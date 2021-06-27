using System;

namespace cond03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com 2 números inteiros: ");
            string[] valores = Console.ReadLine().Split(' ');
            int n1 = int.Parse(valores[0]);
            int n2 = int.Parse(valores[1]);
            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }
        }
    }
}
