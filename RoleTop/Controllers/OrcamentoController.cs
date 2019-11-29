using System;
using RoleTop.Models;
using RoleTop.Repositories;
using RoleTop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTop.Controllers
{
    public class OrcamentoController : AbstractController
    {
        OrcamentoRepository orcamentoRepository = new OrcamentoRepository();
        PacoteServicosRepository pacoteServicosRepository = new PacoteServicosRepository();
        EventoRepository eventoRepository = new EventoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();


        public IActionResult Index()
        {
            OrcamentoViewModel orcamento = new OrcamentoViewModel();
            ovm.Evento = eventoRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                ovm.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                ovm.Cliente = clienteLogado;
            }

            ovm.NomeView = "Orcamento";
            ovm.UsuarioEmail = usuarioLogado;
            ovm.UsuarioNome = nomeUsuarioLogado;

            return View (ovm);
        }

        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Orcamento";
            Orcamento orcamento = new Orcamento ();

            var nomeEvento = form["evento"];
            Evento evento = new Evento ();
            evento.Nome = nomeEvento;
            evento.Preco = eventoRepository.ObterPrecoDe(nomeEvento);

            orcamento.Evento = evento;

            var nomePacoteServicos = form["pacoteservicos"];
            PacoteServicos pacoteServicos = new PacoteServicos (
                nomePacoteServicos,
                pacoteServicosRepository.ObterPrecoDe(nomePacoteServicos));

                orcamento.PacoteServicos = pacoteServicos;

            Cliente cliente = new Cliente(){
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]

            };

            orcamento.Cliente = cliente;

            orcamento.DataDoOrcamento = DateTime.Now;

            orcamento.PrecoTotal = evento.Preco + pacoteServicos.Preco;

            if (orcamentoRepository.Inserir(orcamento)) {
                return View ("Sucesso", new RespostaViewModel()
                {
                NomeView = "Orcamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()

                });
            }else {
                return View ("Erro", new RespostaViewModelViewModel()
                {
                    NomeView = "Orcamento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Aprovar(ulong id)
    {
        Orcamento orcamento = orcamentoRepository.ObterPor(id);
        orcamento.Status = (uint) StatusOrcamento.APROVADO;
        if(orcamentoRepository.Atualizar(orcamento))
        {
            return RedirectToAction("Dashboard","Administrador");
        }
        else
        {
            return View ("Erro", new RespostaViewModel()
            {
                Mensagem = "Houve um erro ao Aprovar pedido.",
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
        
        public IActionResult Reprovar(ulong id)
    {
        Orcamento orcamento = orcamentoRepository.ObterPor(id);
        orcamento.Status = (uint) StatusOrcamento.REPROVADO;
        if(orcamentoRepository.Atualizar(orcamento))
        {
            return RedirectToAction("Dashboard","Administrador");
        }
        else
        {
            return View ("Erro", new RespostaViewModel()
            {
                Mensagem = "Houve um erro ao Reprovar pedido.",
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
    }

}