using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula04
{
    public partial class FormSomaPares : Form
    {
        public FormSomaPares()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int n1, n2, cont, soma = 0;

            //Utilizando o looping do while, elabore um programa que
            //leia dois números quaisquer e
            //exiba a quantidade de números pares entre os dois valores digitados.
            //Lembre-se que o primeiro número deve ser sempre menor que o segundo.

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);
            cont = n2 - n1;

            for (int i = 1; i < cont; i++)
            {
                if ((n1 + i) % 2 == 0)
                    soma++;
            }

            MessageBox.Show($"Quantidade de Números Pares: {soma}");
        }
    }
}
