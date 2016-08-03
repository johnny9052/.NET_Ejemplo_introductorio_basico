using System;
using System.Windows.Forms;

namespace _1.IntroduccionDotNet
{
    public partial class _3_DefinicionClasesDos : Form
    {
        public _3_DefinicionClasesDos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            int cedula = Convert.ToInt32(txtCedula.Text);
            String fecha = txtFecha.Value.ToShortDateString();

            clsUsuario usuario = new clsUsuario(nombre, apellido, cedula, fecha);

            MessageBox.Show("El nombre del usuario es " + usuario.nombre + ", el apellido es " + 
                            usuario.apellido + ", con cedula no. "+usuario.cedula + 
                            " y nacio el "+usuario.fecha);
        }
    }
}
