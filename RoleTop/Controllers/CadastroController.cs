using System;
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
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult CadastrarCliente(IFormColletion form)
        {
            ViewData["Action"] = "Cadastro";
            try{
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["endereco"],
                    form["telefone"],
                    form["senha"],
                    form["email"],
                    DateTime.Parse(form["data-nascimento"])
                );
                clienteRepositorio.Inserir(cliente);

                return View("Sucesso");
            }
            catch(Exception e)
            {
                return View("Erro");
            }
        }
    }
}