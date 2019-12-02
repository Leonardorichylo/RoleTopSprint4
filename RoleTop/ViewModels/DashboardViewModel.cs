using System.Collections.Generic;
using RoleTop.Models;

namespace RoleTop.ViewModels
{
    public class DashboardViewModel :BaseViewModel
    {
        public List<Orcamento> Orcamentos {get;set;}
        public uint OrcamentosAprovados {get;set;}
        public uint OrcamentosReprovados {get;set;}
        public uint OrcamentosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Orcamentos= new List<Orcamento>();
        }
    }
}