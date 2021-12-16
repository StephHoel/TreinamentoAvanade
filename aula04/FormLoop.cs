using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula04
{
    public partial class FormLoop : Form
    {
        public FormLoop()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            int res, num, i = 1;
            string t;

            num = int.Parse(txtT.Text);

            while (i <= 10)
            {
                res = num * i;
                t = $"{num} X {i} = {res}";
                listBox.Items.Add(t);
                i++;
            }
        }
    }
}
