﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            switch (cmbEscolha.SelectedIndex)
            {
                case 1:
                    MessageBox.Show("Você selecionou a equipe Araribolt");
                    break;
                case 2:
                    MessageBox.Show("Você selecionou a equipe Dragões da Enseada");
                    break;
                case 3:
                    MessageBox.Show("Você selecionou a equipe Dragões da Tormenta");
                    break;
                case 4:
                    MessageBox.Show("Você selecionou a equipe Grifos da Guanabara");
                    break;
                case 5:
                    MessageBox.Show("Você selecionou a equipe Rio Ravens");
                    break;
                default:
                    MessageBox.Show("Selecione uma equipe");
                    break;
            }
        }
    }
}
