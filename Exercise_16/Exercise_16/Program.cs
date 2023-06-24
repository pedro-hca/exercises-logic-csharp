using System;

namespace Exercise_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int alc = 0;
            int gas = 0;
            int dies = 0;

            while (num != 4)
            {
                if (num == 1)
                {
                    alc += 1;
                }
                else if (num == 2)
                {
                    gas += 1;
                }
                else if (num == 3)
                {
                    dies += 1;
                }
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alc}");
            Console.WriteLine($"Gasolina: {gas}");
            Console.WriteLine($"Diesel: {dies}");
        }
    }
}
