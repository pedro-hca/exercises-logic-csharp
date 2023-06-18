using System;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            TabelaPrecos();
        }
        static void TabelaPrecos()
        {
            double cod1 = 4.00;
            double cod2 = 4.50;
            double cod3 = 5.00;
            double cod4 = 2.00;
            double cod5 = 1.50;

            Console.WriteLine("Digite o código do produto desejado");
            int codigoDigitado = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade desejada");
            int quantidade = int.Parse(Console.ReadLine());

            double total = 0.0;


            switch (codigoDigitado)
            {
                case 1:
                    total = cod1 * quantidade;
                    break;
                case 2:
                    total = cod2 * quantidade;
                    break;
                case 3:
                    total = cod3 * quantidade;
                    break;
                case 4:
                    total = cod4 * quantidade;
                    break;
                case 5:
                    total = cod5 * quantidade;
                    break;
                default:
                    Console.WriteLine("Código de item inválido.");
                    break;
            }
            Console.WriteLine("Total: " + total.ToString("F2"));
        }
    }
}