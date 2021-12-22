using System.Windows.Forms;

namespace aula08
{
    class Livro : Produto
    {
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Edicao { get; set; }

        public Livro(string autor, string editora, string edicao,
            string descricao, string genero, int estoqueDisponivel, double precoCusto) :
            base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.Autor = autor;
            this.Editora = editora;
            this.Edicao = edicao;
        }

        public Livro()
        {
            this.Autor = "";
            this.Editora = "";
            this.Edicao = "";
            this.Descricao = "";
            this.Genero = "";
            this.EstoqueDisponivel = 0;
            this.PrecoCusto = 0;
        }

        public void ListarProduto()
        {
            MessageBox.Show("Dados do livro cadastrado\n\n" +
                $"Descrição: {this.Descricao}\n" +
                $"Gênero: {this.Genero}\n" +
                $"Estoque: {this.EstoqueDisponivel}\n" +
                $"Preço de Custo: {this.PrecoCusto:f2}\n" +
                $"Autor: {this.Autor}\n" +
                $"Editora: {this.Editora}\n" +
                $"Edição: {this.Edicao}");
        }
    }
}
