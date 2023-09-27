using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula10.Class
{
    class ContaPoupanca:Conta
    {
        public double ReajusteMensal { get; set; }

        public override void AtualizarSaldos()
        {
            // Método (abstrato na superclasse) herdado que deve ter, pelo menos, a assinatura inserida na subclasse
        }

        public void AtualizarSaldos(double reajuste)
        {
            double saldoAtualizado;

            // Sobrecarregar o método AtualizarSaldos de modo que ele receba por parâmetro uma porcentagem para reajuste (um valor decimal double)
            // Calcular a porcentagem informada sobre o saldo e somar ao saldo (Rendimento da poupança)
            // Armazenar a porcentagem informada no atributo ReajusteMensal
            // Apresentar o saldo anterior e o saldo atualizado

            ReajusteMensal = reajuste;

            saldoAtualizado = Saldo + (Saldo * reajuste);

            MessageBox.Show($"Saldo Anterior: {Saldo}\nSaldo Atualizado: {saldoAtualizado}", "Atualização de Saldo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Saldo = saldoAtualizado;
        }
    }
}
