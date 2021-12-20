using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace aula06
{
    public class Math
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public Math()
        {
            this.Num1 = 0;
            this.Num2 = 0;
        }

        public void Somar()
        {
            MessageBox.Show($"{this.Num1} + {this.Num2} = {this.Num1+this.Num2}");
        }
        public void Subtrair()
        {
            MessageBox.Show($"{this.Num1} - {this.Num2} = {this.Num1-this.Num2}");
        }
        public void Multiplicar()
        {
            MessageBox.Show($"{this.Num1} X {this.Num2} = {this.Num1*this.Num2}");
        }
        public void Dividir()
        {
            MessageBox.Show($"{this.Num1} / {this.Num2} = {this.Num1/this.Num2}");
        }
    }
}
