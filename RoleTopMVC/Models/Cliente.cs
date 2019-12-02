using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string CPF {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string endereco, string cpf, string telefone, string senha, string email, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Email = email;
            this.DataNascimento = dataNascimento;
        }
    }
}