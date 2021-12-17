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
    public partial class FormVetorInverso : Form
    {
        public FormVetorInverso()
        {
            InitializeComponent();
        }

        private void BtnComeçar_Click(object sender, EventArgs e)
        {
            int[] a = new int[15], b = new int[15];

            // Ler
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Interaction.InputBox($"Informe o elemento {i + 1}:"));
                listView1.Items.Add(a[i].ToString());
            }

            // Inverter Posição
            for (int i = 0; i < b.Length; i++)
            {
                int j = (b.Length - 1) - i;
                b[i] = a[j];
                listView2.Items.Add(b[i].ToString());

            }


        }
    }
}
