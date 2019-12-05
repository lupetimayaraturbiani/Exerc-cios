using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class EventoViewModel : BaseViewModel
    {
        public List<TiposEvento> TiposEventos {get;set;}
        public List<ServicosAdicionais> ServicosAdicionais {get;set;}
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}


// ACRESCENTAR A SUBSTITUIÇÃO DO NOME COMPLETO DO CLIENTE POR NOMECLIENTE//
        public EventoViewModel()
        {
            this.TiposEventos = new List<TiposEvento>();
            this.ServicosAdicionais = new List<ServicosAdicionais>();
            this.Cliente = new Cliente();
        }
    }
}