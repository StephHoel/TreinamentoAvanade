using System;
using System.Collections.Generic;
using System.Text;

namespace aula07.Class
{
    class Custos
    {
        public double TotalPercurso { get; set; }

        public Custos(double totalPercurso)
        {
            this.TotalPercurso = totalPercurso;
        }
        public Custos()
        {
            this.TotalPercurso = 0;
        }

    }
}
