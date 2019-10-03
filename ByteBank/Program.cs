using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            System.Console.Write("Nome:");
            string nome = Console.ReadLine();
            System.Console.Write("CPF:");
            string cpf = Console.ReadLine();
            System.Console.Write("Email:");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome,cpf,email);

            bool trocouSenha = false;
            do {
                System.Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if (trocouSenha){
                    System.Console.WriteLine("Senha alterda com sucesso!");
                }else {
                    System.Console.WriteLine("Senha Inválida");
                }
            }while(!trocouSenha); 
        }
    }
}
