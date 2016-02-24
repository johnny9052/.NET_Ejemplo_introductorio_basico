using System;
using System.Windows.Forms;

namespace _1.IntroduccionDotNet
{
    public partial class _2_DefinicionVariables : Form
    {
        public _2_DefinicionVariables()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String nombre = "Johnny Alexander";
            int edad = 24;
            MessageBox.Show("Hola " + nombre + ", me han contado que tienes " + edad + " años");
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            int num2 = 4;
            MessageBox.Show("La suma de los numeros es " + (num1 + num2));
        }
    }
}
