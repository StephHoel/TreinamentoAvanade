using System;
using System.Collections.Generic;
using System.Text;

namespace aula07.Class
{
    class Percurso
    {
        public double KmPercorrida { get; set; }
        public double ValorCombustivel { get; set; }
        public double ValorPedagio { get; set; }

        public Percurso(double kmPercorrida, double valorPedagio, double valorCombustivel)
        {
            this.KmPercorrida = kmPercorrida;
            this.ValorCombustivel = valorCombustivel;
            this.ValorPedagio = valorPedagio;
        }

        public Percurso()
        {
            this.KmPercorrida = 0;
            this.ValorCombustivel = 0;
            this.ValorPedagio = 0;
        }

        public void CadastrarPercurso()
        {

        }
        public void ListarPercurso()
        {

        }


    }
}
