using System;
using System.Collections.Generic;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Evento
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public string Nome {get;set;}
        public DateTime DataEvento {get;set;}
        public List<TiposEvento> TiposEvento {get;set;}
        public List<ServicosAdicionais> ServicosAdicionais {get;set;}
        public string CPF {get;set;}
        public string Horario {get;set;}
        public string Pagamento {get;set;}
        public uint Status {get;set;}

        public Evento()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Status = (uint) StatusEvento.PENDENTE;
        }
    }
}