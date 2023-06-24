using System;
using System.Globalization;

namespace Exercise_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int x = int.Parse(num[0]);
            int y = int.Parse(num[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else
                {
                    Console.WriteLine("terceiro");
                }
                num = Console.ReadLine().Split(' ');
                x = int.Parse(num[0]);
                y = int.Parse(num[1]);
            }
            Console.WriteLine("coordenada nula");
        }
    }
}
