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

            Cliente cliente1 = new Cliente(nome, cpf, email);
            System.Console.WriteLine(cliente1.Senha);


            bool trocouSenha = false;
            do
            {
                System.Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if (trocouSenha)
                {
                    System.Console.WriteLine("Senha alterda com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Senha Inválida");
                }
            } while (!trocouSenha);
            System.Console.WriteLine();

            System.Console.WriteLine("Digite a Agência: ");
            int Agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite sua conta: ");
            int Numero = int.Parse(Console.ReadLine());


            ContaCorrente contacorrente1 = new ContaCorrente(Agencia, Numero, cliente1);
            double saldo;
            do
            {
                System.Console.WriteLine("Digite o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (contacorrente1.Deposito(saldo))
                {
                    System.Console.WriteLine("Valor do saldo deve ser positivo."); 
                }
            } while (saldo < 0);

            Cliente cliente2 = new Cliente("Cesar", "123.456.789-12", "1@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123, 321, cliente2);

            #region Depósito
            Cliente usuario = contacorrente1.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bom Vindo - {usuario._Nome}");
            System.Console.WriteLine($"Agencia: {contacorrente1.Agencia} Conta: {contacorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contacorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contacorrente1.Deposito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo saldo: {contacorrente1.Saldo}");
            System.Console.WriteLine();
            #endregion

            #region Saque
            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Bem Vindo - {usuario._Nome}");
            System.Console.WriteLine($"Agencia: {contacorrente1.Agencia} Conta: {contacorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contacorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Saque: ");
            valor = double.Parse(Console.ReadLine());
            contacorrente1.Saque(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo saldo: {contacorrente1.Saldo}");
            System.Console.WriteLine();
            #endregion

            #region Transferência
            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.WriteLine($"Bem Vindo - {usuario._Nome}");
            System.Console.WriteLine($"Agencia: {contacorrente1.Agencia} Conta: {contacorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contacorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Transferência: ");
            valor = double.Parse(Console.ReadLine());
            if (contacorrente1.Transferencia(contaCorrente2, valor))
            {
                System.Console.WriteLine("Transferência efetuada com sucesso");
            }
            else
            {
                System.Console.WriteLine("Não foi possível realizar essa operação");
            }

            System.Console.WriteLine();
            System.Console.WriteLine($"Novo saldo origem: {contacorrente1.Saldo}");
            System.Console.WriteLine($"Novo saldo destino: {contaCorrente2.Saldo}");
            System.Console.WriteLine();
            #endregion
        }
    }
}
