using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;
            string mensagem;
            MessageBoxIcon icone;

            nota1 = double.Parse(txtNota1.Text.Replace(",", "."));
            nota2 = double.Parse(txtNota2.Text.Replace(",", "."));
            nota3 = double.Parse(txtNota3.Text.Replace(",", "."));

            media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                mensagem = "Aprovado! Média: " + media.ToString("0.00").Replace(".",",");
                icone = MessageBoxIcon.Information;
            }
            else if (media >= 4)
            {
                mensagem = "Prova Final! Média: " + media.ToString("0.00").Replace(".", ",");
                icone = MessageBoxIcon.Warning;
            }
            else
            {
                mensagem = "Reprovado! Média: " + media.ToString("0.00").Replace(".", ",");
                icone = MessageBoxIcon.Error;
            }

            MessageBox.Show(mensagem, "Média do Aluno", MessageBoxButtons.OK, icone);
        }
    }
}
