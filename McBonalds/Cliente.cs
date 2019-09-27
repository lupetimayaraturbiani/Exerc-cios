using System;

namespace McBonalds
{
    public class Cliente 
    {
        //propriedades
         public string Nome;      //nome do cliente
         public string Endereço;  //endereço do cliente
         public string Telefone;  //telefone do cliente
         public string Senha;     //senha de acesso do cliente no sistema
         public string Email;     //email do cliente e nome de usuário do sistema
         public DateTime Datanascimento; //data de nascimento do cliente


        //contrutores
        public Cliente(string Nome, string Telefone, string Email){
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
    }

}