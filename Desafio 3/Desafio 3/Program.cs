using System;

namespace Desafio3
{
    class Tabuada
    {
        public static void Main(string[] args)
        {
            double numero = 0;
            Console.WriteLine("Tabuada do Koj1One");

            Console.WriteLine("Digite o valor que você deseja ver a Tabuada: ");
            numero = double.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

    }
}

