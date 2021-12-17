using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace aula05Framework
{
    public partial class FormEntry : Form
    {
        public FormEntry()
        {
            InitializeComponent();
        }

        private void btnArrayInterative_Click(object sender, EventArgs e)
        {
            FormArrayInterative formArrayInterative = new FormArrayInterative();
            formArrayInterative.Show();
        }

        private void BtnArrayInverse_Click(object sender, EventArgs e)
        {
            FormVetorInverso formVetorInverso = new FormVetorInverso();
            formVetorInverso.Show();
        }

        private void BtnNota_Click(object sender, EventArgs e)
        {

            double[] v = new double[10];
            double total = 0, media;

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = double.Parse(Interaction.InputBox($"Digite a nota do aluno {i + 1}:"));
                total += v[i];
            }

            media = total / v.Length;

            MessageBox.Show($"A média da turma é de: {media.ToString("0.00")}");
        }

        private void BtnMatrizPares_Click(object sender, EventArgs e)
        {
            int[,] valores = new int[3, 2];
            int pares = 0;

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    valores[linha, coluna] = int.Parse(Interaction.InputBox($"Digite o elemento da posição {linha + 1},{coluna + 1} na matriz:"));
                }
            }

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    if (valores[linha, coluna] % 2 == 0)
                    {
                        pares++;
                    }
                }
            }

            MessageBox.Show($"Quantidade de números pares: {pares}");

        }

        private void BtnMatrizes_Click(object sender, EventArgs e)
        {
            FormMatrizes formMatrizes = new FormMatrizes();
            formMatrizes.Show();
        }
    }
}
