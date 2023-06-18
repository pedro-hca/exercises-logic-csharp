using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcula1();
        }

        static void Calcula1()
        {
            Console.Clear();

            Console.WriteLine("Digite o código da peça: ");
            int cod1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de peças desejada: ");
            int quantidade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário de cada peça");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código da peça: ");
            int cod2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de peças desejada: ");
            int quantidade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário de cada peça");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = (quantidade1 * valor1) + (quantidade2 * valor2);
            Console.WriteLine("VALOR A PAGAR: " + resultado.ToString("F2"));
        }
    }
}