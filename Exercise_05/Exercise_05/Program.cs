using System;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Senha();
        }

        static void Senha()
        {

            Console.Clear();

            int senhavalida = 2002;

            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != senhavalida)
            {
                Console.Clear();
                Console.WriteLine("Senha inválida");

                Console.WriteLine("Tente novamente:");
                senha = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.Write("Acesso permitido");

        }
    }
}