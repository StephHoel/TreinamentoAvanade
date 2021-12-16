using System;
using System.Windows.Forms;

namespace aula04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            FormRadio fRadio = new FormRadio();
            fRadio.Show();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            FormLoop fLoop = new FormLoop();
            fLoop.Show();
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            FormFatorial fFatorial = new FormFatorial();
            fFatorial.Show();
        }

        private void btnSoma2_Click(object sender, EventArgs e)
        {
            FormSoma fSoma = new FormSoma();
            fSoma.Show();
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            FormSomaPares fPares = new FormSomaPares();
            fPares.Show();
        }
    }
}
