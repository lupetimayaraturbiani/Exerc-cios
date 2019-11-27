using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;

namespace RoleTopMVC.Controllers
{
    public class CadastroController: Controller
    {

        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult IndexCadastro()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";

            try
            {
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["endereco"],
                    form["telefone"],
                    form["senha"],
                    form["email"],
                    DateTime.Parse(form["data-nascimento"]));

                    clienteRepository.Inserir(cliente);
                    return View();
            }
            catch (Exception e)
            {
                
            }
        }
        
    }
}