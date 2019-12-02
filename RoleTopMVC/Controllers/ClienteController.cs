using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositories;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : Controller
    {

        private ClienteRepository clienteRepository = new ClienteRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("==================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("==================");

                

                return View("Cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);

                return View("Erro ao cadastrar");           
            }
        }
    }
}