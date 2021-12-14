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
            string mensagem;
            MessageBoxIcon icone;

            idade = byte.Parse(txtIdade.Text);

            if (idade < 16)
            {
                mensagem = "Você não pode votar e nem embargar!";
                icone = MessageBoxIcon.Error;
            }
            else if (idade < 18)
            {
                mensagem = "Voto facultativo. Embarque permitido!";
                icone = MessageBoxIcon.Warning;
            }
            else
            {
                mensagem = "Voto obrigatório. Embarque permitido!";
                icone = MessageBoxIcon.Information;
            }

            MessageBox.Show(mensagem, "ONG", MessageBoxButtons.OK, icone);
        }
    }
}
