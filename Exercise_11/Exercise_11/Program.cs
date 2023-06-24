using System;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);
            int resultado = 0;

            if (a < b)
            {
                resultado = b - a;
                Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
            }
            else
            {
                resultado = (24 - a) + b;
                Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
            }
        }
    }
}

