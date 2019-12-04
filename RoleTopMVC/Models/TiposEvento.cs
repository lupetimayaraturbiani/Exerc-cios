namespace RoleTopMVC.Models
{
    public class TiposEvento : Evento
    {
        // ARRUMAR E DEIXAR QUE NEM HAMBURGUERES MCBONALDS

        public TiposEvento()
        {

        }

        public TiposEvento(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}