using System;

namespace RoleTop.Models
{
    public class Orcamento
    {
        public Cliente Cliente {get;set;}
        public Evento Evento {get;set;}
        public PacoteServicos PacoteServicos {get;set;}
        public DateTime DataDoOrcamento {get;set;}

        public double PrecoTotal {get;set;}

        public Orcamento()
        {
            this.Cliente = new Cliente();
            this.Evento = new Evento();
            this.PacoteServicos = new PacoteServicos();
            
        }
    }
}