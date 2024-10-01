using System;

namespace Questao_2
{
    class program
    {
        public static void Main(string[] args)
        {
            string input;
            int cont = 0;

            Console.WriteLine("realizar entrada de dados.");
            input = Console.ReadLine();

            foreach (char c in input)
            {
                if (c == 'a' || c == 'A')
                {
                    cont++;
                }
            }
            
            if (cont > 0)
            {
                Console.WriteLine($"A letra 'a' aparece {cont} vezes.");
            } else
            {
                Console.WriteLine("A letra 'a' não aparece na entrada de dados.");
            }

        }
    }
}