using System;

namespace RoleTop.Models
{
    public class Pedido
    {
        public Cliente Cliente {get;set;}
        public Evento Evento {get;set;}
        public PacoteServicos PacoteServicos {get;set;}
        public DateTime DataDoPedido {get;set;}

        public double PrecoTotal {get;set;}

        public Pedido()
        {
            this.Cliente = new Cliente();
            this.Evento = new Evento();
            this.PacoteServicos = new PacoteServicos();
            
        }
    }
}