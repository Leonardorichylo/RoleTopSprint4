namespace RoleTop.Models
{
    public class PacoteServicos : Produto
    {
        public PacoteServicos()
        {

        }

        public PacoteServicos(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}