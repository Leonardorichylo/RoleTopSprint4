using System;

namespace RoleTop.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public string Cpf {get;set;}
        public DateTime DataNascimento {get;set;}
        public uint TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string endereco, string telefone, string senha, string email, string cpf, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Email = email;
            this.Cpf =cpf;
            this.DataNascimento = dataNascimento;
        }
    }
}