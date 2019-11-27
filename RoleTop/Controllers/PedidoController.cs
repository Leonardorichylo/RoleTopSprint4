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
        ClienteRepository clienteRepository = new ClienteRepository();
        PedidoRepository pedidoRepository = new PedidoRepository();

        public IActionResult Index()
        {
            PedidoViewModel pedido = new PedidoViewModel();


            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                pedido.Cliente = clienteRepository.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                pedido.NomeCliente = nomeUsuario;
            }
            pedido.NomeView = "Pedido";

            pedido.UsuarioEmail = ObterUsuarioSession();
            pedido.UsuarioNome = ObterUsuarioNomeSession();

            return View(pedido);
        }

        public IActionResult Registrar(IFormColletion form)
        {
            ViewData["Action"] = "Pedido";
            PedidoController pedido = new Pedido();

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form ["endereco"],
                Telefone = form ["telefone"],
                Email = form ["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;
            pedido.PrecoTotal = 1+1;

            if(pedidoRepository.Inserir(pedido))
            {
                return View("Sucesso",new RespostaViewModel(){
                    Mensagem = "Aguarde a aprovação dos nossos administradores"
                });   
            }
            else
            {
                return View("Erro",new RespostaViewModel(){
                    Mensagem = "Houve um erro ao processar seu pedido. Tente novamente",
                    NomeView = "Login",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}