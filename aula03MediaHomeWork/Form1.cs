using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03MediaHomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double n1, n2, media, frequencia,assistida, total;
            string situacao;

            //Elabore um programa que leia 2 notas escolares. Calcule a média
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            media = (n1 + n2) / 2;

            //Leia também a quantidade de aulas dadas e a quantidade de aulas assistidas
            //pelo aluno e calcule sua frequencia :
            //(aulasAssistidas / aulasDadas) * 100
            assistida = double.Parse(txtAssistida.Text);
            total = double.Parse(txtTotal.Text);
            frequencia = (assistida / total) * 100;

            //O aluno somente estará aprovado com média maior ou igual a 7 e 
            //frequencia mínima de 75 %
            if (media >= 7 && frequencia >= 75)
                situacao = "Aprovado";
            else
                situacao = "Reprovado";

            //Exiba a média, a frequência e a mensagem informando sua situação
            MessageBox.Show($"Média: {media.ToString("0.00")}\n" +
                $"Frequência: {frequencia.ToString("0.00")}%\n" +
                $"Situação: {situacao}", "Resultado");

        }
    }
}
