using System;
using System.Collections.Generic;
using System.Text;

namespace aula07.Class
{
    class Vendedor
    {
        private string Nome { get; set; }
        private double SalarioBase { get; set; }

        public Vendedor(string nome, double salarioBase)
        {
            this.Nome = nome;
            this.SalarioBase = salarioBase;
        }

        public double CalculoComissao(double valorVendido)
        {
            return valorVendido * 0.2;
        }
    }
}
