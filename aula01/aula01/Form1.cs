using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblRes.Text = "";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // DECLARAÇÃO DE VARIÁVEIS
            double n1, n2, res; // valores numéricos com até 8 casas decimais

            // Leitura de valores
            n1 = Convert.ToDouble(txtNum1.Text);
            n2 = Convert.ToDouble(txtNum2.Text);

            // Cálculo
            res = n1 + n2;

            // Saíndo
            lblRes.Text = n1 + " + " + n2 + " = " + res.ToString("0.00");
        }
    }
}
