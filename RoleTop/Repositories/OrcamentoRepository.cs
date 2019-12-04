using System;
using System.Collections.Generic;
using System.IO;
using RoleTop.Models;

namespace RoleTop.Repositories
{
    public class OrcamentoRepository : RepositoryBase
    {
        private const string PATH ="Database/Orcamento.csv";

        public OrcamentoRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Orcamento orcamento) {
            var quantidadeOrcamentos = File.ReadAllLines(PATH).Length;
            orcamento.Id = (ulong) ++quantidadeOrcamentos;
            var linha = new string[] { PrepararOrcamentoCSV (orcamento) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Orcamento> ObterTodosPorCliente(string emailCliente)
        {
            var orcamentos = ObterTodos();
            List<Orcamento> orcamentosCliente = new List<Orcamento>();

            foreach (var orcamento in orcamentos)
            {
                if(orcamento.Cliente.Email.Equals(emailCliente))
                {
                    orcamentosCliente.Add(orcamento);
                }
            }
            return orcamentosCliente;
        }
        public List<Orcamento> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            List<Orcamento> orcamentos = new List<Orcamento>();

            foreach (var linha in linhas) {
                Orcamento orcamento = new Orcamento ();

                orcamento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                orcamento.Status = uint.Parse(ExtrairValorDoCampo("status_orcamento", linha));
                orcamento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                orcamento.Cliente.Endereco = ExtrairValorDoCampo("cliente_endereco", linha);
                orcamento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                orcamento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                orcamento.Evento.Nome = ExtrairValorDoCampo("evento_nome", linha);
                orcamento.Evento.Preco = double.Parse(ExtrairValorDoCampo("evento_preco", linha));
                orcamento.PacoteServicos.Nome = ExtrairValorDoCampo("pacoteServicos_nome", linha);
                orcamento.PacoteServicos.Preco = double.Parse(ExtrairValorDoCampo("pacoteServicos_preco", linha));
                orcamento.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                orcamento.DataDoOrcamento = DateTime.Parse(ExtrairValorDoCampo("data_orcamento", linha));

                orcamentos.Add(orcamento);
            }
            return orcamentos;
        }

        public Orcamento ObterPor(ulong id)
        {
            var orcamentosTotais = ObterTodos();
            foreach (var orcamento in orcamentosTotais)
            {
                if(id.Equals(orcamento.Id))
                {
                    return orcamento;
                }
            }
            return null;
        }

        public bool Atualizar(Orcamento orcamento)
        {
            var orcamentosTotais = File.ReadAllLines(PATH);
            var orcamentoCSV = PrepararOrcamentoCSV(orcamento);
            var linhaOrcamento = -1;
            var resultado = false;

            for (int i = 0; i <orcamentosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", orcamentosTotais[i]));
                if(orcamento.Id.Equals(idConvertido))
                {
                    linhaOrcamento = i;
                    resultado = true;
                    break;
                }
            }
            if(resultado)
            {
                orcamentosTotais[linhaOrcamento] = orcamentoCSV;
                File.WriteAllLines(PATH, orcamentosTotais);
            }
            return resultado;
        }

        private string PrepararOrcamentoCSV (Orcamento orcamento) {
            Cliente c = orcamento.Cliente;
            Evento e = orcamento.Evento;
            PacoteServicos p = orcamento.PacoteServicos;

            return $"id={orcamento.Id};status_orcamento={orcamento.Status};cliente_nome={c.Nome};cliente_endereco={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email};evento_nome={e.Nome};evento_preco={e.Preco};pacoteServicos_nome={p.Nome};pacoteServicos_preco={p.Preco};data_orcamento={orcamento.DataDoOrcamento};preco_total={orcamento.PrecoTotal}";
        }
    }
}