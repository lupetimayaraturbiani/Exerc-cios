using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class MaisController : Controller
    {
        public IActionResult Mais()
        {
            ViewData["NomeView"] = "Mais";
            return View();
        }
    }
}