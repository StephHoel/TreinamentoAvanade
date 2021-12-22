using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula08
{
    class DVD:Produto
    {
        public string Diretor { get; set; }
        public string Duracao { get; set; }
        public string Censura { get; set; }

        public DVD(string diretor, string duracao, string censura,
               string descricao, string genero, int estoqueDisponivel, double precoCusto) :
               base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.Diretor = diretor;
            this.Duracao = duracao;
            this.Censura = censura;
        }

        public DVD()
        {
            this.Diretor = "";
            this.Duracao = "";
            this.Censura = "";
            this.Descricao = "";
            this.Genero = "";
            this.EstoqueDisponivel = 0;
            this.PrecoCusto = 0;
        }

        public void ListarProduto()
        {
            MessageBox.Show("Dados do DVD cadastrado\n\n" +
                $"Descrição: {this.Descricao}\n" +
                $"Gênero: {this.Genero}\n" +
                $"Estoque: {this.EstoqueDisponivel}\n" +
                $"Preço de Custo: {this.PrecoCusto:f2}\n" +
                $"Diretor: {this.Diretor}\n" +
                $"Duração: {this.Duracao}\n" +
                $"Censura: {this.Censura}");
        }
    }
}
