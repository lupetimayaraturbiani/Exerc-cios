using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
    }
}