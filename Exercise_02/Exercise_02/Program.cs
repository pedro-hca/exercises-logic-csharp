using System;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator();
        }
        static void AreaCalculator()
        {
            Console.Clear();

            double pi = 3.14159;
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double area = pi * (Math.Pow(raio, 2));

            Console.Write("A= " + area.ToString("F2"));

        }
    }
}