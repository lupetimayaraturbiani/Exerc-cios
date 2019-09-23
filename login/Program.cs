using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string senha;
            
            Console.WriteLine("Nome de Usuário:");
            usuario = Console.ReadLine();
            Console.WriteLine("Senha cadastrada:");
            senha = Console.ReadLine();

            if ((usuario == "admin") && (senha == "admin")) {
                Console.WriteLine("Olá Administrador");
            } else if((usuario != "admin") && (senha != "admin")) {
                Console.WriteLine("Olá Usuário");
            }
        }
    }
}
