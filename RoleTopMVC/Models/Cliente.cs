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
        public uint TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string email, string cpf, string endereco, string telefone, string senha, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Email = email;
            this.CPF = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }
    }
}