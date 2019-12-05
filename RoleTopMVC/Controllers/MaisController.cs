using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class MaisController : AbstractController
    {
        public IActionResult Mais()
        {
            return View(new BaseViewModel(){
                NomeView = "Mais",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}