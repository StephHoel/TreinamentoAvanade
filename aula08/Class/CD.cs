using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula08
{
    class CD : Produto
    {
        public string Artista { get; set; }
        public string Gravadora { get; set; }
        public string Origem { get; set; }

        public CD(string artista, string gravadora, string origem, string descricao, string genero, int estoqueDisponivel, double precoCusto) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.Artista = artista;
            this.Gravadora = gravadora;
            this.Origem = origem;
        }

        public CD()
        {
            this.Artista = "";
            this.Gravadora = "";
            this.Origem = "";
            this.Descricao = "";
            this.Genero = "";
            this.EstoqueDisponivel = 0;
            this.PrecoCusto = 0;
        }

        public void ListarProduto()
        {
            MessageBox.Show("Dados do CD cadastrado\n\n" +
                $"Descrição: {this.Descricao}\n" +
                $"Gênero: {this.Genero}\n" +
                $"Estoque: {this.EstoqueDisponivel}\n" +
                $"Preço de Custo: {this.PrecoCusto:f2}\n" +
                $"Artista: {this.Artista}\n" +
                $"Gravadora: {this.Gravadora}\n" +
                $"Origem: {this.Origem}");
        }
    }
}
