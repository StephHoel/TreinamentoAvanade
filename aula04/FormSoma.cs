using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula04
{
    public partial class FormSoma : Form
    {
        public FormSoma()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int n1, n2, cont, soma=0;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);
            cont = n2 - n1;

            for (int i = 1; i < cont; i++)
            {
                soma += (n1 + i);
            }

            MessageBox.Show($"Somatória: {soma}");
        }
    }
}
