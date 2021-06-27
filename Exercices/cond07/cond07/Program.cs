using System;
using System.Globalization;

namespace cond07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cordenadas = Console.ReadLine().Split(' ');
            double x = double.Parse(cordenadas[0], CultureInfo.InvariantCulture);
            double y = double.Parse(cordenadas[1], CultureInfo.InvariantCulture);

            if (x == 0 & y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 & y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 & y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 & y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
