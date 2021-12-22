using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            CalculadoraSalarioDolar calculadoraSalario = new CalculadoraSalarioDolar();

            calculadoraSalario.Valor = double.Parse(txtValor.Text);
            calculadoraSalario.Horas = double.Parse(txtHoras.Text);
            calculadoraSalario.Cotacao = double.Parse(txtDolar.Text);
            
            if (calculadoraSalario.Cotacao == 0)
            {
                MessageBox.Show($"Total a receber: R$ {calculadoraSalario.CalcularSalario():f2}");
            }
            else
                MessageBox.Show($"Total a receber: R$ {calculadoraSalario.CalcularSalario(calculadoraSalario.Cotacao):f2}");

        }
    }
}
