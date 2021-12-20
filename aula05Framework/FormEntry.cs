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

        private void BtnLer_Click(object sender, EventArgs e)
        {
            // Leia uma matriz 2x2 e exiba a soma de todos os elementos da matriz

            int[,] mat = new int[2, 2];
            int soma = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(Interaction.InputBox($"Digite o número da posição {i + 1},{j + 1} na matriz:"));
                    soma += mat[i, j];
                }
            }

            MessageBox.Show($"A soma dos elementos da matriz 2x2 é: {soma}");
        }

        private void BtnMatriz4x4_Click(object sender, EventArgs e)
        {
            // Elabore um programa que leia uma matriz 4x4.
            // - Apresente a soma de todos os elementos da linha 1;
            // - Exiba a média de todos os elementos da linha 2
            // - Multiplique cada elemento da linha 3 com o de mesma coluna
            // na linha 4

            int[,] mat = new int[4, 4];
            int[] mult = new int[4];
            int soma = 0;
            double media;
            string multip = "";

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(Interaction.InputBox($"Digite o número da posição {i + 1},{j + 1} na matriz:"));
                }
            }

            soma += mat[0, 0] + mat[0, 1] + mat[0, 2] + mat[0, 3];

            media = (double)(mat[1, 0] + mat[1, 1] + mat[1, 2] + mat[1, 3]) / 4;

            for (int i = 0; i < 4; i++)
            {
                mult[i] = mat[2, i] * mat[3, i];
              
                multip += $"\nColuna {i}: {mult[i]}";
            }

            MessageBox.Show($"Soma dos elementos da linha 1: {soma}\n\n" +
                $"Média dos elementos da linha 2: {media}\n\n" +
                $"Multiplicação entre os elementos da linha 3 e 4:{multip}");
        }

    }
}

