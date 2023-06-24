using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Exercise_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.00;
            double taxa1 = 0.00;
            double taxa2 = 0.00;

            if (num >= 0.00 && num <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (num > 2000.00 && num <= 3000.00)
            {
                imposto = (num - 2000.00) * 0.08;
                Console.WriteLine($"R$: " + imposto.ToString("F2"));
            }
            else if (num > 3000.00 && num <= 4500.00)
            {
                num = (num - 3000.00);
                taxa1 = 1000.00 * 0.08;
                imposto = taxa1 + (num * 0.18);
                Console.WriteLine($"R$: " + imposto.ToString("F2"));
            }
            else if (num > 4500.00)
            {
                num = (num - 4500.00);
                taxa1 = 1000.00 * 0.08;
                taxa2 = 1500 * 0.18;
                imposto = taxa1 + taxa2 + (num * 0.28);
                Console.WriteLine($"R$: " + imposto.ToString("F2"));
            }


        }
    }
}

