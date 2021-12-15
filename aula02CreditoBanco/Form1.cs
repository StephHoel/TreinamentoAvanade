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

            if (!double.TryParse(txtSaldo.Text.Replace(",", "."), out saldo))
            {
                MessageBox.Show("Digite um valor válido!", "Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaldo.Clear();
                txtSaldo.Focus();
                return;
            }
            else
            {
                if (saldo <= 200)
                {
                    credito = 0;
                    mensagem = "Crédito Reprovado!";
                }
                else if (saldo <= 400)
                {
                    credito = saldo * 0.2;
                    mensagem = "Crédito Aprovado!";
                }
                else if (saldo <= 600)
                {
                    credito = saldo * 0.3;
                    mensagem = "Crédito Aprovado!";
                }
                else
                {
                    credito = saldo * 0.4;
                    mensagem = "Crédito Aprovado!";
                }

                MessageBox.Show($"{mensagem}\nCrédito disponível: R$ {credito.ToString("0.00").Replace(".", ",")}" +
                                $"\nSaldo Médio de R$ {saldo.ToString("0.00").Replace(".", ",")}",
                                "Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
