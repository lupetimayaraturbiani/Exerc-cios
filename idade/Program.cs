using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            int ano = 0;
            
            Console.WriteLine("Digite seu ano de nascimento:");
            ano = int.Parse(Console.ReadLine());
            
            while ((ano > 2019) || (ano < 0) ) {
            Console.WriteLine("Digite seu ano de nascimento:");
            ano = int.Parse(Console.ReadLine());
            }

            age = 2019 - ano;


            if (age < 3) {
                Console.WriteLine("Você é um Recém-Nascido");
            } else if ((age >= 3) && (age <=11)) {
                Console.WriteLine("Você é uma Criança");
            } else if ((age >= 12) && (age <= 19)) {
                Console.WriteLine("Você é um Adolescente");
            } else if ((age >=20) && (age <= 65)) {
                Console.WriteLine("Você é um Adulto");
            } else if (age > 65) {
                Console.WriteLine("Você é um Idoso");
            }
            
        }
    }
}
