using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02IfEncadeado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte idade;

            idade = byte.Parse(txtIdade.Text);

            if (idade < 16)
            {
                MessageBox.Show("Você não pode votar e nem embargar!", "ONG",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (idade < 18)
            {
                MessageBox.Show("Voto facultativo. Embarque permitido!", "ONG",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Voto obrigatório. Embarque permitido!", "ONG",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
