using System;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Baskara();
        }

        static void Baskara()
        {
            Console.WriteLine("Digite o valor do coeficiente a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do coeficiente b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do coeficiente c:");
            double c = double.Parse(Console.ReadLine());


            double delta = b * b - 4 * a * c;

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"X1 = {x1.ToString("F5")}");
                Console.WriteLine($"X2 = {x2.ToString("F5")}");
            }

        }
    }
}