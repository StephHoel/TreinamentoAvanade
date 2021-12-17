using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace aula05Framework
{
    public partial class FormEntry : Form
    {
        public FormEntry()
        {
            InitializeComponent();
        }

        private void btnArrayInterative_Click(object sender, EventArgs e)
        {
            FormArrayInterative formArrayInterative = new FormArrayInterative();
            formArrayInterative.Show();
        }

        private void BtnArrayInverse_Click(object sender, EventArgs e)
        {
            FormVetorInverso formVetorInverso = new FormVetorInverso();
            formVetorInverso.Show();
        }

        private void BtnNota_Click(object sender, EventArgs e)
        {

            double[] v = new double[10];
            double total = 0, media;

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = double.Parse(Interaction.InputBox($"Digite a nota do aluno {i + 1}:"));
                total += v[i];
            }

            media = total / v.Length;

            MessageBox.Show($"A média da turma é de: {media.ToString("0.00")}");
        }
    }
}
