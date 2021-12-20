using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula06
{
    public partial class FormSaldo : Form
    {
        Caixa caixa = new Caixa();

        public FormSaldo()
        {
            InitializeComponent();
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            caixa.Valor = double.Parse(txtValor.Text);
            caixa.Depositar();
            MessageBox.Show($"Valor Depositado: R$ {caixa.Valor.ToString("0.00")}");
        }

        private void BtnSacar_Click(object sender, EventArgs e)
        {
            caixa.Valor = double.Parse(txtValor.Text);
            caixa.Sacar();
            MessageBox.Show($"Valor Sacado: R$ {caixa.Valor.ToString("0.00")}");
        }
    }
}
