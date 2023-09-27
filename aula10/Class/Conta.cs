using System.Windows.Forms;

namespace aula10.Class
{
     class Conta
    {
        public double Saldo { get; set; }

        public void Creditar(double valor)
        {
            // Recebe um valor por parâmetro e soma ao atributo saldo
            Saldo += valor;
        }

        public virtual void Debitar(double valor)
        {
            // Recebe um valor por parâmetro e subtrai do atributo saldo desde que haja saldo suficiente, caso não tenha, apresenta mensagem de saldo insuficiente
            if (Saldo < valor) //não permitir fazer saque
            {
                MessageBox.Show("Saldo Insuficiente. Operação cancelada!", "Saque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // permitir fazer saque
            {
                Saldo -= valor;
            }
        }

        public virtual void AtualizarSaldos()
        {
            // Somente a assinatura do método
        }
    }
}
