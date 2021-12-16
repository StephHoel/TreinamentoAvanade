using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula04
{
    public partial class FormFatorial : Form
    {
        public FormFatorial()
        {
            InitializeComponent();
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtFat.Text), cont = num, i = 1;
            string s;

            s = num + "! = " + num;

            while(i < num)
            {
                cont *= (num - i);
                s += $"x{num - i}";
                i++;
            }

            s += $" = {cont}";

            MessageBox.Show(s);

        }
    }
}
