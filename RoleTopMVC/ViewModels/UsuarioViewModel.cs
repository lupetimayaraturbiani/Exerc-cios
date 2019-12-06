using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public List<TiposEvento> TiposEvento {get;set;}
        public List<ServicosAdicionais> ServicosAdicionais {get;set;}
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}


// ACRESCENTAR A SUBSTITUIÇÃO DO NOME COMPLETO DO CLIENTE POR NOMECLIENTE//
        public UsuarioViewModel()
        {
            this.Eventos = new List<Evento>();
            this.TiposEvento = new List<TiposEvento>();
            this.ServicosAdicionais = new List<ServicosAdicionais>();
            this.Cliente = new Cliente();
            this.NomeCliente = "Nome Completo";
        }
    }
}