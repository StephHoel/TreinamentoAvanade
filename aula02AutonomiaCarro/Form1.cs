using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02AutonomiaCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double kmAnt, kmPos, gas, res;

            kmAnt = Convert.ToDouble(txtAnt.Text.Replace(",", "."));
            kmPos = Convert.ToDouble(txtAtu.Text.Replace(",", "."));
            gas   = Convert.ToDouble(txtGas.Text.Replace(",", "."));

            res = (kmPos - kmAnt) / gas;

            txtRes.Text = res.ToString("0.00").Replace(".", ",") + " KM/L";
        }
    }
}
