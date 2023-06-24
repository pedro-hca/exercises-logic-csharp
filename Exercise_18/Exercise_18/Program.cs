using System;
using System.Globalization;

namespace Exercise_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double media = 0.00;
            string[] notas;
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;

            for (int i = 1; i <= num; i++)
            {
                notas = Console.ReadLine().Split(' ');
                nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
                media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}

