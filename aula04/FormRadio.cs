using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula04
{
    public partial class FormRadio : Form
    {
        public FormRadio()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string radioSexo, radioCurso;

            if (radioF.Checked)
            {
                radioSexo = "Feminino";
            }
            else
            {
                radioSexo = "Masculino";
            }

            if (radioJava.Checked)
            {
                radioCurso = "Java";
            }
            else
            {
                radioCurso = "C#";
            }

            MessageBox.Show($"Você selecionou {radioSexo} e o Curso {radioCurso}",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
