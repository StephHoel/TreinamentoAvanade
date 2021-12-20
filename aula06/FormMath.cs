using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula06
{
    public partial class FormMath : Form
    {
        Math math = new Math();

        public FormMath()
        {
            InitializeComponent();
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            inp();
            math.Somar();
        }

        private void inp()
        {
            math.Num1 = double.Parse(txtNum1.Text);
            math.Num2 = double.Parse(txtNum2.Text);
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            inp();
            math.Subtrair();
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            inp();
            math.Multiplicar();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            inp();
            math.Dividir();
        }
    }
}
