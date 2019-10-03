using System;

namespace ByteBank
{
    /*Classe declarada */
    public class Cliente
    {
        /*Propriedades da classe */
        public string Nome;
        public string Cpf;
        public string Email;
        public string Senha;

        /*Construtores */
        public Cliente(string Nome, string Cpf, string Email){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        /*Método de acesso */
        public bool TrocaSenha(string Senha){
            if((Senha.Length > 6) && (Senha.Length < 16)){
                this.Senha = Senha;
                return true;
            }else {
                return false;
            }
        }
    }


}