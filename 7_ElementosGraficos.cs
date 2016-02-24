using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.IntroduccionDotNet
{
    public partial class _7_ElementosGraficos : Form
    {
        public _7_ElementosGraficos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerChecks_Click(object sender, EventArgs e)
        {
            String categorias = "";
            int seleccion = selSeleccion.SelectedIndex;
            
            if (seleccion != -1){
                if (seleccion == 0){
                    if (chkComedia.Checked){
                        categorias = categorias + chkComedia.Text + "\n";
                    }

                    if (chkAccion.Checked){
                        categorias = categorias + chkAccion.Text + "\n";
                    }

                    if (chkCienciaFiccion.Checked){
                        categorias = categorias + chkCienciaFiccion.Text + "\n";
                    }

                    if (chkRomance.Checked){
                        categorias = categorias + chkRomance.Text + "\n";
                    }

                    if (chkAnimacion.Checked)
                    {
                        categorias = categorias + chkAnimacion.Text + "\n";
                    }
                }
                else
                {
                    if (rdbComedia.Checked)
                    {
                        categorias = categorias + rdbComedia.Text + "\n";
                    }

                    if (rdbAccion.Checked)
                    {
                        categorias = categorias + rdbAccion.Text + "\n";
                    }

                    if (rdbCienciaFiccion.Checked)
                    {
                        categorias = categorias + rdbCienciaFiccion.Text + "\n";
                    }

                    if (rdbRomance.Checked)
                    {
                        categorias = categorias + rdbRomance.Text + "\n";
                    }

                    if (rdbAnimacion.Checked)
                    {
                        categorias = categorias + rdbAnimacion.Text + "\n";
                    }
                }

                MessageBox.Show(categorias);

            }
            else
            {
                MessageBox.Show("Por favor seleccione una opcion");
            }

            
        }

        private void rdbVerRadio_Click(object sender, EventArgs e)
        {
            String categorias = "";




            MessageBox.Show(categorias);
        }

        private void selSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
