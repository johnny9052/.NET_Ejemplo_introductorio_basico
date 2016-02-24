using System;
using System.Windows.Forms;

namespace _1.IntroduccionDotNet
{
    public partial class _1_HolaMundo : Form
    {
        public _1_HolaMundo()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola como esta?");
        }
    }
}
