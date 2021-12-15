using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02CreditoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double saldo, credito;
            string mensagem;

            saldo = double.Parse(txtSaldo.Text.Replace(",", "."));

            if (saldo <= 200)
            {
                mensagem = "Sem crédito! Saldo Médio de R$ " + saldo.ToString("0.00").Replace(".", ",");
            }
            else if (saldo <= 400)
            {
                credito = saldo * 0.2;
                mensagem = "Crédito aprovado de R$ " + credito.ToString("0.00").Replace(".", ",") + "! Saldo Médio de R$ " + saldo.ToString("0.00").Replace(".", ",");
            }
            else if (saldo <= 600)
            {
                credito = saldo * 0.3;
                mensagem = "Crédito aprovado de R$ " + credito.ToString("0.00").Replace(".", ",") + "! Saldo Médio de R$ " + saldo.ToString("0.00").Replace(".", ",");
            }
            else
            {
                credito = saldo * 0.4;
                mensagem = "Crédito aprovado de R$ " + credito.ToString("0.00").Replace(".", ",") + "! Saldo Médio de R$ " + saldo.ToString("0.00").Replace(".", ",");
            }

            MessageBox.Show(mensagem, "Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
