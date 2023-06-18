using System;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Intervalo();
        }

        static void Intervalo()
        {

            Console.Clear();
            Console.WriteLine("Digite a quantidade de numeros: ");
            int n = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");

        }
    }
}