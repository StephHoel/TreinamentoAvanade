using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace aula05
{
    public partial class FormArray : Form
    {
        public FormArray()
        {
            InitializeComponent();
        }

        private void BtnCalular_Click(object sender, EventArgs e)
        {
            double[] v = new double[5];
            double total = 0;

            v[0] = double.Parse(txtV1.Text);
            v[1] = double.Parse(txtV2.Text);
            v[2] = double.Parse(txtV3.Text);
            v[3] = double.Parse(txtV4.Text);
            v[4] = double.Parse(txtV5.Text);

            foreach(var i in v)
            {
                total += i;
            }

            MessageBox.Show($"Total de vendas: R$ {total.ToString("0.00")}");
        }
    }
}
