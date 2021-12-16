using System;
using System.Windows.Forms;

namespace aula03HomeWork
{
    public partial class Form1 : Form
    {
        double saldo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int menu = cmbTransacao.SelectedIndex;

            if (!(double.TryParse(txtValor.Text, out double valor)) && (valor <= 0 && menu != 2))
            {
                MessageBox.Show("Valor informado incorretamente!", "Erro");
                txtValor.Clear();
                txtValor.Focus();
                return;
            }


            switch (menu)
            {
                case 0: // Depósito
                    saldo += valor;
                    MessageBox.Show($"Depósito de R$ {valor.ToString("0.00")} realizado com sucesso!", "Depósito");
                    break;
                case 1: // Saque
                    saldo -= valor;
                    MessageBox.Show($"Saque de R$ {valor.ToString("0.00")} realizado com sucesso!", "Saque");
                    break;
                case 2: // Ver Saldo
                    MessageBox.Show($"Saldo de R$ {saldo.ToString("0.00")} em conta.", "Saldo");
                    break;
                default:
                    MessageBox.Show("Operação inválida, tente novamente!", "Erro");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTransacao.SelectedIndex = 0;
        }
    }
}
