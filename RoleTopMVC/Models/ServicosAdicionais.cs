namespace RoleTopMVC.Models
{
    public class ServicosAdicionais : Evento
    {
        //ARRUMAR E DEIXAR QUE NEM HAMBURGUERES MCBONALDS
        public ServicosAdicionais()
        {

        }

        public ServicosAdicionais(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}