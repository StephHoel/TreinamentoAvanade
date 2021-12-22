using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace aula08
{
    public partial class Form1 : Form
    {
        Livro livro = new Livro();
        CD cd = new CD();
        DVD dvd = new DVD();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCadLivro_Click(object sender, EventArgs e)
        {
            livro.Descricao = txtDesc.Text;
            livro.Autor = txtAutor.Text;
            livro.Edicao = txtEdicao.Text;
            livro.Editora = txtEditora.Text;
            livro.EstoqueDisponivel = int.Parse(txtEstoque.Text);
            livro.Genero = txtGenero.Text;
            livro.PrecoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("Livro Cadastrado com sucesso!");
        }

        private void BtnCompLivro_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(Interaction.InputBox("Informe a quantidade comprada:"));
            livro.Comprar(qtd);

        }

        private void BtnVendLivro_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(Interaction.InputBox("Informe a quantidade vendida:"));
            livro.Vender(qtd);
        }

        private void BtnListarLivro_Click(object sender, EventArgs e)
        {
            livro.ListarProduto();
        }

        private void BtnCadCD_Click(object sender, EventArgs e)
        {
            cd.Descricao = txtDesc.Text;
            cd.Artista = txtArtista.Text;
            cd.Gravadora = txtGravadora.Text;
            cd.Origem = txtOrigem.Text;
            cd.EstoqueDisponivel = int.Parse(txtEstoque.Text);
            cd.Genero = txtGenero.Text;
            cd.PrecoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("CD Cadastrado com sucesso!");
        }

        private void BtnCadDVD_Click(object sender, EventArgs e)
        {
            dvd.Descricao = txtDesc.Text;
            dvd.Diretor = txtDiretor.Text;
            dvd.Duracao = txtDuracao.Text;
            dvd.Censura = txtCensura.Text;
            dvd.EstoqueDisponivel = int.Parse(txtEstoque.Text);
            dvd.Genero = txtGenero.Text;
            dvd.PrecoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("DVD Cadastrado com sucesso!");
        }

        private void BtnCompCD_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(Interaction.InputBox("Informe a quantidade comprada:"));
            cd.Comprar(qtd);
        }

        private void BtnCompDVD_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(Interaction.InputBox("Informe a quantidade comprada:"));
            dvd.Comprar(qtd);
        }

        private void BtnVendCD_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(Interaction.InputBox("Informe a quantidade vendida:"));
            cd.Vender(qtd);
        }

        private void BtnVendDVD_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(Interaction.InputBox("Informe a quantidade vendida:"));
            dvd.Vender(qtd);
        }

        private void BtnListarCD_Click(object sender, EventArgs e)
        {
            cd.ListarProduto();
        }

        private void BtnListarDVD_Click(object sender, EventArgs e)
        {
            dvd.ListarProduto();
        }
    }
}
