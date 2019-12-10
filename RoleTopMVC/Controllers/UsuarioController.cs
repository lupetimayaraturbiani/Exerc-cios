using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class UsuarioController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        EventoRepository eventoRepository = new EventoRepository();
        TiposEventoRepository tiposEventoRepository = new TiposEventoRepository();
        ServicosAdicionaisRepository servicosAdicionaisRepository = new ServicosAdicionaisRepository();

        public IActionResult Usuario()
        {
            UsuarioViewModel uvm = new UsuarioViewModel();
            uvm.TiposEvento = tiposEventoRepository.ObterTodos();
            uvm.ServicosAdicionais = servicosAdicionaisRepository.ObterTodos();

            var emailCliente = ObterUsuarioSession();
            if (!string.IsNullOrEmpty(emailCliente))
            {
                uvm.Cliente = clienteRepository.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                uvm.NomeCliente = nomeUsuario;
            }

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                uvm.UsuarioNome = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if (clienteLogado != null)
            {
                uvm.Cliente = clienteLogado;
            }

            uvm.NomeView = "Cliente";
            uvm.UsuarioEmail = ObterUsuarioSession();
            uvm.UsuarioNome = ObterUsuarioNomeSession();


            return View(uvm);
        }

        public IActionResult Registrar (IFormCollection form)
        {
            ViewData["Action"] = "Usuario";

            Evento evento = new Evento();

            var nomeTiposEvento = form["tiposEvento"];
            TiposEvento tiposEvento = new TiposEvento(nomeTiposEvento, tiposEventoRepository.ObterPrecoDe(nomeTiposEvento));

            evento.TiposEvento = tiposEvento;

            var nomeServicosAdicionais = form["servicosAdicionais"];
            ServicosAdicionais servicosAdicionais = new ServicosAdicionais(nomeServicosAdicionais, servicosAdicionaisRepository.ObterPrecoDe(nomeServicosAdicionais));

            evento.ServicosAdicionais = servicosAdicionais;

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Email = form["email"],
                Telefone = form["telefone"],
            };

            evento.Cliente = cliente;

            evento.DataEvento = DateTime.Now;

            evento.PrecoTotal = tiposEvento.Preco + servicosAdicionais.Preco;


            if (eventoRepository.Inserir(evento))
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
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.APROVADO;

            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar esse evento"){
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Reprovar(ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.REPROVADO;

            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar esse evento"){
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}