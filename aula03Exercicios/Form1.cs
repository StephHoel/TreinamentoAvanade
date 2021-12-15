using System;
using System.Windows.Forms;

namespace aula03Exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double t1, t2, t3;
            string mensagem, titulo;

            // Dados três valores X, Y e Z,
            // verificar se eles podem ser os comprimentos dos lados de um triângulo,
            // e se forem, verificar se é um triângulo equilátero, isósceles ou escaleno.
            // Se eles não formarem um triângulo, escrever uma mensagem.
            // Antes da elaboração do programa, torna-se
            // necessário a revisão de algumas propriedades e definições.
            // Propriedade – o comprimento de cada lado de um triângulo é menor do que
            // a soma dos comprimentos dos outros dois lados.
            // Definição 1 - chama-se de triângulo equilátero o que tem os comprimentos
            // dos três lados iguais;
            // Definição 2 - chama-se de triângulo isósceles o triângulo que tem os
            // comprimentos de dois lados iguais;
            // Definição 3 - chama-se triângulo escaleno o triângulo que tem os
            // comprimentos dos três lados diferentes.

            t1 = double.Parse(txtT1.Text.Replace(",", "."));
            t2 = double.Parse(txtT2.Text.Replace(",", "."));
            t3 = double.Parse(txtT3.Text.Replace(",", "."));

            if (t1 > (t2 + t3) || t2 > (t1 + t3) || t3 > (t1 + t2))
            {
                mensagem = "Esses valores não formam um triângulo";
                titulo = "Erro";
            }
            else
            {
                //equilátero: t1 == t2 && t2 == t3
                //isósceles: t1 == t2 || t2 == t3 || t1 == t3
                //escaleno: t1 != t2 || t2 != t3 || t1 != t3

                titulo = "Triângulos";

                if (t1 == t2 && t2 == t3)
                {
                    mensagem = "Triângulo Equilátero";

                }
                else if (t1 == t2 || t2 == t3 || t1 == t3)
                {
                    mensagem = "Triângulo Isósceles";
                }
                else
                {
                    mensagem = "Triângulo Escaleno";
                }
            }

            MessageBox.Show(mensagem, titulo);

            txtT1.Clear();
            txtT2.Clear();
            txtT3.Clear();
            txtT1.Focus();

        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            //Utilizando a estrutura switch case, elabore um programa que
            //leia um número referente a um mês do ano e exiba o nome do mês.
            //Se for digitado um valor que não corresponda a um mês válido,
            //exiba uma mensagem indicando tal situação.

            string mensagem = "Mês inexistente";

            if (byte.TryParse(txtMes.Text, out byte mes) && mes <= 12)
            {
                switch (mes)
                {
                    case 1:
                        mensagem = "Janeiro";
                        break;
                    case 2:
                        mensagem = "Fevereiro";
                        break;
                    case 3:
                        mensagem = "Março";
                        break;
                    case 4:
                        mensagem = "Abril";
                        break;
                    case 5:
                        mensagem = "Maio";
                        break;
                    case 6:
                        mensagem = "Junho";
                        break;
                    case 7:
                        mensagem = "Julho";
                        break;
                    case 8:
                        mensagem = "Agosto";
                        break;
                    case 9:
                        mensagem = "Setembro";
                        break;
                    case 10:
                        mensagem = "Outubro";
                        break;
                    case 11:
                        mensagem = "Novembro";
                        break;
                    case 12:
                        mensagem = "Dezembro";
                        break;

                }
            }

            MessageBox.Show(mensagem);
            txtMes.Clear();
            txtMes.Focus();

        }
    }
}
