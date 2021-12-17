using System;
using System.Windows.Forms;

namespace aula05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            FormArray formArray = new FormArray();
            formArray.Show();
        }
    }
}
