using System;
using ByteBank2.Models;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente(1, 1, "Alexandre");
            ContaCorrente contaCorrente2 = new ContaCorrente(1, 2, "Cesar");
            
            DepositarConta(contaCorrente1);
            DepositarConta(contaCorrente2);
            SacarConta(contaCorrente1);
            SacarConta(contaCorrente2);

            ContaEspecial contaEspecial11 = new ContaEspecial(1, 2, "Cesar");
            DepositarConta(contaEspecial11);
            SacarConta(contaEspecial11);

        }
            #region Depósito
            public static void DepositarConta(ContaBancaria contaBancaria){
            
            string usuario = contaBancaria.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bom Vindo - {usuario}");
            System.Console.WriteLine($"Agencia: {contaBancaria.Agencia} Conta: {contaBancaria.NumeroConta}");
            System.Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaBancaria.Deposito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            }
            #endregion
            
            public static void SacarConta(ContaBancaria contaBancaria){
            #region Saque
            string usuario = contaBancaria.Titular;
            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia: {contaBancaria.Agencia} Conta: {contaBancaria.NumeroConta}");
            System.Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Saque: ");
            double valor = double.Parse(Console.ReadLine());
            contaBancaria.Saque(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            }
            #endregion
    }
}
