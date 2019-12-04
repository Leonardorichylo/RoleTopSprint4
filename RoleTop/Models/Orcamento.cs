using System;
using RoleTop.Enums;

namespace RoleTop.Models
{
    public class Orcamento
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public Evento Evento {get;set;}
        public PacoteServicos PacoteServicos {get;set;}
        public DateTime DataDoOrcamento {get;set;}

        public double PrecoTotal {get;set;}
        public uint Status {get;set;}
        public Orcamento()
        {
            this.Cliente = new Cliente();
            this.Evento = new Evento();
            this.PacoteServicos = new PacoteServicos();
            this.Id = 0;
            this.Status = (uint) StatusOrcamento.PENDENTE;
            
        }
    }
}