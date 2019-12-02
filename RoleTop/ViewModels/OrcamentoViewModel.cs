using System.Collections.Generic;
using RoleTop.Models;

namespace RoleTop.ViewModels
{
    public class OrcamentoViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public List<PacoteServicos> PacotesServicos {get;set;}

        public string NomeUsuario {get;set;}

        public Cliente Cliente {get;set;}

        public OrcamentoViewModel()
        {
            this.Eventos = new List<Evento>();
            this.PacotesServicos = new List<PacoteServicos>();
            this.NomeUsuario = "Usuario";
            this.Cliente = new Cliente();
        }
    }
}