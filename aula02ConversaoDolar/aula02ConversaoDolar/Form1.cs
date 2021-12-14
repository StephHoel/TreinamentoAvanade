using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02ConversaoDolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtRes.Text = "Informe os valores primeiro";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double value, tax, res;

            value = Convert.ToDouble(txtValue.Text);
            tax   = Convert.ToDouble(txtTax.Text);

            res = value * tax;

            txtRes.Text = $"R$ {res.ToString("0.00")}";
        }
    }
}
