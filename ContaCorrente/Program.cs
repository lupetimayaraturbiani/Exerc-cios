using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Titular:");
            string Titular = Console.ReadLine();
            System.Console.WriteLine("Agência:");
            int Agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Número da conta:");
            int Numero = int.Parse(Console.ReadLine());

        }
    }
}
