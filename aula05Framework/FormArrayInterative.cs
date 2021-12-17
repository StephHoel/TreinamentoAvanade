using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace aula05Framework
{
    public partial class FormArrayInterative : Form
    {
        public FormArrayInterative()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            double[] v = new double[5];
            double total = 0;

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = double.Parse(Interaction.InputBox($"Digite o valor da venda do vendedor {i + 1}:"));
                total += v[i];
            }

            MessageBox.Show($"Total das vendas R$ {total.ToString("0.00")}");

        }
    }
}
