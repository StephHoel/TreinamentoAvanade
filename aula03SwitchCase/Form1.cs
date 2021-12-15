using System;
using System.Windows.Forms;

namespace aula03SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte codigo;

            if (!byte.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("Digite o código corretamente!");
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }

            switch (codigo)
            {
                case 1: 
                    MessageBox.Show("Elogio Profissional"); 
                    break;
                case 2:
                    MessageBox.Show("Elogio Físico");
                    break;
                case 3:
                    MessageBox.Show("Elogio Pessoal");
                    break;
                default:
                    MessageBox.Show("Código Inválido");
                    break;
            }
        }
    }
}
