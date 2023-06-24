using System;
using System.Globalization;

namespace Exercise_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int a = int.Parse(valores[0]);
                int b = int.Parse(valores[1]);
                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = (double)a / b;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
