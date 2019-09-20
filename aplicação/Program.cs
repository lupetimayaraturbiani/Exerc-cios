using System;

namespace aplicação
{
    class Program
    {
        static void Main(string[] args)
        {   int numx = 1;
            
            while (numx != 0) {
            Console.WriteLine("Escreva um número inteiro ou zero para parar ");
            numx = int.Parse(Console.ReadLine());
            
            if (numx % 2 == 0) {
                Console.WriteLine("Esse número é par");
            } else {
                Console.WriteLine("Esse número é ímpar");
            }
            }
        }
    }
}
