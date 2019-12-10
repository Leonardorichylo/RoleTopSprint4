using System;
using RoleTop.Enums;
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
        EventoRepository eventoRepository = new EventoRepository();
        PacoteServicosRepository pacoteServicosRepository = new PacoteServicosRepository();
        ClienteRepository clienteRepository = new ClienteRepository();


        public IActionResult Index()
        {
            OrcamentoViewModel ovm = new OrcamentoViewModel();
            ovm.Eventos = eventoRepository.ObterTodos();
            ovm.PacotesServicos = pacoteServicosRepository.ObterTodos();

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

            var nomePacoteServicos = form["pacoteservicos"];
            PacoteServicos pacoteServicos = new PacoteServicos ();
            pacoteServicos.Nome = nomePacoteServicos;
            pacoteServicos.Preco = pacoteServicosRepository.ObterPrecoDe(nomePacoteServicos);

            orcamento.PacoteServicos = pacoteServicos;

            var nomeEvento = form["evento"];
            Evento evento = new Evento (
                nomeEvento,
                eventoRepository.ObterPrecoDe(nomeEvento));

            orcamento.Evento = evento;

            Cliente cliente = new Cliente(){
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]

            };

            orcamento.Cliente = cliente;

            orcamento.DataDoOrcamento = DateTime.Now;
            
            orcamento.DataDoEvento = DateTime.Parse(form["data_evento"]);

            orcamento.PrecoTotal = (evento.Preco + pacoteServicos.Preco);

            orcamento.FormaPagamento = (form["forma_pagamento"]);

            orcamento.TipoEvento = (form["tipo_evento"]);

            if (orcamentoRepository.Inserir(orcamento)) {
                return View ("Sucesso", new RespostaViewModel()
                {
                NomeView = "Orcamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()

                });
            }else {
                return View ("Erro", new RespostaViewModel()
                {
                    NomeView = "Orcamento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Aprovar(ulong id)
    {

        var orcamento = orcamentoRepository.ObterPor(id);
        orcamento.Status = (uint) StatusOrcamento.APROVADO;

        if(orcamentoRepository.Atualizar(orcamento))
        {
            return RedirectToAction("Dashboard","Administrador");
        }
        else
        {
            return View ("Erro", new RespostaViewModel("Não foi possível aprovar este orçamento")
            {
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
        
        public IActionResult Reprovar(ulong id)
    {
        var orcamento = orcamentoRepository.ObterPor(id);
        orcamento.Status = (uint) StatusOrcamento.REPROVADO;

        if(orcamentoRepository.Atualizar(orcamento))
        {
            return RedirectToAction("Dashboard","Administrador");
        }
        else
        {
            return View ("Erro", new RespostaViewModel("Não foi possível reprovar este orçamento")
            {
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}

}