using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController: AbstractController
    {

        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult IndexCadastro()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
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
                    return View("Sucesso", new RespostaViewModel(){
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()
                    });
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }

            
        }
        
    }
}