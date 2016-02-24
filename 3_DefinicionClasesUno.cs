using System;
using System.Windows.Forms;

namespace _1.IntroduccionDotNet
{
    public partial class _3_DefinicionClasesUno : Form
    {
        public _3_DefinicionClasesUno()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

            clsOperaciones operacion = new clsOperaciones();

            MessageBox.Show("La suma es igual a "+operacion.sumar(num1,num2));
        }
    }
}
