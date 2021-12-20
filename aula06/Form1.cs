using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCriando_Click(object sender, EventArgs e)
        {
            FormOO formOO = new FormOO();
            formOO.Show();
        }

        private void BtnMath_Click(object sender, EventArgs e)
        {
            FormMath formMath = new FormMath();
            formMath.Show();
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            FormSaldo formSaldo = new FormSaldo();
            formSaldo.Show();
        }
    }
}
