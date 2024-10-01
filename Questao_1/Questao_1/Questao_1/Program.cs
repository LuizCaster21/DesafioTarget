using System;

namespace Questao_1
{
    class Program
    {


        public static void Main(string[] args)

        {
            int a = 0, b = 1;
            int fibonacci = 0;
            int x, cont = 0;

            Console.WriteLine("Informe o número desejado para verificação.");
            x = int.Parse(Console.ReadLine());

            while (fibonacci <= x )
            {
                if(x == a)
                {
                    Console.WriteLine($"O número {x} faz parte da sequência de fibonacci.");
                }  else if (cont >= x && x != a && x != b && x != fibonacci)
                   {
                    Console.WriteLine($"O número {x} não faz parte da sequência de fibonacci.");
                    break;
                   }

                fibonacci = a + b;
                a = b;
                b = a;
                cont++;
            }

            
        }
    }
}