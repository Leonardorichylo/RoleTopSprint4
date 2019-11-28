using System;
using RoleTop.Models;
using RoleTop.Repositories;
using RoleTop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTop.Controllers
{
    public class PedidoController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        PacoteServicosRepository pacoteServicosRepository = new PacoteServicosRepository();
        EventoRepository eventoRepository = new EventoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();


        public IActionResult Index()
        {
            PedidoViewModel pedido = new PedidoViewModel();
            pvm.Evento = eventoRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pvm.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                pvm.Cliente = clienteLogado;
            }

            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = usuarioLogado;
            pvm.UsuarioNome = nomeUsuarioLogado;

            return View (pvm);
        }

        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido ();

            var nomeEvento = form["evento"];
            Evento evento = new Evento ();
            evento.Nome = nomeEvento;
            evento.Preco = eventoRepository.ObterPrecoDe(nomeEvento);

            pedido.Evento = evento;

            var nomePacoteServicos = form["pacoteservicos"];
            PacoteServicos pacoteServicos = new PacoteServicos (
                nomePacoteServicos,
                pacoteServicosRepository.ObterPrecoDe(nomePacoteServicos));

                pedido.PacoteServicos = pacoteServicos;

            Cliente cliente = new Cliente(){
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]

            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = evento.Preco + pacoteServicos.Preco;

            if (pedidoRepository.Inserir(pedido)) {
                return View ("Sucesso");
            }else {
                return View ("Erro");
            }
        }

    }

}