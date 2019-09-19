using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
           double sal;
           double newsal;
           double aumento = 0.3;
           Console.WriteLine("Digite seu salário:");
           sal = double.Parse(Console.ReadLine());
           
           newsal = (aumento * sal) + sal;

           if (sal < 500) {
               Console.WriteLine("Seu salário atual é " + newsal);
           } else if (sal > 500) {
               Console.WriteLine("Não houve alterações, seu salário continua sendo " + sal);
           }

           
        }
    }
}
