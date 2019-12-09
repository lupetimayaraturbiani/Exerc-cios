using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
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
            return View(new BaseViewModel(){
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
                    form["email"],
                    form["cpf"],
                    form["endereco"],
                    form["telefone"],
                    form["senha"],
                    form ["confirma_senha"],
                    DateTime.Parse(form["data-nascimento"]));

                    cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                    clienteRepository.Inserir(cliente);
                    
                    return View("Sucesso", new RespostaViewModel(){
                        NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()
                    });
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

            
        }
        
    }
}