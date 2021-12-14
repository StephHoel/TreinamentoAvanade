using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula01
{
    public partial class Form1 : Form
    {
        // DECLARAÇÃO DE VARIÁVEIS
        double n1, n2, res; // valores numéricos com até 8 casas decimais

        public Form1()
        {
            InitializeComponent();
            lblRes.Text = "";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // Leitura de valores
            lerValores();

            // Cálculo
            res = n1 + n2;

            // Saíndo
            lblRes.Text = n1 + " + " + n2 + " = " + res.ToString("0.00");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            // Leitura de valores
            lerValores();

            // Cálculo
            res = n1 - n2;

            // Saíndo
            lblRes.Text = n1 + " - " + n2 + " = " + res.ToString("0.00");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            // Leitura de valores
            lerValores();

            // Cálculo
            res = n1 / n2;

            // Saíndo
            lblRes.Text = n1 + " / " + n2 + " = " + res.ToString("0.00");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // Leitura de valores
            lerValores();

            // Cálculo
            res = n1 * n2;

            // Saíndo
            lblRes.Text = n1 + " x " + n2 + " = " + res.ToString("0.00");
        }

        private void lerValores()
        {
            n1 = Convert.ToDouble(txtNum1.Text);
            n2 = Convert.ToDouble(txtNum2.Text);
        }
    }
}
