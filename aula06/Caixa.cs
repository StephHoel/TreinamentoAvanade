using System;
using System.Collections.Generic;
using System.Text;

namespace aula06
{
    public class Caixa
    {
        public double Valor { get; set; }
        public double Saldo { get; set; }

        public Caixa()
        {
            this.Valor = 0;
            this.Saldo = 0;
        }

        public void Depositar()
        {
            this.Saldo += this.Valor;
        }

        public void Sacar()
        {
            this.Saldo -= this.Valor;
        }
    }
}
