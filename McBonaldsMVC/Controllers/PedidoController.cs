using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using McBonaldsMVC.Models;
using System;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        
        ClienteRepository clienteRepository = new ClienteRepository();
        PedidoRepository pedidoRepository = new PedidoRepository();

        HamburguerRepository hamburguerRepository = new HamburguerRepository();

        ShakeRepository shakeRepository = new ShakeRepository();

        public IActionResult Index()
        {
            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos();
            pvm.Shakes = shakeRepository.ObterTodos();


            var emailCliente = ObterUsuarioSession();
            if (!string.IsNullOrEmpty(emailCliente))
            {
                pvm.Cliente = clienteRepository.ObterPor(emailCliente);
            }
            
            var nomeUsuario = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                pvm.NomeCliente = nomeUsuario;
            }
            
            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pvm.UsuarioNome = nomeUsuarioLogado;
            }
            
            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if (clienteLogado != null)
            {
                pvm.Cliente = clienteLogado;
            }

            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = ObterUsuarioSession();
            pvm.UsuarioNome = ObterUsuarioNomeSession();


            return View(pvm);
        }

        

        public IActionResult Registrar(IFormCollection form)

        {

            ViewData["Action"] = "Index";

            Pedido pedido = new Pedido();

            var nomeShake = form["shake"];
            Shake shake = new Shake(nomeShake, shakeRepository.ObterPrecoDe(nomeShake));

            

            pedido.Shake = shake;

            
            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer(nomeHamburguer, hamburguerRepository.ObterPrecoDe(nomeHamburguer));
            

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente()
            {
            Nome = form["nome"],
            Endereco = form["endereco"],
            Telefone = form["telefone"],
            Email = form["email"],
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;


            if (pedidoRepository.Inserir(pedido))
            {
                return View("Sucesso", new RespostaViewModel(){
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            } 
            else 
            {
                return View("Erro");
            }

            
        }

        public IActionResult Aprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.APROVADO;

            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este pedido"){
                    NomeView = "Dasboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }

        public IActionResult Reprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.REPROVADO;

            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido"){
                    NomeView = "Dasboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
    }
}