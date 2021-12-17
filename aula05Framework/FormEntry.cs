using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
