using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula08
{
    class Produto
    {
        public string Descricao { get; set; }
        public string Genero { get; set; }
        public int EstoqueDisponivel { get; set; }
        public double PrecoCusto { get; set; }

        public Produto(string descricao, string genero, int estoqueDisponivel, double precoCusto)
        {
            this.Descricao = descricao;
            this.Genero = genero;
            this.EstoqueDisponivel = estoqueDisponivel;
            this.PrecoCusto = precoCusto;
        }

        public Produto()
        {
            this.Descricao = "";
            this.Genero = "";
            this.EstoqueDisponivel = 0;
            this.PrecoCusto = 0;
        }

        public void Comprar(int qtd)
        {
            this.EstoqueDisponivel += qtd;
            MessageBox.Show($"Compra efetuada com sucesso!");
        }

        public void Vender(int qtd)
        {
            if (qtd > this.EstoqueDisponivel)
                MessageBox.Show($"Quantidade em estoque insuficiente.\nVenda cancelada!");
            else
            {
                this.EstoqueDisponivel -= qtd;
                MessageBox.Show($"Venda efetuada com sucesso!");
            }
        }
    }
}
