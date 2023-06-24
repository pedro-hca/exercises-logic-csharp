using System;

namespace Exercise_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int a = i;
                int b = i * i;
                int c = i * i * i;
                Console.WriteLine($"{a} {b} {c}");
            }
        }
    }
}
