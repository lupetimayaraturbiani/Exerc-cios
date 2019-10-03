using System;

namespace Banco
{
    class Program
    {
        public class ContaCorrente
        {
            public string Titular { get; set; }
            public int Agencia { get; set; }
            public int Numero { get; set; }
            public double Saldo { get; set; }
        }

        public ContaCorrente(int Agencia, int Numero, string Titular, double Saldo){
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            Saldo = 0;
        }

        
    }
}