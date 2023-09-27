using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula10.Class
{
    class ContaCorrente:Conta
    {
        public double LimiteEspecial { get; set; }

        public override void AtualizarSaldos()
        {
            double saldoAtualizado = Saldo;

            // Implementação do método (abstrato na superclasse) que verifica se o atributo saldo está negativo, caso esteja, calcula 8% (0.08) sobre o valor excedente e subtrai do saldo (Cobra juros pela utilização de limite especial)
            // Apresentar o saldo anterior e o saldo atualizado

            if (Saldo < 0)
                saldoAtualizado += Saldo * 0.08; // fazendo o cálculo e adicionando o valor negativo como juros

            MessageBox.Show($"Saldo Anterior: {Saldo}\nSaldo Atualizado: {saldoAtualizado}", "Atualização de Saldo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Saldo = saldoAtualizado;
        }

        public override void Debitar(double valor)
        {
            // Sobrescrever o método debitar considerando o atributo LimiteEspecial. O saldo poderá ficar negativo até o valor indicado em LimiteEspecial

            if ((Saldo + LimiteEspecial) < valor) //não permitir fazer saque
            {
                MessageBox.Show("Saldo Insuficiente. Operação cancelada!", "Saque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // permitir fazer saque
            {
                Saldo -= valor;
            }
        }
    }
}
