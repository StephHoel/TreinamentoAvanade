using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    class CalculadoraSalarioDolar:CalculadoraSalario
    {
        public double Cotacao { get; set; }

        public CalculadoraSalarioDolar()
        {
            Cotacao = 0;
        }

        public override double CalcularSalario()
        {
            return Valor * Horas * this.Cotacao;
        }
    }
}
