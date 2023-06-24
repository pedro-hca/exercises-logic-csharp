using System;

namespace Exercise_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= num; i++)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
