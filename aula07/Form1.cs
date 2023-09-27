using aula07.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVendedor_Click(object sender, EventArgs e)
        {

        }

        private void BtnPercurso_Click(object sender, EventArgs e)
        {
            Percurso p = new Percurso();
            Custos c = new Custos();

            //p.val
        }
    }
}
