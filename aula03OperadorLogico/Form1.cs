using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03OperadorLogico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txtUsuario.Text.ToUpper();
            senha = txtSenha.Text.ToUpper();

            if (usuario == "ADMINISTRADOR" && senha == "123")
            {
                MessageBox.Show("Bem vindo " + usuario);
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha incorreta");
            }
        }
    }
}
