using System;
using System.Windows.Forms;

namespace aula05Framework
{
    public partial class FormMatrizes : Form
    {
        string[] cores = { "amarelo", "branco", "verde", "preto", "laranja" };

        public FormMatrizes()
        {
            InitializeComponent();
        }

        private void BtnTamanho_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu vetor tem capacidade para {cores.Length} elementos");
        }

        private void BtnOrdena_Click(object sender, EventArgs e)
        {
            ListResultado.Items.Clear();
            Array.Sort(cores);
            for (int i = 0; i < cores.Length; i++)
                ListResultado.Items.Add(cores[i]);
        }

        private void BtnInverter_Click(object sender, EventArgs e)
        {
            ListResultado.Items.Clear();
            Array.Reverse(cores);
            for (int i = 0; i < cores.Length; i++)
            {
                ListResultado.Items.Add(cores[i]);
            }
        }

        private void BtnIndice_Click(object sender, EventArgs e)
        {
            ListResultado.Items.Clear();
            int resultado = Array.IndexOf(cores, "verde");
            MessageBox.Show($"O índice onde o elemtno está é o {resultado}");
        }

        private void BtnBuscaBinaria_Click(object sender, EventArgs e)
        {
            ListResultado.Items.Clear();
            object corEscolhida = "amarelo";
            Array.Sort(cores);

            for (int i = 0; i < cores.Length; i++)
                ListResultado.Items.Add(cores[i]);

            int indice = Array.BinarySearch(cores, corEscolhida);

            if (indice >= 0)
                MessageBox.Show($"Achei o elemento no índice {indice}");
            else
                MessageBox.Show("Não encontrei este elemento.");
        }
    }
}
