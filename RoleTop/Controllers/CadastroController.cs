using System;
using RoleTop.Enums;
using RoleTop.Models;
using RoleTop.Repositories;
using RoleTop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTop.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepositorio = new ClienteRepository();
        public IActionResult Index()
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
            try{
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["endereco"],
                    form["telefone"],
                    form["senha"],
                    form["email"],
                    DateTime.Parse(form["data-nascimento"]));
                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;

                clienteRepositorio.Inserir(cliente);

                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            catch(Exception e)
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