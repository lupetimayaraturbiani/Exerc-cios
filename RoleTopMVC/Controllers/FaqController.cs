using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Faq()
        {
            ViewData["NomeView"] = "Mais";
            return View();
        }
    }
}