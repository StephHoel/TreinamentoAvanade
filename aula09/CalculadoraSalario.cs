using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    class CalculadoraSalario
    {
        public double Valor { get; set; }
        public double Horas { get; set; }

        public CalculadoraSalario()
        {
            Valor = 0;
            Horas = 0;
        }

        public virtual double CalcularSalario()
        {
            return Valor * Horas;
        }

        public double CalcularSalario(double cotacao)
        {
            return Valor * Horas * cotacao;
        }
    }
}
