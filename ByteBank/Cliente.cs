using System;

namespace ByteBank
{
    /*Classe declarada */
    public class Cliente
    {
        /*Propriedades da classe */
        public string _Nome;
        public string _Cpf;
        public string _Email;
        private string _Senha;

        public string Senha
        {
            get {return _Senha;}
        }

        public string Nome
        {
            get {return _Nome;}
            set {_Nome = value;}
        }

        public string Cpf
        {
            get {return _Cpf;}
            set {Cpf = value;}
        }

        public string Email
        {
            get {return _Email;}
            set {_Email = value;}
        }
        /*Construtores */
        public Cliente(string Nome, string Cpf, string Email){
            this._Nome = Nome;
            this._Cpf = Cpf;
            this._Email = Email;
        }

        /*Método de acesso */
        public bool TrocaSenha(string Senha){
            if((Senha.Length > 6) && (Senha.Length < 16)){
                this._Senha = Senha;
                return true;
            }else {
                return false;
            }
        }
    }


}