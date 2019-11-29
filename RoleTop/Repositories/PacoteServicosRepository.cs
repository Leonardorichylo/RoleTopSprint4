using System.Collections.Generic;
using System.IO;
using RoleTop.Models;

namespace RoleTop.Repositories
{
    public class PacoteServicosRepository
    {
        private const string PATH = "Database/PacoteServicos.csv";

        public double ObterPrecoDe(string nomePacoteServicos)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomePacoteServicos))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }
        public List<PacoteServicos> ObterTodos()
        {
            List<PacoteServicos> pacotesServicos = new List<PacoteServicos>();
            var linhas = File.ReadAllLines(PATH);

            foreach (var linha in linhas)
            {
                PacoteServicos p = new PacoteServicos();
                var dados = linha.Split(";");
                p.Nome = dados [0];
                p.Preco = double.Parse(dados[1]);

                pacotesServicos.Add(p);
            }
            return pacotesServicos;
        }
    }
}