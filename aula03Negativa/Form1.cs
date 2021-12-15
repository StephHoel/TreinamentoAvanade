using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03Negativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string tipoUser;

            tipoUser = txtUsuario.Text;

            if(tipoUser != "ADMINISTRADOR")
            {
                MessageBox.Show("Sem poderes administrativos!");
            }
        }
    }
}
